//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImixWebService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblResumenSaldo
    {
        public long IdTblResumenSaldo { get; set; }
        public string Cartera { get; set; }
        public string Co { get; set; }
        public string Tipo { get; set; }
        public string Cuenta { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Npag { get; set; }
        public Nullable<decimal> Mvenc { get; set; }
        public Nullable<decimal> SaldoCap { get; set; }
        public Nullable<long> idTblResumen { get; set; }
        public Nullable<decimal> SaldoProd { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<decimal> PagoMinimo { get; set; }
        public Nullable<int> NpagDolar { get; set; }
        public Nullable<decimal> MvencDolar { get; set; }
        public Nullable<decimal> SaldoCapDolar { get; set; }
        public Nullable<decimal> SaldoProdDolar { get; set; }
        public Nullable<decimal> SaldoDolar { get; set; }
        public Nullable<decimal> PagoMinimoDolar { get; set; }
        public string Bufete { get; set; }
        public Nullable<int> Ciclo { get; set; }
        public string FechaIngreso { get; set; }
        public Nullable<int> Estatus { get; set; }
        public string FultPagoB { get; set; }
        public string FultPagoA { get; set; }
        public Nullable<decimal> SaldoNoContB { get; set; }
        public Nullable<decimal> SaldoNoContA { get; set; }
        public Nullable<decimal> SaldoExtrafB { get; set; }
        public Nullable<decimal> SaldoExtrafA { get; set; }
        public Nullable<decimal> LimiteB { get; set; }
        public Nullable<decimal> LimiteA { get; set; }
        public string FechaVencimiento { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Sexo { get; set; }
        public string Nit { get; set; }
        public string Cedula { get; set; }
        public string DPI { get; set; }
        public string Telefono { get; set; }
        public string CodigoAsociado { get; set; }
        public string Agencia { get; set; }
        public Nullable<long> IdTblUsuarios { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<long> IdTblUsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<long> IdCatEstados { get; set; }
        public string linea { get; set; }
    
        public virtual TblResumen TblResumen { get; set; }
        public virtual CatEstados CatEstados { get; set; }
    }
}
