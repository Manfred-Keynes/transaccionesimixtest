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
    
    public partial class TblCierresProductos
    {
        public long idTblCierresProductos { get; set; }
        public Nullable<decimal> saldo { get; set; }
        public Nullable<long> cantidad { get; set; }
        public Nullable<long> idCatMeses { get; set; }
        public Nullable<long> idCatAnios { get; set; }
        public Nullable<long> idTblProductosCooitza { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idUsuarioAlta { get; set; }
        public Nullable<long> idUsuarioModifica { get; set; }
        public Nullable<long> idCatEstados { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual TblUsuarios TblUsuarios1 { get; set; }
        public virtual CatAnios CatAnios { get; set; }
        public virtual CatMeses CatMeses { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        public virtual TblProductosCooitza TblProductosCooitza { get; set; }
    }
}