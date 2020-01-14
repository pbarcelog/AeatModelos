/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2020 Irene Solutions SL
    Autores: Irene Solutions SL.

    Este programa es software libre; usted puede redistribuirlo y/o modificarlo
    bajo los términos establecidos en GNU Affero General Public License versión 3
    tal y como han sido publicados por la Free Software Foundation.

    Este programa se distribuye con la intención de que sea útil, pero SIN
    NIGÚN TIPO DE GARANTÍA.

    Para más detalles consulte la licencia GNU Affero General Public.
    Debe se haber recibido una copia de la misma con el presente programa;
    en caso contrario, consulte http://www.gnu.org/licenses o escriba a la 
    Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, o descargue la licencia en la URL:
        http://www.irenesolutions.com/terms-of-use.pdf
    
    Las interfaces de ususario con código modificado y versiones de los
    objetos contenidos en el presente programa deben mostrar las advertencias
    legaels apropiadas, como se requiere en la secion 5 de la licencia GNU Affero
    General Public.

    Usted puede ser liberado de los requerimiento de la licencia mediante
    la compra de una licencia comercial. La compra de la licencia es
    obligatoria en caso de que vaya a desarrollar actividades comerciales
    con el software AeatModelos sin publicar el código fuente de sus 
    propias aplicaciones.
    Estas actividades incluyen: ofrecer servicios de pago como mediante ASP,
    sirviendo los resultados obtenidos mediante el presente software mediante
    aplicaciones web, o empaquetando AeatModelos con un producto de código
    fuente no público.    
       
    Para más información, por favor contacte a Irene Solutions SL. en la
    dirección: info@irenesolutions.com
 */

using System;
using System.Xml.Serialization;

namespace AeatModelos.Configuracion
{
    /// <summary>
    /// Configuración del certificado de cliente a utilizar
    /// en las comunicaciones con la AEAT.
    /// </summary>
    [Serializable]
    [XmlRoot("Parametros")]
    public class Certificados
    {

        /// <summary>
        /// Indica el sistema de trabajo que se va a utilizar
        /// con el certificado de cliente necesario para la conexión
        /// TLS con la la web de la aeat.
        /// </summary>
        [XmlElement("CertificadoModo")]
        public CertificadosModos CertificadoModo { get; set; }


        /// <summary>
        /// Hash o Huella digital del certificado a utilizar.
        /// Valor utilizado para cargar el certificado desde
        /// el almacén de certificados de windows.
        /// </summary>
        [XmlElement("HuellaDigital")]
        public string HuellaDigital { get; set; }

        /// <summary>
        /// Ruta al archivo del certificado a utilizar.
        /// </summary>
        [XmlElement("RutaArchivo")]
        public string RutaArchivo { get; set; }

        /// <summary>
        /// Clave para el archivo del certificado a utilizar.
        /// </summary>
        [XmlElement("Clave")]
        public string Clave { get; set; }

        /// <summary>
        /// Devuelve la configuración por defecto.
        /// </summary>
        /// <returns>Configuración por defecto.</returns>
        internal static Certificados CargarPredeterminados()
        {
            return new Certificados{
                CertificadoModo = CertificadosModos.Archivo,
                RutaArchivo = @"C:\mi_certificado.pfx",
                Clave = "mi_contraseña"
            };

        }
    }
}
