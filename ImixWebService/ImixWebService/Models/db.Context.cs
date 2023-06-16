﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cooitzacoretEntities : DbContext
    {
        public cooitzacoretEntities()
            : base("name=cooitzacoretEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatOpcionesAsambleas> CatOpcionesAsambleas { get; set; }
        public virtual DbSet<TblAsistenciasAsambaleas> TblAsistenciasAsambaleas { get; set; }
        public virtual DbSet<TblSmsCore> TblSmsCore { get; set; }
        public virtual DbSet<CatBusquedas> CatBusquedas { get; set; }
        public virtual DbSet<CatPermisos> CatPermisos { get; set; }
        public virtual DbSet<CatPersonas> CatPersonas { get; set; }
        public virtual DbSet<Tbl_U_Roles> Tbl_U_Roles { get; set; }
        public virtual DbSet<TblBitacoraBusquedaUsuarios> TblBitacoraBusquedaUsuarios { get; set; }
        public virtual DbSet<TblModulos> TblModulos { get; set; }
        public virtual DbSet<TblPermisosUsuarios> TblPermisosUsuarios { get; set; }
        public virtual DbSet<TblPersonas> TblPersonas { get; set; }
        public virtual DbSet<TblRoles> TblRoles { get; set; }
        public virtual DbSet<TblSesion> TblSesion { get; set; }
        public virtual DbSet<TblSubModulos> TblSubModulos { get; set; }
        public virtual DbSet<TblUsuarios> TblUsuarios { get; set; }
        public virtual DbSet<TblUsuarios_Coordinador> TblUsuarios_Coordinador { get; set; }
        public virtual DbSet<CatEstadosPublicados> CatEstadosPublicados { get; set; }
        public virtual DbSet<CatImagenesIntranet> CatImagenesIntranet { get; set; }
        public virtual DbSet<CatJerarquia> CatJerarquia { get; set; }
        public virtual DbSet<CatOrigen> CatOrigen { get; set; }
        public virtual DbSet<CatTipoArchivo> CatTipoArchivo { get; set; }
        public virtual DbSet<TblBiblioteca> TblBiblioteca { get; set; }
        public virtual DbSet<TblLogBiblioteca> TblLogBiblioteca { get; set; }
        public virtual DbSet<catestadoscallcenter> catestadoscallcenter { get; set; }
        public virtual DbSet<tblbitacorapremora> tblbitacorapremora { get; set; }
        public virtual DbSet<tblpremora> tblpremora { get; set; }
        public virtual DbSet<TblCarteraCredito> TblCarteraCredito { get; set; }
        public virtual DbSet<TblResumen> TblResumen { get; set; }
        public virtual DbSet<TblResumenSaldo> TblResumenSaldo { get; set; }
        public virtual DbSet<CatEstadosTokens> CatEstadosTokens { get; set; }
        public virtual DbSet<CatTiposConsultasChatbot> CatTiposConsultasChatbot { get; set; }
        public virtual DbSet<TblConsultasChatbot> TblConsultasChatbot { get; set; }
        public virtual DbSet<CatOpcionesChn> CatOpcionesChn { get; set; }
        public virtual DbSet<TblDeclaracionConcentimientolg> TblDeclaracionConcentimientolg { get; set; }
        public virtual DbSet<TblDeclaracionSalud> TblDeclaracionSalud { get; set; }
        public virtual DbSet<TblDeclaracionSaludchnlg> TblDeclaracionSaludchnlg { get; set; }
        public virtual DbSet<TblDeclaracionSaludlg> TblDeclaracionSaludlg { get; set; }
        public virtual DbSet<TblCoasiste> TblCoasiste { get; set; }
        public virtual DbSet<CatDestinatariosCorreos> CatDestinatariosCorreos { get; set; }
        public virtual DbSet<CatSistemasCorreos> CatSistemasCorreos { get; set; }
        public virtual DbSet<TblSistemasCorreosDestinatariosCorreos> TblSistemasCorreosDestinatariosCorreos { get; set; }
        public virtual DbSet<CAJAENTERA2022> CAJAENTERA2022 { get; set; }
        public virtual DbSet<CatAnios> CatAnios { get; set; }
        public virtual DbSet<CatMeses> CatMeses { get; set; }
        public virtual DbSet<CatNombres> CatNombres { get; set; }
        public virtual DbSet<CatParentescos> CatParentescos { get; set; }
        public virtual DbSet<CatParentescosGastosM> CatParentescosGastosM { get; set; }
        public virtual DbSet<CatProveedoresPagos> CatProveedoresPagos { get; set; }
        public virtual DbSet<CatTiposDocumentos> CatTiposDocumentos { get; set; }
        public virtual DbSet<CatTiposKilometraje> CatTiposKilometraje { get; set; }
        public virtual DbSet<tblAdminpantalla> tblAdminpantalla { get; set; }
        public virtual DbSet<TblBitacoraService> TblBitacoraService { get; set; }
        public virtual DbSet<TblConvivioImagenes> TblConvivioImagenes { get; set; }
        public virtual DbSet<TblDirectorios> TblDirectorios { get; set; }
        public virtual DbSet<TblDirectoriosAgencias> TblDirectoriosAgencias { get; set; }
        public virtual DbSet<TblHistoriales> TblHistoriales { get; set; }
        public virtual DbSet<TblImagenesConvivio> TblImagenesConvivio { get; set; }
        public virtual DbSet<TblLogCatalogosRch> TblLogCatalogosRch { get; set; }
        public virtual DbSet<TblPermisosUsuarios1> TblPermisosUsuarios1 { get; set; }
        public virtual DbSet<CatClasificacionFacturas> CatClasificacionFacturas { get; set; }
        public virtual DbSet<CatColaboradores> CatColaboradores { get; set; }
        public virtual DbSet<CatDepartamentosRepublicas> CatDepartamentosRepublicas { get; set; }
        public virtual DbSet<CatDepartamentosTrabajo> CatDepartamentosTrabajo { get; set; }
        public virtual DbSet<CatEstadoCivil> CatEstadoCivil { get; set; }
        public virtual DbSet<CatEstados> CatEstados { get; set; }
        public virtual DbSet<CatEstadosTiempo> CatEstadosTiempo { get; set; }
        public virtual DbSet<CatIconos> CatIconos { get; set; }
        public virtual DbSet<CatLugares> CatLugares { get; set; }
        public virtual DbSet<CatOpciones> CatOpciones { get; set; }
        public virtual DbSet<CatPuestos> CatPuestos { get; set; }
        public virtual DbSet<CatPuntos> CatPuntos { get; set; }
        public virtual DbSet<CatRegiones> CatRegiones { get; set; }
        public virtual DbSet<CatSerieFacturas> CatSerieFacturas { get; set; }
        public virtual DbSet<CatSexo> CatSexo { get; set; }
        public virtual DbSet<CatTiposCreditos> CatTiposCreditos { get; set; }
        public virtual DbSet<CatTiposKilometraje1> CatTiposKilometraje1 { get; set; }
        public virtual DbSet<CatTipoUbicaciones> CatTipoUbicaciones { get; set; }
        public virtual DbSet<CatUbicaciones> CatUbicaciones { get; set; }
        public virtual DbSet<MunicipiosRepublicas> MunicipiosRepublicas { get; set; }
        public virtual DbSet<TblCaracterisitcasGrabacion> TblCaracterisitcasGrabacion { get; set; }
        public virtual DbSet<TblConvivio> TblConvivio { get; set; }
        public virtual DbSet<TblHistoriales1> TblHistoriales1 { get; set; }
        public virtual DbSet<TblProveedores> TblProveedores { get; set; }
        public virtual DbSet<TblCarteraCredito1> TblCarteraCredito1 { get; set; }
        public virtual DbSet<TransaccionesImix> TransaccionesImix { get; set; }
        public virtual DbSet<CatTipoInstituciones> CatTipoInstituciones { get; set; }
        public virtual DbSet<CatTipoTransacciones> CatTipoTransacciones { get; set; }
        public virtual DbSet<TblHistoricos> TblHistoricos { get; set; }
        public virtual DbSet<TblPeriodos> TblPeriodos { get; set; }
        public virtual DbSet<CatTipificacionProductos> CatTipificacionProductos { get; set; }
        public virtual DbSet<CatTiposConsultas> CatTiposConsultas { get; set; }
        public virtual DbSet<CatTiposDistribuciones> CatTiposDistribuciones { get; set; }
        public virtual DbSet<CatTiposFiltros> CatTiposFiltros { get; set; }
        public virtual DbSet<CatTiposFiltrosEvaluaciones> CatTiposFiltrosEvaluaciones { get; set; }
        public virtual DbSet<CatTiposMedicion> CatTiposMedicion { get; set; }
        public virtual DbSet<CatTiposOperacion> CatTiposOperacion { get; set; }
        public virtual DbSet<TblAsignaciones> TblAsignaciones { get; set; }
        public virtual DbSet<TblAsignacionesEjecutivosSucursales> TblAsignacionesEjecutivosSucursales { get; set; }
        public virtual DbSet<TblCierresProductos> TblCierresProductos { get; set; }
        public virtual DbSet<TblEmpleadosMetas> TblEmpleadosMetas { get; set; }
        public virtual DbSet<TblGruposAgencias> TblGruposAgencias { get; set; }
        public virtual DbSet<TblProductosCooitza> TblProductosCooitza { get; set; }
        public virtual DbSet<TblRolesMetas> TblRolesMetas { get; set; }
        public virtual DbSet<TblSucrusalesProductosCooitza> TblSucrusalesProductosCooitza { get; set; }
        public virtual DbSet<TblMigracion> TblMigracion { get; set; }
        public virtual DbSet<CatDestinatariosCorreo> CatDestinatariosCorreo { get; set; }
        public virtual DbSet<CatDestinatariosSms> CatDestinatariosSms { get; set; }
        public virtual DbSet<CatEstadosTecnicos> CatEstadosTecnicos { get; set; }
        public virtual DbSet<CatHorarioServicios> CatHorarioServicios { get; set; }
        public virtual DbSet<CatServiciosMonitor> CatServiciosMonitor { get; set; }
        public virtual DbSet<TblCertificacionesTecnicos> TblCertificacionesTecnicos { get; set; }
        public virtual DbSet<TblGirasTecnicos> TblGirasTecnicos { get; set; }
        public virtual DbSet<TblHorarios> TblHorarios { get; set; }
        public virtual DbSet<TblMonitorGrabacion> TblMonitorGrabacion { get; set; }
        public virtual DbSet<CatEstadosBusquedasRch> CatEstadosBusquedasRch { get; set; }
        public virtual DbSet<CatEstadosLiberacionesRch> CatEstadosLiberacionesRch { get; set; }
        public virtual DbSet<CatEstadosLoginRch> CatEstadosLoginRch { get; set; }
        public virtual DbSet<CatEstadosReservasRch> CatEstadosReservasRch { get; set; }
        public virtual DbSet<CatEstadosTransacciones> CatEstadosTransacciones { get; set; }
        public virtual DbSet<CatRelationshipRemitentes> CatRelationshipRemitentes { get; set; }
        public virtual DbSet<CatTiposRemesas> CatTiposRemesas { get; set; }
        public virtual DbSet<TblConfiguracionesRch> TblConfiguracionesRch { get; set; }
        public virtual DbSet<TblLogCatalogosRch1> TblLogCatalogosRch1 { get; set; }
        public virtual DbSet<TblLoginRch> TblLoginRch { get; set; }
        public virtual DbSet<TblTransaccionesRch> TblTransaccionesRch { get; set; }
        public virtual DbSet<CatEstadosRrhh> CatEstadosRrhh { get; set; }
        public virtual DbSet<constanciasLaborales> constanciasLaborales { get; set; }
        public virtual DbSet<CatTblUsuariosXTblSistemas> CatTblUsuariosXTblSistemas { get; set; }
        public virtual DbSet<TblSistemas> TblSistemas { get; set; }
        public virtual DbSet<TblUsuarios1> TblUsuarios1 { get; set; }
        public virtual DbSet<CatEstatusTransac> CatEstatusTransac { get; set; }
        public virtual DbSet<TblPropiedades> TblPropiedades { get; set; }
        public virtual DbSet<TblSiguePagar> TblSiguePagar { get; set; }
        public virtual DbSet<TblSigueTransac> TblSigueTransac { get; set; }
        public virtual DbSet<CatBancos> CatBancos { get; set; }
        public virtual DbSet<CatCuentasProveedores> CatCuentasProveedores { get; set; }
        public virtual DbSet<CatDescripcionesProveedores> CatDescripcionesProveedores { get; set; }
        public virtual DbSet<CatProveedoresPagos1> CatProveedoresPagos1 { get; set; }
        public virtual DbSet<CatTiposCreditosProveedores> CatTiposCreditosProveedores { get; set; }
        public virtual DbSet<CatTiposCuentas> CatTiposCuentas { get; set; }
        public virtual DbSet<CatEstadoSolicitudes> CatEstadoSolicitudes { get; set; }
        public virtual DbSet<CatProveedoresCooitzas> CatProveedoresCooitzas { get; set; }
        public virtual DbSet<CatProveedoresExternos> CatProveedoresExternos { get; set; }
        public virtual DbSet<CatTiposEmpresasProveedores> CatTiposEmpresasProveedores { get; set; }
        public virtual DbSet<CatTiposMonedas> CatTiposMonedas { get; set; }
        public virtual DbSet<CatTiposMovimientos> CatTiposMovimientos { get; set; }
        public virtual DbSet<CatTiposProveedores> CatTiposProveedores { get; set; }
        public virtual DbSet<TblSolicitudesCooitzas> TblSolicitudesCooitzas { get; set; }
        public virtual DbSet<TblSolicitudesMoviemientos> TblSolicitudesMoviemientos { get; set; }
        public virtual DbSet<TblSolicitudesMovimientosDetalle> TblSolicitudesMovimientosDetalle { get; set; }
        public virtual DbSet<CatPromociones> CatPromociones { get; set; }
        public virtual DbSet<TblEntregas> TblEntregas { get; set; }
        public virtual DbSet<TblAgencias> TblAgencias { get; set; }
        public virtual DbSet<TblTransUnion> TblTransUnion { get; set; }
        public virtual DbSet<TblTransUnionTest> TblTransUnionTest { get; set; }
        public virtual DbSet<TblUniversales> TblUniversales { get; set; }
        public virtual DbSet<TblUniversalesTest> TblUniversalesTest { get; set; }
        public virtual DbSet<CatEstadosViaticos> CatEstadosViaticos { get; set; }
        public virtual DbSet<CatOpcionesVehiculos> CatOpcionesVehiculos { get; set; }
        public virtual DbSet<CatRubros> CatRubros { get; set; }
        public virtual DbSet<CatTipoAnticipo> CatTipoAnticipo { get; set; }
        public virtual DbSet<CatTipoPlacas> CatTipoPlacas { get; set; }
        public virtual DbSet<CatTipoSolicitudes> CatTipoSolicitudes { get; set; }
        public virtual DbSet<Tbl_Cc_Rubros> Tbl_Cc_Rubros { get; set; }
        public virtual DbSet<TblDepositos> TblDepositos { get; set; }
        public virtual DbSet<TblDestinos> TblDestinos { get; set; }
        public virtual DbSet<TblEstado_Solicitudes> TblEstado_Solicitudes { get; set; }
        public virtual DbSet<TblFacturas> TblFacturas { get; set; }
        public virtual DbSet<TblFacturasXcatRubros> TblFacturasXcatRubros { get; set; }
        public virtual DbSet<TblSolicitudes> TblSolicitudes { get; set; }
        public virtual DbSet<TblSolicitudesXtblVehiculos> TblSolicitudesXtblVehiculos { get; set; }
        public virtual DbSet<TblVehiculos> TblVehiculos { get; set; }
        public virtual DbSet<CatZuma> CatZuma { get; set; }
        public virtual DbSet<TblAfiliaciones> TblAfiliaciones { get; set; }
        public virtual DbSet<Caja2022> Caja2022 { get; set; }
    }
}
