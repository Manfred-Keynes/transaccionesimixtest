//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImixWebService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblTransaccionesRch
    {
        public long idTblTransaccionesRch { get; set; }
        public Nullable<long> idCatEstadosTransacciones { get; set; }
        public string loginRequestXml { get; set; }
        public string loginResponseXml { get; set; }
        public string loginResponseJson { get; set; }
        public Nullable<long> idCatEstadosLoginRch { get; set; }
        public string benPais { get; set; }
        public string benPrimerApellido { get; set; }
        public string benPrimerNombre { get; set; }
        public string benSegundoApellido { get; set; }
        public string benSegundoNombre { get; set; }
        public string benTelefono { get; set; }
        public string estadoGiro { get; set; }
        public string idInterno { get; set; }
        public string idOperacion { get; set; }
        public string monedaOrigen { get; set; }
        public string monedaPago { get; set; }
        public string observaciones { get; set; }
        public string remCiudad { get; set; }
        public string remDireccion { get; set; }
        public string remEstado { get; set; }
        public string remPais { get; set; }
        public string remPrimerApellido { get; set; }
        public string remPrimerNombre { get; set; }
        public string remSegundoApellido { get; set; }
        public string remSegundoNombre { get; set; }
        public string remesador { get; set; }
        public string tasaCambio { get; set; }
        public string valorEnviado { get; set; }
        public string valorPagar { get; set; }
        public Nullable<System.DateTime> fechaBusqueda { get; set; }
        public string jsonRequest { get; set; }
        public string jsonResultado { get; set; }
        public string jsonResponse { get; set; }
        public string xmlRequest { get; set; }
        public string xmlResponse { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public string usuarioTransaccion { get; set; }
        public Nullable<long> idSucursal { get; set; }
        public Nullable<long> idCatEstadosBusquedasRch { get; set; }
        public string usuarioWebService { get; set; }
        public string reservaRequestXml { get; set; }
        public string reservaResponseXml { get; set; }
        public string reservaResultadoJson { get; set; }
        public string reservaResponseJson { get; set; }
        public string idReserva { get; set; }
        public Nullable<System.DateTime> fechaHoraReserva { get; set; }
        public string usuarioReserva { get; set; }
        public string liberaRequestXml { get; set; }
        public string liberaResponseXml { get; set; }
        public string liberaResultadoJson { get; set; }
        public string liberaResponseJson { get; set; }
        public string idLiberacion { get; set; }
        public string usuarioLibera { get; set; }
        public string pagoRequestJson { get; set; }
        public string pagoRequestXml { get; set; }
        public string pagoResponseXml { get; set; }
        public string pagoResultadoJson { get; set; }
        public string pagoResponseJson { get; set; }
        public string idPago { get; set; }
        public Nullable<System.DateTime> fechaHoraPago { get; set; }
        public string usuarioPago { get; set; }
        public Nullable<System.DateTime> fechaHoraLibera { get; set; }
        public string anulaRequestJson { get; set; }
        public string anulaRequestXml { get; set; }
        public string anulaResponseXml { get; set; }
        public string anulaResultadoJson { get; set; }
        public string anulaResponseJson { get; set; }
        public Nullable<System.DateTime> fechaHoraAnulacion { get; set; }
        public string idAnulacion { get; set; }
        public string usuarioAnula { get; set; }
        public string motivoAnulacion { get; set; }
        public Nullable<int> asociado { get; set; }
        public string numeroCuentaCooitza { get; set; }
    
        public virtual CatEstadosBusquedasRch CatEstadosBusquedasRch { get; set; }
        public virtual CatEstadosTransacciones CatEstadosTransacciones { get; set; }
    }
}
