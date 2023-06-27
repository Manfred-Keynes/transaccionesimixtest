using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Pagos
{
    public class TblPagosImixDto
    {
        public string idCreditoImix { get; set; }
        public string idCreditoCooitza { get; set; }
        public string montoPago { get; set; }
        public string fechaPago { get; set; }
        public string jsonRequestCliente { get; set; }
        public string resultadoRequestCliente { get; set; }
        public string responseImix { get; set; }
        public string responsecws { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public Nullable<long> idTblUsuarioAlta { get; set; }
    }
}