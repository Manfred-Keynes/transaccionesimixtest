using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Pagos
{
    public class PagosRepositorio
    {
        public long? codigo { get; set; }
        public string descripcion { get; set; }
        public long? idTblPagosImix { get; set; }
    }
}