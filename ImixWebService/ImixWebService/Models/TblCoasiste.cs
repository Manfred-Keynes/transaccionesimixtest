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
    
    public partial class TblCoasiste
    {
        public long idTblCoasiste { get; set; }
        public Nullable<System.DateTime> FechaConsulta { get; set; }
        public string UsuarioTransac { get; set; }
        public string CodigoRespuesta { get; set; }
        public string jsonResponse { get; set; }
        public string jsonRequest { get; set; }
        public string jsonEnviadoForce { get; set; }
        public string jsonReponseForce { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public string usuarioServicio { get; set; }
        public string contratoCooitza { get; set; }
        public string contratoForceSos { get; set; }
        public string clienteForceSos { get; set; }
        public string tipoCredito { get; set; }
        public string tipoProductoCooasiste { get; set; }
        public Nullable<System.DateTime> fechaInicioCredito { get; set; }
        public Nullable<System.DateTime> fechaFinCredito { get; set; }
        public string claveProducto { get; set; }
        public string numeroCreditoCooitza { get; set; }
    }
}