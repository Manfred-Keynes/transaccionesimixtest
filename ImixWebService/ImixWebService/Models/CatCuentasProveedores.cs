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
    
    public partial class CatCuentasProveedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatCuentasProveedores()
        {
            this.CatProveedoresPagos1 = new HashSet<CatProveedoresPagos1>();
        }
    
        public long idCatCuentasProveedores { get; set; }
        public Nullable<long> numeroCuenta { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public Nullable<long> idTblUsuarioAlta { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatTiposCuentas { get; set; }
        public Nullable<long> idCatBancos { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
    
        public virtual CatBancos CatBancos { get; set; }
        public virtual CatTiposCuentas CatTiposCuentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatProveedoresPagos1> CatProveedoresPagos1 { get; set; }
    }
}
