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
    
    public partial class TblConvivioImagenes
    {
        public long idTblConvivioImagenes { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idTblUsuario { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
        public Nullable<long> idCatEstados { get; set; }
    
        public virtual CatEstados CatEstados { get; set; }
    }
}
