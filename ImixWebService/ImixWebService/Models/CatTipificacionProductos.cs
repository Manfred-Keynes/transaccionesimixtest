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
    
    public partial class CatTipificacionProductos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatTipificacionProductos()
        {
            this.TblProductosCooitza = new HashSet<TblProductosCooitza>();
        }
    
        public long idCatTipificacionProductos { get; set; }
        public string descripcion { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<System.DateTime> fechaCeacion { get; set; }
        public Nullable<long> idTblUsuaioAlta { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual TblUsuarios TblUsuarios1 { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblProductosCooitza> TblProductosCooitza { get; set; }
    }
}
