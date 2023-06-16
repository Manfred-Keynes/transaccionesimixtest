using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImixWebService.Models
{
    public class LoginViewModel
    {
        [Required]
        public string usuarioWebService { get; set; }
        [Required]
        public string clave { get; set; }
        [Required]
        public string llave { get; set; }
    }
}