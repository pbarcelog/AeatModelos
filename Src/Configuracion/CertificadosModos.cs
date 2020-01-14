using System.Xml.Serialization;

namespace AeatModelos.Configuracion
{

    /// <summary>
    /// Modos de gestión de certificados.
    /// </summary>
    public enum CertificadosModos
    {

        /// <summary>
        /// El certificado se cargará desde un archivo de certificado
        /// .pfx, .p12, .cer...
        /// </summary>
        [XmlEnum(Name = "Archivo")]
        Archivo,

        /// <summary>
        /// El archivo se cargará desde el almacén de certificados de windows.
        /// </summary>
        [XmlEnum(Name = "AlmacenWindows")]
        AlmacenWindows,
    }
}
