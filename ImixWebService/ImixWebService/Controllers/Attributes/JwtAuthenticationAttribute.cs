using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ImixWebService.Controllers.Attributes
{
    public class JwtAuthenticationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string SecretKey = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzcrecemosJuntos767095515919"; // Reemplazar con tu propia clave secreta
            var headers = actionContext.Request.Headers;
            if (headers.Authorization == null || headers.Authorization.Scheme != "Bearer")
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                return;
            }

            var tokenString = headers.Authorization.Parameter;
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                var key = Convert.FromBase64String(SecretKey);
                var validationParameters = new TokenValidationParameters()
                {
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidIssuer = "https://localhost:44386", // Reemplazar con el nombre de tu emisor
                    ValidateAudience = true,
                    ValidAudience = "https://localhost:44386" // Reemplazar con el nombre de tu audiencia
                };

                var principal = tokenHandler.ValidateToken(tokenString, validationParameters, out SecurityToken validatedToken);
                actionContext.RequestContext.Principal = principal;
            }
            catch (Exception)
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                return;
            }

            base.OnActionExecuting(actionContext);
        }
    }
}