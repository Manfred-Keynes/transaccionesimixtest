using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Transacciones
{
    public class Transaccion
    {
        [Required]
        public string internalCreditCode { get; set; }
        [Required]
        public string creditCode { get; set; }
        [Required]
        public string tipoIdSocio { get; set; }
        [Required]
        public string idDocumentoSocio { get; set; }
        [Required]
        public string nombreSocio { get; set; }
        [Required]
        public string apellidoSocio { get; set; }
        [Required]
        public string codigoPais { get; set; }
        [Required]
        public string celularSocio { get; set; }
        [Required]
        public string emailSocio { get; set; }
        [Required]
        public string direccionSocio { get; set; }
        [Required]
        public string pais { get; set; }
        [Required]
        public string departamento { get; set; }
        [Required]
        public string ciudad { get; set; }
        [Required]
        public string coloniaSocio { get; set; }
        [Required]
        public string vencimientoCredito { get; set; }
        [Required]
        public string plazoCredito { get; set; }
        [Required]
        public string amortizacionCredito { get; set; }
        [Required]
        public decimal? valorInicial { get; set; }
        [Required]
        public decimal? tasaCorrienteCredito { get; set; }
        [Required]
        public decimal? tasaMoraCredito { get; set; }
        [Required]
        public decimal? valorMinCredito { get; set; }
        [Required]
        public decimal? valorMaxCredito { get; set; }
        [Required]
        public decimal? valorSeguro { get; set; }
        public Utilizacion utilizacion { get; set; }
    }
}