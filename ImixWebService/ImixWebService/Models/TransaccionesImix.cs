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
    
    public partial class TransaccionesImix
    {
        public long idTblTransaccionesImix { get; set; }
        public string internalCreditCode { get; set; }
        public string creditCode { get; set; }
        public string tipoIdSocio { get; set; }
        public string idDocumentoSocio { get; set; }
        public string nombreSocio { get; set; }
        public string apellidoSocio { get; set; }
        public string codigoPais { get; set; }
        public string celularSocio { get; set; }
        public string emailSocio { get; set; }
        public string direccionSocio { get; set; }
        public string pais { get; set; }
        public string departamento { get; set; }
        public string ciudad { get; set; }
        public string coloniaSocio { get; set; }
        public string venciminetoCredito { get; set; }
        public string plazoCredito { get; set; }
        public string amortizacionCredito { get; set; }
        public Nullable<decimal> valorInicial { get; set; }
        public Nullable<decimal> tasaCorrienteCredito { get; set; }
        public Nullable<decimal> tasaMoraCredito { get; set; }
        public Nullable<decimal> valorMinCredito { get; set; }
        public Nullable<decimal> valorMaxCredito { get; set; }
        public Nullable<decimal> valorSeguro { get; set; }
        public string utilizacionInternalUseCode { get; set; }
        public Nullable<decimal> utilizacionMonto { get; set; }
        public string utilizacionFecha { get; set; }
        public string utilizacionComercio { get; set; }
        public string utilizacionDireccion { get; set; }
        public string utilizacionCiudad { get; set; }
        public string jsonRequest { get; set; }
        public string jsonResponse { get; set; }
        public Nullable<long> idTblUsuarioAlta { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual CatEstados CatEstados { get; set; }
    }
}
