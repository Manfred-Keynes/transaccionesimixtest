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
    
    public partial class TblGirasTecnicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblGirasTecnicos()
        {
            this.TblCertificacionesTecnicos = new HashSet<TblCertificacionesTecnicos>();
        }
    
        public long idTblGirasTecnicos { get; set; }
        public Nullable<long> numeroGira { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaFin { get; set; }
        public Nullable<int> anio { get; set; }
        public Nullable<decimal> montoSolicitado { get; set; }
        public Nullable<decimal> viaticosSolcicitados { get; set; }
        public Nullable<decimal> kilometrajeTotal { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idTblUsuarioAlta { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<long> IdCatTiposKilometrajes { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual TblUsuarios TblUsuarios1 { get; set; }
        public virtual TblUsuarios TblUsuarios2 { get; set; }
        public virtual TblUsuarios TblUsuarios3 { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatTiposKilometraje1 CatTiposKilometraje1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCertificacionesTecnicos> TblCertificacionesTecnicos { get; set; }
    }
}