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
    
    public partial class CatEstadosTiempo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatEstadosTiempo()
        {
            this.TblCaracterisitcasGrabacion = new HashSet<TblCaracterisitcasGrabacion>();
            this.TblMonitorGrabacion = new HashSet<TblMonitorGrabacion>();
        }
    
        public long idCatEstadosTiempo { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idTblUsuarios { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCaracterisitcasGrabacion> TblCaracterisitcasGrabacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblMonitorGrabacion> TblMonitorGrabacion { get; set; }
    }
}