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
    
    public partial class TblPermisosUsuarios1
    {
        public long idTblPermisosUsuarios { get; set; }
        public string nombreRolCore { get; set; }
        public string codigoRolCore { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<long> idTblUsuariosAlta { get; set; }
        public Nullable<long> idTblUsuariosModifica { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idTblModulos { get; set; }
        public Nullable<long> idTblSubModulos { get; set; }
        public string usuarioCore { get; set; }
    }
}