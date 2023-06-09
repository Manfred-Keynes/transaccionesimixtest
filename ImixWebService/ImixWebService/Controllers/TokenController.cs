using ImixWebService.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ImixWebService.Controllers
{
    [RoutePrefix("api/Token")]
    public class TokenController : ApiController
    {
        private cooitzacoreEntities db = new cooitzacoreEntities();
        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<IHttpActionResult> Login(LoginViewModel login)
        {
            // Verificar las credenciales del usuario y generar el token si es válido

            var estatusLogin = await ValidarCredenciales(login.usuarioWebService, login.clave, login.llave);

            if (estatusLogin)
            {
                var secret = ConfigurationManager.AppSettings["TokenSecret"];
                var issuer = ConfigurationManager.AppSettings["Issuer"];
                var audience = ConfigurationManager.AppSettings["Audience"];
                var tokenHandler = new JwtSecurityTokenHandler();
                var now = DateTime.UtcNow;
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Issuer = issuer,
                    Audience = audience,
                    Subject = new ClaimsIdentity(new[]
                    {
                new Claim(ClaimTypes.Name, login.usuarioWebService)
                }),
                    Expires = now.AddMinutes(30),
                    NotBefore = now,
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret)),
                        SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);
                return Ok(new
                {
                    Codigo = 200,
                    Descripcion = "Success",
                    Token = tokenString
                });
            }

            // Devolver un error en caso de credenciales inválidas
            return BadRequest("Invalid credentials.");
        }

        public async Task<bool> ValidarCredenciales(string usuarioNombre, string password, string token)
        {
            /*se consulta en la base de datos si existe el usuario ingresado y se alamcena en el objeto usuario*/
            var usuario = await db.TblUsuarios.FirstOrDefaultAsync(x => x.usuario == usuarioNombre);
            /*se valida el contenido del objeto usuario*/
            if (usuario == null)
                return false;
            /*se ejecuta la funsion VerifyPasswordHash pra validar las contraseñas*/
            if ((!VerifyHashedPassword(usuario.token, token)) || (!VerifyHashedPassword(usuario.clave, password)))
            {
                return false;
            }
            return true;
        }

        /*a partir de estas contatnes se encripta una contraseña*/

        private const int _pbkdf2IterCount = 1000;//la cantidad maxima de veces que se llega a iterar oara generar la hash en la funcion que encripta
        private const int _pbkdf2SubkeyLength = 256 / 8; //primera parte de la combinacion para encriptar una contraseña es de 32 bytes
        private const int _saltSize = 128 / 8;//segunda parte de la combinacion para encriptar una contraseña mas conocida como salt o Key es de 16 bytes
        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {

            var hashedPasswordBytes = Convert.FromBase64String(hashedPassword);
            if (hashedPasswordBytes.Length != (1 + _saltSize + _pbkdf2SubkeyLength) || hashedPasswordBytes[0] != 0x00)
            {
                return false;
            }
            var salt = new byte[_saltSize];
            Buffer.BlockCopy(hashedPasswordBytes, 1, salt, 0, _saltSize);
            var storedSubkey = new byte[_pbkdf2SubkeyLength];
            Buffer.BlockCopy(hashedPasswordBytes, 1 + _saltSize, storedSubkey, 0, _pbkdf2SubkeyLength);
            byte[] generatedSubkey;
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, _pbkdf2IterCount))
            {
                generatedSubkey = deriveBytes.GetBytes(_pbkdf2SubkeyLength);
            }
            return ByteArraysEqual(storedSubkey, generatedSubkey);
        }
        [MethodImpl(MethodImplOptions.NoOptimization)]
        private static bool ByteArraysEqual(byte[] a, byte[] b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }
            if (a == null || b == null || a.Length != b.Length)
            {
                return false;
            }
            var areSame = true;
            for (var i = 0; i < a.Length; i++)
            {
                areSame &= (a[i] == b[i]);
            }
            return areSame;
        }
        /*--------------------------------------------------------------------------------------*/
    }
}
