using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Pagos
{
    public class Payment
    {
        //public string codecredit { get; set; }
        public string dpi { get; set; }
        public string creditoCooitza { get; set; }
        public decimal montoPago { get; set; }
        public string fechaPago { get; set; }
    }
}