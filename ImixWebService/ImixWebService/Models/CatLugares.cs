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
    
    public partial class CatLugares
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatLugares()
        {
            this.CatUbicaciones = new HashSet<CatUbicaciones>();
        }
    
        public long idCatLugares { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public Nullable<long> idMunicipiosRepublicas { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idCatUsuarios { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatUsuarioModifica { get; set; }
        public Nullable<long> idCatEstados { get; set; }
    
        public virtual CatEstados CatEstados { get; set; }
        public virtual MunicipiosRepublicas MunicipiosRepublicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatUbicaciones> CatUbicaciones { get; set; }
    }
}
