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
    
    public partial class TblAgencias
    {
        public long idTblAgencias { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string nombreCompleto { get; set; }
        public string direccion { get; set; }
        public string altitud { get; set; }
        public string longitud { get; set; }
        public string altura { get; set; }
        public Nullable<long> idTblProveedores { get; set; }
        public string tipoServicio { get; set; }
        public string tipoConexion { get; set; }
        public string nombreSSID { get; set; }
        public string contraseniaSSID { get; set; }
        public string extension { get; set; }
        public Nullable<decimal> montoInstalacion { get; set; }
        public Nullable<decimal> montoViaticos { get; set; }
        public string marcaDVR { get; set; }
        public string tiempoGrabacion { get; set; }
        public string tipoDisco { get; set; }
        public string almacenamientoDisco { get; set; }
        public string marcaDisco { get; set; }
        public string cantidadDisco { get; set; }
        public string ipDVR { get; set; }
        public string usuarioDVR { get; set; }
        public string contraseniaDVR { get; set; }
        public string capacidadDVR { get; set; }
        public string tipoRedundancia { get; set; }
        public string proveedorRedundancia { get; set; }
        public Nullable<long> idCatOpciones { get; set; }
        public string contratoRedundancia { get; set; }
        public Nullable<System.DateTime> fechaOperaciones { get; set; }
        public Nullable<System.DateTime> fechaApertura { get; set; }
        public string gerenteAgencia { get; set; }
        public string contratoInternet { get; set; }
        public string contratoAdminstrativo { get; set; }
        public string contratoResolucion { get; set; }
        public string informeInformatico { get; set; }
        public string informeInstalacion { get; set; }
        public string actaRecepcion { get; set; }
        public string actaEntregaEquipo { get; set; }
        public string actaUsuarios { get; set; }
        public string actaCapacitacion { get; set; }
        public string informeCamaras { get; set; }
        public string informeBiometricos { get; set; }
        public string plano { get; set; }
        public string otros { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idTblUsuarios { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatUsuarioModifica { get; set; }
        public Nullable<long> idCatEstados { get; set; }
    
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatOpciones CatOpciones { get; set; }
        public virtual TblProveedores TblProveedores { get; set; }
    }
}
