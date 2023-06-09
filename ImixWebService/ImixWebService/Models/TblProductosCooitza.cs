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
    
    public partial class TblProductosCooitza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblProductosCooitza()
        {
            this.TblAsignaciones = new HashSet<TblAsignaciones>();
            this.TblCierresProductos = new HashSet<TblCierresProductos>();
            this.TblEmpleadosMetas = new HashSet<TblEmpleadosMetas>();
            this.TblSucrusalesProductosCooitza = new HashSet<TblSucrusalesProductosCooitza>();
        }
    
        public long idTblProductosCooitza { get; set; }
        public string descripcion { get; set; }
        public Nullable<long> idCatTipificacionProductos { get; set; }
        public Nullable<long> idCore { get; set; }
        public Nullable<decimal> saldoCierre { get; set; }
        public Nullable<long> cantidadCierre { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idTblUsuariosAlta { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
        public Nullable<long> idCatTiposMedicion { get; set; }
        public string expresionRegular { get; set; }
        public Nullable<long> idCatTiposOperacion { get; set; }
        public Nullable<long> idCatTiposConsultas { get; set; }
        public Nullable<long> idCatTiposFiltrosEvaluaciones { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual TblUsuarios TblUsuarios1 { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatTipificacionProductos CatTipificacionProductos { get; set; }
        public virtual CatTiposConsultas CatTiposConsultas { get; set; }
        public virtual CatTiposFiltrosEvaluaciones CatTiposFiltrosEvaluaciones { get; set; }
        public virtual CatTiposMedicion CatTiposMedicion { get; set; }
        public virtual CatTiposOperacion CatTiposOperacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAsignaciones> TblAsignaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCierresProductos> TblCierresProductos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblEmpleadosMetas> TblEmpleadosMetas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSucrusalesProductosCooitza> TblSucrusalesProductosCooitza { get; set; }
    }
}
