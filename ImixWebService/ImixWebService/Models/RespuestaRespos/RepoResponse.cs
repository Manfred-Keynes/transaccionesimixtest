using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.RespuestaRespos
{
    public class RepoResponse
    {
        public long? codigo { get; set; }
        public string descripcion { get; set; }
        public long? idCooitza { get; set; }
        public object Listado { get; set; }
    }
}