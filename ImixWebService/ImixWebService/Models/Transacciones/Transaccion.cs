using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImixWebService.Models.Transacciones
{
    public class Transaccion
    {
        public string internalCreditCode { get; set; }
        public string codigoSocio { get; set; }
        public string tipoIdSocio { get; set; }
        public string idDocumentoSocio { get; set; }
        public string nombreSocio { get; set; }
        public string apellidoSocio { get; set; }
        public string codigoPais { get; set; }
        public string celularSocio { get; set; }
        public string emailSocio { get; set; }
        public string direccionSocio { get; set; }
        public string pais { get; set; }
        public string departamento { get; set; }
        public string ciudad { get; set; }
        public string coloniaSocio { get; set; }
        public string vencimientoCredito { get; set; }
        public string plazoCredito { get; set; }
        public string amortizacionCredito { get; set; }
        public decimal? valorInicial { get; set; }
        public decimal? tasaCorrienteCredito { get; set; }
        public decimal? tasaMoraCredito { get; set; }
        public decimal? valorMinCredito { get; set; }
        public decimal? valorMaxCredito { get; set; }
        public decimal? valorSeguro { get; set; }
        public Utilizacion utilizacion { get; set; }
    }
}