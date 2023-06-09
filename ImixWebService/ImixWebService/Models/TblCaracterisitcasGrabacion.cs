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
    
    public partial class TblCaracterisitcasGrabacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblCaracterisitcasGrabacion()
        {
            this.CatUbicaciones = new HashSet<CatUbicaciones>();
        }
    
        public long idTblCaracterisitcasGrabacion { get; set; }
        public string ipDvr { get; set; }
        public string marcaDvr { get; set; }
        public Nullable<long> canalesDvr { get; set; }
        public Nullable<long> cantidadCamarasInstaladas { get; set; }
        public Nullable<long> cantidadDiscosDuros { get; set; }
        public string capacidadDvr { get; set; }
        public string tiempoAlmacenamiento { get; set; }
        public string usuarioDvr { get; set; }
        public string claveDvr { get; set; }
        public string diferenciaDeTiempo { get; set; }
        public Nullable<long> idTblUsuarios { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatEstadosTiempo { get; set; }
        public string observaciones { get; set; }
    
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatEstadosTiempo CatEstadosTiempo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatUbicaciones> CatUbicaciones { get; set; }
    }
}
