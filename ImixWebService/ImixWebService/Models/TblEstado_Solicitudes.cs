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
    
    public partial class TblEstado_Solicitudes
    {
        public long idTblEstado_Solicitudes { get; set; }
        public Nullable<long> idCatEstadosViaticos { get; set; }
        public Nullable<long> idTblSolicitudes { get; set; }
        public Nullable<long> idTblUsuarios { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<long> idCatUsuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaActualizacion { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public string observaciones { get; set; }
    
        public virtual TblUsuarios TblUsuarios { get; set; }
        public virtual TblUsuarios TblUsuarios1 { get; set; }
        public virtual CatEstados CatEstados { get; set; }
        public virtual CatEstadosViaticos CatEstadosViaticos { get; set; }
    }
}