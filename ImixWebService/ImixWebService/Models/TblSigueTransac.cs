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
    
    public partial class TblSigueTransac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblSigueTransac()
        {
            this.TblSiguePagar = new HashSet<TblSiguePagar>();
        }
    
        public long idTbSigueTransac { get; set; }
        public string codigoTransac { get; set; }
        public string contenidoTransac { get; set; }
        public string EstadoTransac { get; set; }
        public string fechaAutorizacionTransac { get; set; }
        public string fechaCancelacionTransac { get; set; }
        public string fechaPagoRemesaTransac { get; set; }
        public string destinoFondosTransac { get; set; }
        public string origenFondosTransac { get; set; }
        public string tasaOrigenTransac { get; set; }
        public string importeTotalTransac { get; set; }
        public string idTransac { get; set; }
        public string idAgenteTransac { get; set; }
        public string estadoOrigenTransac { get; set; }
        public string origenTransac { get; set; }
        public string codigoOrigenTransac { get; set; }
        public string paisTransac { get; set; }
        public string codigoZipTransac { get; set; }
        public string ciudadDeAgenciaTransac { get; set; }
        public string codigoAgenteTransac { get; set; }
        public string nombreAgenteTransac { get; set; }
        public string ubicacionAgenteTransac { get; set; }
        public string usuarioAgenteTransac { get; set; }
        public string codigoCorresponsalDestinoTransac { get; set; }
        public string codigoCiudadDestinoISO3Transac { get; set; }
        public string codigoMonedaInporteTransac { get; set; }
        public string numeroAgenteTransac { get; set; }
        public string codigoPaisOrigenISO2Transac { get; set; }
        public string codigoPaisOrigenISO3Transac { get; set; }
        public string codigoMonedaOrigenTransac { get; set; }
        public string codigoOficinaPagoTransac { get; set; }
        public string nombreOficinaPagoTransac { get; set; }
        public string codigoTipoPagoTransac { get; set; }
        public string numeroDeReciboTransac { get; set; }
        public string codigoSeguridadTransac { get; set; }
        public string numeroRemesaTransac { get; set; }
        public string primerNombreBenTransac { get; set; }
        public string segundoNombreBenTransac { get; set; }
        public string primerApellidoBenTransac { get; set; }
        public string segundoApellidoBenTransac { get; set; }
        public string numeroIdBenTransac { get; set; }
        public string tipoIdBenTransac { get; set; }
        public string numeroTelefonoBenTransac { get; set; }
        public string ciudadResidencialBenTransac { get; set; }
        public string paisResidenciaISO3BenTransac { get; set; }
        public string codigoZipBenTransac { get; set; }
        public string primerNombreRemTransac { get; set; }
        public string segundoNombreRemTransac { get; set; }
        public string primerApellidoRemTransac { get; set; }
        public string segundoApellidoRemTransac { get; set; }
        public string numeroIdRemTransac { get; set; }
        public string tipoIdRemTransac { get; set; }
        public string telefonoRemTransac { get; set; }
        public string ciudadResidencialRemTransac { get; set; }
        public string paisResidenciaISO3RemTransac { get; set; }
        public string estadoResidenciaRemTransac { get; set; }
        public string zipCodeRemTransac { get; set; }
        public Nullable<long> idCatEstatusTransac { get; set; }
        public string usuarioProcessesTransac { get; set; }
        public Nullable<System.DateTime> fechaHoraBusqueda { get; set; }
        public string fechaNacimientoBenTransac { get; set; }
        public string jsonRequest { get; set; }
        public string httpStatusCode { get; set; }
        public string jsonResponse { get; set; }
        public string xmlRequest { get; set; }
        public string xmlResponse { get; set; }
        public string fechaIdExpBenTransac { get; set; }
    
        public virtual CatEstatusTransac CatEstatusTransac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSiguePagar> TblSiguePagar { get; set; }
    }
}
