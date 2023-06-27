using ImixWebService.Models;
using ImixWebService.Models.Pagos;
using ImixWebService.Models.Pagos.Resolve;
using ImixWebService.Models.RespuestaApi;
using ImixWebService.Models.RespuestaRespos;
using ImixWebService.Models.Transacciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImixWebService.Repositorios
{
    internal interface IRepositorio
    {
        Task<RepoResponse> Bitacora(Transaccion transaccion, int tipo, long? idTransaccionesImix, RespuestaApi respuestaApi, long? idUsuario);
        Task<GuardarTransaccionResult> GuardarTransaccion(TransaccionesImix transaccionesImix, int operacion);
        Task<PagosRepositorio> BitacoraPago(long? idTblPagosImix, int update, object result, ResutldadoWS resutldadoWS, long? idTblUsuario);
    }
}
