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
    
    public partial class TblSolicitudesXtblVehiculos
    {
        public long idTblSolicitudesXtblVehiculoes { get; set; }
        public Nullable<long> idTblVehiculos { get; set; }
        public Nullable<long> idTblSolicitudes { get; set; }
        public string observaciones { get; set; }
        public Nullable<long> idCatUsuarios { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idCatUsuarioModifica { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<decimal> kilometrajeInicial { get; set; }
        public string imagenKilometrajeInicial { get; set; }
        public Nullable<decimal> kilomentrajeFinal { get; set; }
        public string imagenKilometrajeFinal { get; set; }
    
        public virtual TblVehiculos TblVehiculos { get; set; }
    }
}
