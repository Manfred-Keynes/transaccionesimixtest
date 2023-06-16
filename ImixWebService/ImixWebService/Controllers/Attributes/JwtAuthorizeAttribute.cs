using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace ImixWebService.Controllers.Attributes
{
    public class JwtAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var ctx = actionContext.Request.GetOwinContext();
            var jwtOptions = new JwtBearerAuthenticationOptions
            {
                AuthenticationMode = AuthenticationMode.Active,
                TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzcrecemosJuntos767095515919")),
                    ValidIssuer = "https://localhost:44386",
                    ValidAudience = "https://localhost:44386",
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                }
            };

            // Obtener el token de la solicitud
            var token = ctx.Request.Headers["Authorization"]?.Replace("Bearer ", "");

            if (string.IsNullOrEmpty(token))
            {
                //actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                //return;

                var responseObj = new
                {
                    Codigo = 5001,
                    Descripcion = "Token invalido",
                    Token = "Unauthorized"
                };

                var response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                response.Content = new System.Net.Http.ObjectContent<object>(responseObj, new System.Net.Http.Formatting.JsonMediaTypeFormatter());
                actionContext.Response = response;
                return;

            }

            try
            {
                // Validar el token
                var tokenHandler = new JwtSecurityTokenHandler();
                var claimsPrincipal = tokenHandler.ValidateToken(token, jwtOptions.TokenValidationParameters, out var securityToken);

                // Agregar las claims al principal de la solicitud
                ctx.Authentication.User = claimsPrincipal;
            }
            catch
            {
                //actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                //return;
                var responseObj = new
                {
                    Codigo = 5001,
                    Descripcion = "Token invalido",
                    Token = "Unauthorized"
                };

                var response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                response.Content = new System.Net.Http.ObjectContent<object>(responseObj, new System.Net.Http.Formatting.JsonMediaTypeFormatter());
                actionContext.Response = response;
                return;
            }

            base.OnAuthorization(actionContext);
        }
    }
}