using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Pagos
{
    public class Payment
    {
        //public string codecredit { get; set; }
        [Required]
        public string dpi { get; set; }
        [Required]
        public string creditoCooitza { get; set; }
        [Required]
        public decimal montoPago { get; set; }
        [Required]
        public string fechaPago { get; set; }
    }
}