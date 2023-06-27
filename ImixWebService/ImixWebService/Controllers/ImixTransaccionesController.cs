using ImixWebService.Controllers.Attributes;
using ImixWebService.Models;
using ImixWebService.Models.Pagos;
using ImixWebService.Models.Pagos.Resolve;
using ImixWebService.Models.RespuestaApi;
using ImixWebService.Models.RespuestaRespos;
using ImixWebService.Models.Transacciones;
using ImixWebService.Repositorios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ImixWebService.Controllers
{
    [RoutePrefix("api/ImixTransacciones")]
    public class ImixTransaccionesController : ApiController
    {
        private cooitzacoretEntities db = new cooitzacoretEntities();
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
            var usuariClaims = User.Identity.Name;

            var usuario = await db.TblUsuarios.FirstOrDefaultAsync(x => x.usuario == usuariClaims);
            /** PRIMERA LLAMADA A LA BITACORA*/
            var repoRequest = await repositorio.Bitacora(transaccion, 1, 0, null, usuario.idTblUsuarios);

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
            /* VALIDA QUE LOS CAMPOS OBLIGATORIOS SEAN CORRECTOS*/
            if (!ModelState.IsValid)
            {
                var entradasErroneas = ModelState
                    .Where(x => x.Value.Errors.Any())
                    .Select(x => x.Key.Split('.').Last())
                    .ToList();
                var respuestaRequest = new RespuestaApi()
                {
                    codigo = 5001,
                    descripcion = $"Existen datos de entrada vacios o nulos: {string.Join(",", entradasErroneas)}",
                    idCooitza = 0
                };
                var repo = await repositorio.Bitacora(null, 3, idTransaccionesImix, respuestaRequest,0);
                if (repo.codigo != 1)
                {
                    return Content(HttpStatusCode.OK, new
                    {
                        codigo = 101,
                        descripcion = repo.descripcion,
                        idCooitza = repo.idCooitza
                    });
                }
                return Content(HttpStatusCode.OK, respuestaRequest);
            }

            var repoSave = await repositorio.Bitacora(transaccion, 2, idTransaccionesImix, null,0);
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
            var repoResponses = await repositorio.Bitacora(null, 3, idTransaccionesImix, respuesta,0);

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
        [HttpPost]
        [Route("PaymentRecord")]
        [JwtAuthorize]
        public async Task<IHttpActionResult> PaymentRecord(Payment payment)
        {
            var result = new { codigo = 0, descripcion = string.Empty, resultado = (object)null, idCooitza = (long?)0 };


            var usurClaim = User.Identity.Name;
            var usuario = db.TblUsuarios.FirstOrDefault(x => x.usuario == usurClaim);
            PagosRepositorio repoResult = new PagosRepositorio();
            if (usuario == null)
            {
                result = new
                {
                    codigo = 503,
                    descripcion = "NO SE RECONOCE EL USARIO INGRESADO",
                    resultado = (object)null,
                    idCooitza = (long?)0
                };

                repoResult = await repositorio.BitacoraPago(0, 1, payment, null, usuario.idTblUsuarios);
                if (repoResult.codigo != 1)
                {
                    //Asignar nuevos valores a las propiedades
                    result = new { codigo = 101, descripcion = repoResult.descripcion, resultado = (object)null, idCooitza = (long?)0 };
                }
                return Content(HttpStatusCode.OK, result);
            }


            if (!ModelState.IsValid)
            {
                var entradasErroneas = ModelState
                    .Where(x => x.Value.Errors.Any())
                    .Select(x => x.Key.Split('.').Last())
                    .ToList();

                result = new
                {
                    codigo = 5001,
                    descripcion = $"Existen datos de entrada vacios o nulos: {string.Join(",", entradasErroneas)}",
                    resultado = (object)null,
                    idCooitza = (long?)0
                };

                repoResult = await repositorio.BitacoraPago(repoResult.idTblPagosImix, 5, result, null, 0);//guarda en la bitacora ok
                if (repoResult.codigo != 1)/**valida si se guardaron los registros con exito si el codigo que devuelve el repositorio es diferente de 0 se procede a modifica el objeto de respuesta*/
                {
                    //Asignar nuevos valores a las propiedades
                    result = new { codigo = 501, descripcion = repoResult.descripcion, resultado = (object)null, idCooitza = repoResult.idTblPagosImix };
                    return Content(HttpStatusCode.OK, result);
                }

                return Content(HttpStatusCode.OK, result);
            }

            //obtenemos la configuracion del la consulta desde la base de datos
            var configuracion = db.TblConfiguracionesPagos.FirstOrDefault(x => x.idCatEstados == 1);
            //se construye la fecha en el formato solicitado
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyyMMddHHmmss.ffffff");
            //se genera el codigo unico 
            Random random = new Random();
            string code = "";//<--------- codigo
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 10);
                code += randomNumber.ToString();
            }
            var fechaValida = validarFecha(payment.fechaPago);

            if (!fechaValida)
            {
                //Asignar nuevos valores a las propiedades
                result = new { codigo = 504, descripcion = "LA FECHA NO ES VALIDA", resultado = (object)null, idCooitza = repoResult.idTblPagosImix };

                repoResult = await repositorio.BitacoraPago(repoResult.idTblPagosImix, 5, result, null,0);
                if (repoResult.codigo != 1)
                {
                    //Asignar nuevos valores a las propiedades
                    result = new { codigo = 101, descripcion = repoResult.descripcion, resultado = (object)null, idCooitza = repoResult.idTblPagosImix };
                }
                return Content(HttpStatusCode.OK, result);
            }
            var tblTransaccionesImix = db.TransaccionesImix.FirstOrDefault(x=> x.idDocumentoSocio == payment.dpi && x.creditCode == payment.creditoCooitza);
            if (tblTransaccionesImix == null)
            {
                result = new
                {
                    codigo = 605,
                    descripcion = "SE PRODUJO UN ERROR AL PROCESAR EL internalCreditCode NO EXISTE",
                    resultado = (object)null,
                    idCooitza = repoResult.idTblPagosImix
                };
                repoResult = await repositorio.BitacoraPago(repoResult.idTblPagosImix, 5, result, null, 0);
                if (repoResult.codigo != 1)
                {
                    //Asignar nuevos valores a las propiedades
                    result = new { codigo = 101, descripcion = repoResult.descripcion, resultado = (object)null, idCooitza = repoResult.idTblPagosImix };
                }
                return Content(HttpStatusCode.OK, result);
            }

            var creditPayment = new
            {
                meta = new
                {
                    version = configuracion.version,
                    requestDate = formattedDate,
                    clientId = configuracion.clientId,
                    requestReference = code
                },
                data = new
                {
                    creditId = tblTransaccionesImix.internalCreditCode,
                    code = payment.creditoCooitza,
                    paymentValue = payment.montoPago,
                    paymentDate = payment.fechaPago,
                },
                requestSignature = configuracion.requestSignature
            };
            repoResult = await repositorio.BitacoraPago(repoResult.idTblPagosImix, 2, creditPayment, null,0);
            if (repoResult.codigo != 1)
            {
                //Asignar nuevos valores a las propiedades
                result = new { codigo = 101, descripcion = repoResult.descripcion, resultado = (object)null, idCooitza = repoResult.idTblPagosImix };
                return Content(HttpStatusCode.OK, result);
            }
            ResutldadoWS resutldadoWS = new ResutldadoWS();
            using (var cliente = new HttpClient())
            {
                string _baseurl = "https://api-dev.innovatech.corresponsalia.digital";
                cliente.BaseAddress = new Uri(_baseurl);

                var content = new StringContent(JsonConvert.SerializeObject(creditPayment), Encoding.UTF8, "application/json");
                var response = await cliente.PostAsync("/credit/creditPayment", content);
                if (!response.IsSuccessStatusCode)
                {
                    var jsonError = await response.Content.ReadAsStringAsync();
                    var respuestaError = JsonConvert.DeserializeObject<object>(jsonError);
                    
                    result = new
                    {
                        codigo = 602,
                        descripcion = "SE PRODUJO UN ERROR AL PROCESAR LOS DATOS",
                        resultado = respuestaError,
                        idCooitza = repoResult.idTblPagosImix
                    };
                    repoResult = await repositorio.BitacoraPago(repoResult.idTblPagosImix, 5, result, null, 0);
                    if (repoResult.codigo != 1)
                    {
                        //Asignar nuevos valores a las propiedades
                        result = new { codigo = 101, descripcion = repoResult.descripcion, resultado = (object)null, idCooitza = repoResult.idTblPagosImix };
                    }
                    return Content(HttpStatusCode.OK, result);
                }
                /**si la respuesta http es exitosa se procede a leer el string y serealizarlo para despues usar sus datos*/
                var json_respuesta = await response.Content.ReadAsStringAsync();
                resutldadoWS = JsonConvert.DeserializeObject<ResutldadoWS>(json_respuesta);

                repoResult = await repositorio.BitacoraPago(repoResult.idTblPagosImix,4, null, resutldadoWS,0);//guarda en la bitacora ok
                if (repoResult.codigo != 1)/**valida si se guardaron los registros con exito si el codigo que devuelve el repositorio es diferente de 0 se procede a modifica el objeto de respuesta*/
                {
                    //Asignar nuevos valores a las propiedades
                    result = new { codigo = 501, descripcion = repoResult.descripcion, resultado = (object)null, idCooitza = repoResult.idTblPagosImix };
                    return Content(HttpStatusCode.OK, result);
                }
                result = new
                {
                    codigo = 200,
                    descripcion = "REGISTRO GENERADO CON EXITO",
                    resultado = (object)resutldadoWS.data,
                    idCooitza = repoResult.idTblPagosImix
                };
                repoResult = await repositorio.BitacoraPago(repoResult.idTblPagosImix, 5, resutldadoWS,null , 0);//guarda en la bitacora ok
                if (repoResult.codigo != 1)/**valida si se guardaron los registros con exito si el codigo que devuelve el repositorio es diferente de 0 se procede a modifica el objeto de respuesta*/
                {
                    //Asignar nuevos valores a las propiedades
                    result = new { codigo = 501, descripcion = repoResult.descripcion, resultado = (object)null, idCooitza = repoResult.idTblPagosImix };
                    return Content(HttpStatusCode.OK, result);
                }
                return Content(HttpStatusCode.OK, result);
            }
        }

        public bool validarFecha(string fechaI)
        {
            string fechaPago = fechaI;
            bool formatoValido = DateTime.TryParseExact(fechaPago, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fecha);

            if (formatoValido)
            {
                Console.WriteLine("La fecha es válida y respeta el formato yyyy-mm-dd");
                return true;
            }
            else
            {
                Console.WriteLine("La fecha no respeta el formato yyyy-mm-dd");
                return false;
            }
        }
    }
}
