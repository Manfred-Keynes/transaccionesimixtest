using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Transacciones
{
    public class Utilizacion
    {
        [Required]
        public string internalUseCode { get; set; }
        [Required]
        public long? monto { get; set; }
        [Required]
        public string fecha { get; set; }
        [Required]
        public string comercio { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string ciudad { get; set; }
    }
}