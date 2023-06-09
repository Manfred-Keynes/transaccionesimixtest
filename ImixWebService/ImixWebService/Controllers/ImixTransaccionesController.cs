using ImixWebService.Controllers.Attributes;
using ImixWebService.Models;
using ImixWebService.Models.RespuestaApi;
using ImixWebService.Models.RespuestaRespos;
using ImixWebService.Models.Transacciones;
using ImixWebService.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ImixWebService.Controllers
{
    [RoutePrefix("api/ImixTransacciones")]
    public class ImixTransaccionesController : ApiController
    {
        private cooitzacoreEntities db = new cooitzacoreEntities();
        private IRepositorio repositorio;
        public ImixTransaccionesController()
        {
            this.repositorio = new Repositorio();
        }
        [HttpPost]
        [Route("Create")]
        [JwtAuthorize]
        public async Task<IHttpActionResult> Create(Transaccion transaccion)
        {
            long? idTransaccionesImix = 0;

            var repoRequest = await repositorio.Bitacora(transaccion, 1,0,null);

            if (repoRequest.codigo != 1)
            {
                var respuestaRequest = new RespuestaApi()
                {
                    codigo = 101,
                    descripcion = repoRequest.descripcion,
                    idCooitza = 0
                };
                return Content(HttpStatusCode.OK, respuestaRequest);
            }
            idTransaccionesImix = repoRequest.idCooitza;


            var repoSave = await repositorio.Bitacora(transaccion, 2, idTransaccionesImix, null);
            if (repoSave.codigo != 1)
            {
                var respuestaResponse = new RespuestaApi()
                {
                    codigo = 101,
                    descripcion = repoRequest.descripcion,
                    idCooitza = 0
                };
                return Content(HttpStatusCode.OK, respuestaResponse);
            }
            idTransaccionesImix = repoRequest.idCooitza;


            var respuesta = new RespuestaApi()
            {
                codigo = 200,
                descripcion = repoRequest.descripcion,
                idCooitza = idTransaccionesImix
            };
            var repoResponses = await repositorio.Bitacora(null, 3, idTransaccionesImix, respuesta);

            if (repoResponses.codigo != 1)
            {
                var respuestaResponse = new RespuestaApi()
                {
                    codigo = 101,
                    descripcion = repoRequest.descripcion,
                    idCooitza = 0
                };
                return Content(HttpStatusCode.OK, respuestaResponse);
            }
            return Content(HttpStatusCode.OK, respuesta);


        }
    }
}
