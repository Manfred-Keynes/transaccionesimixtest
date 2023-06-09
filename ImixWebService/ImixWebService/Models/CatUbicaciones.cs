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
    
    public partial class CatUbicaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatUbicaciones()
        {
            this.TblCarteraCredito = new HashSet<TblCarteraCredito>();
            this.CatPuntos = new HashSet<CatPuntos>();
            this.constanciasLaborales = new HashSet<constanciasLaborales>();
            this.TblAfiliaciones = new HashSet<TblAfiliaciones>();
            this.TblAsignacionesEjecutivosSucursales = new HashSet<TblAsignacionesEjecutivosSucursales>();
            this.TblCertificacionesTecnicos = new HashSet<TblCertificacionesTecnicos>();
            this.TblDestinos = new HashSet<TblDestinos>();
            this.TblGruposAgencias = new HashSet<TblGruposAgencias>();
            this.TblMonitorGrabacion = new HashSet<TblMonitorGrabacion>();
            this.TblSucrusalesProductosCooitza = new HashSet<TblSucrusalesProductosCooitza>();
        }
    
        public long idCatUbicaciones { get; set; }
        public Nullable<long> idCatTipoUbicaciones { get; set; }
        public Nullable<long> idCatRegiones { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string descripcion { get; set; }
        public string codigoNombre { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idCatUsuarios { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatUsuarioModifica { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<long> idCatDepartamentosRepublicas { get; set; }
        public Nullable<long> idMunicipiosRepublicas { get; set; }
        public Nullable<long> idCatLugares { get; set; }
        public Nullable<decimal> captacionBase { get; set; }
        public Nullable<int> idSucursal { get; set; }
        public string nombreTarjetaCredito { get; set; }
        public string isoUbicacionGrafica { get; set; }
        public Nullable<long> codigoSucrusalSigue { get; set; }
        public Nullable<long> idTblCaracterisitcasGrabacion { get; set; }
        public Nullable<long> codigoOrden { get; set; }
        public Nullable<decimal> totalAhorros { get; set; }
        public Nullable<decimal> plazoFijo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCarteraCredito> TblCarteraCredito { get; set; }
        public virtual CatDepartamentosRepublicas CatDepartamentosRepublicas { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatLugares CatLugares { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatPuntos> CatPuntos { get; set; }
        public virtual CatRegiones CatRegiones { get; set; }
        public virtual CatTipoUbicaciones CatTipoUbicaciones { get; set; }
        public virtual MunicipiosRepublicas MunicipiosRepublicas { get; set; }
        public virtual TblCaracterisitcasGrabacion TblCaracterisitcasGrabacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<constanciasLaborales> constanciasLaborales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAfiliaciones> TblAfiliaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAsignacionesEjecutivosSucursales> TblAsignacionesEjecutivosSucursales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCertificacionesTecnicos> TblCertificacionesTecnicos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblDestinos> TblDestinos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblGruposAgencias> TblGruposAgencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblMonitorGrabacion> TblMonitorGrabacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSucrusalesProductosCooitza> TblSucrusalesProductosCooitza { get; set; }
    }
}
