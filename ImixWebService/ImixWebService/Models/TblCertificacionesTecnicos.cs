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
    
    public partial class TblCertificacionesTecnicos
    {
        public long idTblCertificacionesTecnicos { get; set; }
        public Nullable<long> idTblUsuariosAlta { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idTblUsuariosModificacion { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatUbicaciones { get; set; }
        public Nullable<long> idTblGirasTecnicos { get; set; }
        public string comentarios { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<long> idCatEstadosTecnicos { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual TblUsuarios TblUsuarios1 { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatUbicaciones CatUbicaciones { get; set; }
        public virtual CatEstadosTecnicos CatEstadosTecnicos { get; set; }
        public virtual TblGirasTecnicos TblGirasTecnicos { get; set; }
    }
}
