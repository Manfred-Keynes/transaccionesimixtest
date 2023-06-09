using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.RespuestaRespos
{
    public class GuardarTransaccionResult
    {
        public bool Exitoso { get; set; }
        public long? IdGenerado { get; set; }
        public string descripcion { get; set; }
    }
}