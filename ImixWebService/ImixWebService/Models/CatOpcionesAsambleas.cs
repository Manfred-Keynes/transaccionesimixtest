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
    
    public partial class CatOpcionesAsambleas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatOpcionesAsambleas()
        {
            this.TblAsistenciasAsambaleas = new HashSet<TblAsistenciasAsambaleas>();
            this.TblAsistenciasAsambaleas1 = new HashSet<TblAsistenciasAsambaleas>();
            this.TblAsistenciasAsambaleas2 = new HashSet<TblAsistenciasAsambaleas>();
            this.TblAsistenciasAsambaleas3 = new HashSet<TblAsistenciasAsambaleas>();
            this.TblAsistenciasAsambaleas4 = new HashSet<TblAsistenciasAsambaleas>();
        }
    
        public long idCatOpcionesAsambleas { get; set; }
        public string descripcion { get; set; }
        public Nullable<long> idCatEstados { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAsistenciasAsambaleas> TblAsistenciasAsambaleas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAsistenciasAsambaleas> TblAsistenciasAsambaleas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAsistenciasAsambaleas> TblAsistenciasAsambaleas2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAsistenciasAsambaleas> TblAsistenciasAsambaleas3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAsistenciasAsambaleas> TblAsistenciasAsambaleas4 { get; set; }
    }
}
