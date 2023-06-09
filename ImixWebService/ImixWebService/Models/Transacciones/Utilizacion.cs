using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Transacciones
{
    public class Utilizacion
    {
        public string internalUseCode { get; set; }
        public long? monto { get; set; }
        public string fecha { get; set; }
        public string comercio { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
    }
}