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
    
    public partial class TblPagosImix
    {
        public long idTblPagosImix { get; set; }
        public string idCreditoImix { get; set; }
        public string idCreditoCooitza { get; set; }
        public Nullable<decimal> montoPago { get; set; }
        public Nullable<System.DateTime> fechaPago { get; set; }
        public string jsonRequestCliente { get; set; }
        public string resultadoRequestCliente { get; set; }
        public string responseImix { get; set; }
        public string responsecws { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public Nullable<long> idTblUsuarioAlta { get; set; }
        public Nullable<int> error { get; set; }
        public string resultcreditId { get; set; }
        public string resultCode { get; set; }
        public string resultCreditPaymentId { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual CatEstados CatEstados { get; set; }
    }
}
