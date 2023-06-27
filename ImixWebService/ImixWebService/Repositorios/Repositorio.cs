using ImixWebService.Models;
using ImixWebService.Models.Pagos;
using ImixWebService.Models.Pagos.Resolve;
using ImixWebService.Models.RespuestaApi;
using ImixWebService.Models.RespuestaRespos;
using ImixWebService.Models.Transacciones;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ImixWebService.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private cooitzacoretEntities db = new cooitzacoretEntities();
        public async Task<RepoResponse> Bitacora(Transaccion transaccion, int tipo, long? idTransaccionesImix, RespuestaApi respuestaApi, long? idUsuario)
        {
            RepoResponse respuesta = new RepoResponse();


            GuardarTransaccionResult guardadoExitoso;

            if (tipo == 1)
            {
                TransaccionesImix transaccionesImix = new TransaccionesImix
                {
                    idCatEstados = 1,
                    fechaCreacion = DateTime.Now,
                    idTblUsuarioAlta = 1
                };
                if (transaccion != null)
                {
                    transaccionesImix.jsonRequest = JsonConvert.SerializeObject(transaccion);
                }
                guardadoExitoso = await GuardarTransaccion(transaccionesImix, 1);
                respuesta.codigo = guardadoExitoso.Exitoso ? 1 : 0;
                respuesta.descripcion = guardadoExitoso.descripcion;
                respuesta.idCooitza = guardadoExitoso.IdGenerado;
            }
            else if (tipo == 2)
            {
                TransaccionesImix transaccionesImix = db.TransaccionesImix.FirstOrDefault(x => x.idTblTransaccionesImix == idTransaccionesImix);
                transaccionesImix.internalCreditCode = transaccion.internalCreditCode;
                transaccionesImix.creditCode = transaccion.creditCode;
                transaccionesImix.tipoIdSocio = transaccion.tipoIdSocio;
                transaccionesImix.idDocumentoSocio = transaccion.idDocumentoSocio;
                transaccionesImix.nombreSocio = transaccion.nombreSocio;
                transaccionesImix.apellidoSocio = transaccion.apellidoSocio;
                transaccionesImix.codigoPais = transaccion.codigoPais;
                transaccionesImix.celularSocio = transaccion.celularSocio;
                transaccionesImix.emailSocio = transaccion.emailSocio;
                transaccionesImix.direccionSocio = transaccion.direccionSocio;
                transaccionesImix.pais = transaccion.pais;
                transaccionesImix.departamento = transaccion.departamento;
                transaccionesImix.ciudad = transaccion.ciudad;
                transaccionesImix.coloniaSocio = transaccion.coloniaSocio;
                transaccionesImix.venciminetoCredito = transaccion.vencimientoCredito;
                transaccionesImix.plazoCredito = transaccion.plazoCredito;
                transaccionesImix.amortizacionCredito = transaccion.amortizacionCredito;
                transaccionesImix.valorInicial = transaccion.valorInicial;
                transaccionesImix.tasaCorrienteCredito = transaccion.tasaCorrienteCredito;
                transaccionesImix.tasaMoraCredito = transaccion.tasaMoraCredito;
                transaccionesImix.valorMinCredito = transaccion.valorMinCredito;
                transaccionesImix.valorMaxCredito = transaccion.valorMaxCredito;
                transaccionesImix.valorSeguro = transaccion.valorSeguro;
                transaccionesImix.utilizacionInternalUseCode = transaccion.utilizacion.internalUseCode;
                transaccionesImix.utilizacionMonto = transaccion.utilizacion.monto;
                transaccionesImix.utilizacionFecha = transaccion.utilizacion.fecha;
                transaccionesImix.utilizacionComercio = transaccion.utilizacion.comercio;
                transaccionesImix.utilizacionDireccion = transaccion.utilizacion.direccion;
                transaccionesImix.utilizacionCiudad = transaccion.utilizacion.ciudad;
                transaccionesImix.idCatEstados = 1;
                transaccionesImix.fechaCreacion = DateTime.Now;

                guardadoExitoso = await GuardarTransaccion(transaccionesImix, 2);
                respuesta.codigo = guardadoExitoso.Exitoso ? 1 : 0;
                respuesta.descripcion = guardadoExitoso.descripcion;
                respuesta.idCooitza = guardadoExitoso.IdGenerado;
            }
            else if (tipo == 3)
            {
                TransaccionesImix transaccionesImix = db.TransaccionesImix.FirstOrDefault(x => x.idTblTransaccionesImix == idTransaccionesImix);
                transaccionesImix.jsonResponse = JsonConvert.SerializeObject(respuestaApi);
                guardadoExitoso = await GuardarTransaccion(transaccionesImix, 2);
                respuesta.codigo = guardadoExitoso.Exitoso ? 1 : 0;
                respuesta.descripcion = guardadoExitoso.descripcion;
                respuesta.idCooitza = guardadoExitoso.IdGenerado;
            }
            else
            {
                return respuesta;
            }

            return respuesta;
        }


        public async Task<GuardarTransaccionResult> GuardarTransaccion(TransaccionesImix transaccionesImix, int operacion)
        {
            GuardarTransaccionResult resultado = new GuardarTransaccionResult();

            if (operacion == 1)
            {
                try
                {
                    db.TransaccionesImix.Add(transaccionesImix);
                    await db.SaveChangesAsync();
                    resultado.Exitoso = true;
                    resultado.IdGenerado = transaccionesImix.idTblTransaccionesImix;
                    resultado.descripcion = "SUCCESS";
                }
                catch (Exception ex)
                {
                    resultado.Exitoso = false;
                    resultado.IdGenerado = 0;
                    resultado.descripcion = "Error al guardar el registro: " + ex.Message;
                }

            }
            if (operacion == 2)
            {
                try
                {

                    await db.SaveChangesAsync();
                    resultado.Exitoso = true;
                    resultado.IdGenerado = transaccionesImix.idTblTransaccionesImix;
                    resultado.descripcion = "SUCCESS";
                }
                catch (Exception ex)
                {
                    resultado.Exitoso = false;
                    resultado.IdGenerado = 0;
                    resultado.descripcion = "Error al guardar cambios en el  registro: " + ex.Message;
                }

            }
            return resultado;

        }


        public async Task<PagosRepositorio> BitacoraPago(long? idTblPagosImix, int update, object result, ResutldadoWS resultWS, long? idTblUsuario)
        {
            PagosRepositorio pagosRepositorio = new PagosRepositorio();
            switch (update)
            {
                case 1:
                    try
                    {
                        using (var db = new cooitzacoretEntities())
                        {
                            var tblPagosImix = new TblPagosImix();
                            tblPagosImix.jsonRequestCliente = JsonConvert.SerializeObject(result);
                            tblPagosImix.fechaAlta = DateTime.Now;
                            tblPagosImix.idCatEstados = 1;
                            tblPagosImix.idTblUsuarioAlta = idTblUsuario;
                            db.TblPagosImix.Add(tblPagosImix);
                            db.SaveChanges();

                            pagosRepositorio.codigo = 1;
                            pagosRepositorio.descripcion = "SUCCESS";
                            pagosRepositorio.idTblPagosImix = tblPagosImix.idTblPagosImix;
                        }
                    }
                    catch (Exception ex)
                    {

                        pagosRepositorio.codigo = 2;
                        pagosRepositorio.descripcion = "ERROR " + ex.Message.ToUpper();

                    }
                    return pagosRepositorio;
                case 2:
                    try
                    {
                        using (var db = new cooitzacoretEntities())
                        {
                            var tblPagosImix = await db.TblPagosImix.FindAsync(idTblPagosImix);
                            if (tblPagosImix == null)
                            {
                                pagosRepositorio.codigo = 1;
                                pagosRepositorio.descripcion = "NO EXISTE REFERENCIA DEL ID PROPORCIONADO";
                                return pagosRepositorio;
                            }
                            
                            tblPagosImix.idCreditoImix = ((dynamic)result).data.creditId;
                            tblPagosImix.idCreditoCooitza = ((dynamic)result).data.code;
                            tblPagosImix.montoPago = ((dynamic)result)?.data?.paymentValue ?? 0m;


                            string fechaPago = ((dynamic)result).data.paymentDate;
                            var fechaPego = DateTime.TryParseExact(fechaPago, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate) ? parsedDate : (DateTime?)null;
                            tblPagosImix.fechaPago = fechaPego;
                            tblPagosImix.resultadoRequestCliente = JsonConvert.SerializeObject(result);
                            db.Entry(tblPagosImix).State = EntityState.Modified;
                            await db.SaveChangesAsync();

                            pagosRepositorio.codigo = 1;
                            pagosRepositorio.descripcion = "SUCCESS";
                            pagosRepositorio.idTblPagosImix = tblPagosImix.idTblPagosImix;
                        }
                    }
                    catch (Exception ex)
                    {

                        pagosRepositorio.codigo = 2;
                        pagosRepositorio.descripcion = "ERROR " + ex.Message.ToUpper();
                    }
                    return pagosRepositorio;
                case 3:
                    try
                    {
                        using (var db = new cooitzacoretEntities())
                        {
                            var tblPagosImix = await db.TblPagosImix.FindAsync(idTblPagosImix);
                            if (tblPagosImix == null)
                            {
                                pagosRepositorio.codigo = 1;
                                pagosRepositorio.descripcion = "NO EXISTE REFERENCIA DEL ID PROPORCIONADO";
                                return pagosRepositorio;
                            }

                            
                            tblPagosImix.responseImix = JsonConvert.SerializeObject(result);
                            db.Entry(tblPagosImix).State = EntityState.Modified;
                            await db.SaveChangesAsync();

                            pagosRepositorio.codigo = 1;
                            pagosRepositorio.descripcion = "SUCCESS";
                            pagosRepositorio.idTblPagosImix = tblPagosImix.idTblPagosImix;
                        }
                    }
                    catch (Exception ex)
                    {

                        pagosRepositorio.codigo = 2;
                        pagosRepositorio.descripcion = "ERROR " + ex.Message.ToUpper();
                    }
                    return pagosRepositorio;
                case 4:
                    try
                    {
                        using (var db = new cooitzacoretEntities())
                        {
                            var tblPagosImix = await db.TblPagosImix.FindAsync(idTblPagosImix);
                            if (tblPagosImix == null)
                            {
                                pagosRepositorio.codigo = 1;
                                pagosRepositorio.descripcion = "NO EXISTE REFERENCIA DEL ID PROPORCIONADO";
                                return pagosRepositorio;
                            }

                            tblPagosImix.error = 2;
                            tblPagosImix.resultcreditId = resultWS.data.creditId;
                            tblPagosImix.resultCode = resultWS.data.code;
                            tblPagosImix.resultCreditPaymentId = resultWS.data.creditPaymentId;
                            tblPagosImix.responseImix = JsonConvert.SerializeObject(resultWS);
                            db.Entry(tblPagosImix).State = EntityState.Modified;
                            await db.SaveChangesAsync();

                            pagosRepositorio.codigo = 1;
                            pagosRepositorio.descripcion = "SUCCESS";
                            pagosRepositorio.idTblPagosImix = tblPagosImix.idTblPagosImix;
                        }
                    }
                    catch (Exception ex)
                    {

                        pagosRepositorio.codigo = 2;
                        pagosRepositorio.descripcion = "ERROR " + ex.Message.ToUpper();
                    }
                    return pagosRepositorio;
                case 5:
                    try
                    {
                        using (var db = new cooitzacoretEntities())
                        {
                            var tblPagosImix = await db.TblPagosImix.FindAsync(idTblPagosImix);
                            if (tblPagosImix == null)
                            {
                                pagosRepositorio.codigo = 1;
                                pagosRepositorio.descripcion = "NO EXISTE REFERENCIA DEL ID PROPORCIONADO";
                                return pagosRepositorio;
                            }


                            tblPagosImix.responsecws = JsonConvert.SerializeObject(result);
                            db.Entry(tblPagosImix).State = EntityState.Modified;
                            await db.SaveChangesAsync();

                            pagosRepositorio.codigo = 1;
                            pagosRepositorio.descripcion = "SUCCESS";
                            pagosRepositorio.idTblPagosImix = tblPagosImix.idTblPagosImix;
                        }
                    }
                    catch (Exception ex)
                    {
                        pagosRepositorio.codigo = 2;
                        pagosRepositorio.descripcion = "ERROR " + ex.Message.ToUpper();
                    }
                    return pagosRepositorio;
                default:
                    return pagosRepositorio;
                    
            }
        }
    }
}