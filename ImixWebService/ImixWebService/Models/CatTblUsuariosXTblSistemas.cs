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
    
    public partial class CatTblUsuariosXTblSistemas
    {
        public long idCatTblUsuariosXTblSistemas { get; set; }
        public Nullable<long> idTblSistemas { get; set; }
        public Nullable<long> idTblUsuarios { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idCatUsuarios { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatUsuarioModifica { get; set; }
    
        public virtual CatEstados CatEstados { get; set; }
        public virtual TblSistemas TblSistemas { get; set; }
        public virtual TblUsuarios1 TblUsuarios1 { get; set; }
    }
}
