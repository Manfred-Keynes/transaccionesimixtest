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
    
    public partial class CatProveedoresExternos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatProveedoresExternos()
        {
            this.TblSolicitudesMoviemientos = new HashSet<TblSolicitudesMoviemientos>();
            this.TblSolicitudesMoviemientos1 = new HashSet<TblSolicitudesMoviemientos>();
        }
    
        public long idCatProveedoresExternos { get; set; }
        public string solicitud { get; set; }
        public string dpiRepresentante { get; set; }
        public string representacionLegal { get; set; }
        public string descripcionServicios { get; set; }
        public string solvenciaFiscal { get; set; }
        public string rtu { get; set; }
        public string patenteComercio { get; set; }
        public string patenteSociedad { get; set; }
        public string condicionesGarantias { get; set; }
        public string referencias { get; set; }
        public string numeroCuentaCooitza { get; set; }
        public Nullable<long> idCatBancos { get; set; }
        public Nullable<long> idCatTiposCuentas { get; set; }
        public string numeroCuenta { get; set; }
        public string nombreEmpresa { get; set; }
        public Nullable<long> idCatTiposEmpresasProveedores { get; set; }
        public string contrato { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string contactoInmediato { get; set; }
        public string numeroSoporte { get; set; }
        public Nullable<long> idTblUsuariosAltas { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<long> idCatTiposProveedores { get; set; }
        public string nombre { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual TblUsuarios TblUsuarios1 { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatBancos CatBancos { get; set; }
        public virtual CatTiposCuentas CatTiposCuentas { get; set; }
        public virtual CatTiposEmpresasProveedores CatTiposEmpresasProveedores { get; set; }
        public virtual CatTiposProveedores CatTiposProveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSolicitudesMoviemientos> TblSolicitudesMoviemientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSolicitudesMoviemientos> TblSolicitudesMoviemientos1 { get; set; }
    }
}
