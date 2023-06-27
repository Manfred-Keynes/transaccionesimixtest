using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Pagos.Resolve
{
    public class ContentError
    {
        public string errorCode { get; set; }
        public string errorName { get; set; }
        public string errorFullCode { get; set; }
        public string errorMessage { get; set; }
        public string errorDetail { get; set; }
        public int statusCode { get; set; }
        public string traceCode { get; set; }
    }
}