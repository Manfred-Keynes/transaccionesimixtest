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
    
    public partial class TblBiblioteca
    {
        public long idTblBiblioteca { get; set; }
        public string titulo { get; set; }
        public Nullable<System.DateTime> fechaDocumento { get; set; }
        public Nullable<long> idTblUsuarios { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public string nombreArchivo { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<long> idCatOrigen { get; set; }
        public Nullable<long> idCatJerarquia { get; set; }
        public Nullable<long> idCatTipoArchivo { get; set; }
        public string urlVideo { get; set; }
        public string detalle { get; set; }
        public Nullable<long> idCatOpciones { get; set; }
        public Nullable<long> ordenHome { get; set; }
    
        public virtual CatJerarquia CatJerarquia { get; set; }
        public virtual CatOrigen CatOrigen { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatOpciones CatOpciones { get; set; }
    }
}