/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2020 Irene Solutions SL
    Autores: Manuel Diago García, Juan Bautista Garcia Traver.

    Este programa es software libre; lo puede distribuir y/o modificar
    según los terminos de la licencia GNU Affero General Public License
    versión 3 según su redacción de la Free Software Foundation con la
    siguiente condición añadida en la sección 15 según se establece en
    la sección 7(a):

    PARA CUALQUIER PARTE DEL CÓGIO PROPIEDAD DE IRENE SOLUTIONS. IRENE 
    SOLUTIONS NO SE HACE RESPONSABLE DE LA VULNERACIÓN DE DERECHOS 
    DE TERCEROS.

    Este programa se distribuye con la esperanza de que sea útil, pero
    SIN GARANTÍA DE NINGÚN TIPO; ni siquiera la derivada de un acuerdo
    comercial o utilización para un propósito particular.
   
    Para más información puede consultar la licencia GNU Affero General
    Public http://www.gnu.org/licenses o escribir a la Free Software 
    Foundation, Inc. , 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, o descargarla en la siguiente URL:
        http://www.irenesolutions.com/terms-of-use.pdf 

    Las interfaces de usuario con versiones del código fuente del presente 
    proyecto, modificado o no, o código de objeto del mismo, deben incluir
    de manera visible los correspondientes avisos legales exigidos en la
    sección 5 de la licencia GNU Affero General Public.
    
    Puede evitar el cumplimiento de lo establecido de lo establecido 
    anteriormente comprando una licencia comercial. 
    La compra de una licencia comercial es obligatoria
    desde el momento en que usted desarrolle software comercial incluyendo
    funcionalidades de AeatModelos sin la publicación del código fuente
    de sus propias aplicaciones.
    Estas actividades incluyen: La oferta de servicios de pago mediante
    aplicaciones web de cualquier tipo que incluyan la funcionalidad
    de AeatModelos.
    
    Para más información, contacte con la dirección: info@irenesolutions.com    
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

        #region Métodos Privados Estáticos

        /// <summary>
        /// Devuelve la configuración por defecto.
        /// </summary>
        /// <returns>Configuración por defecto.</returns>
        internal static Certificados CargarPredeterminados()
        {
            return new Certificados
            {
                CertificadoModo = CertificadosModos.Archivo,
                RutaArchivo = @"C:\mi_certificado.pfx",
                Clave = "mi_contraseña"
            };

        }

        #endregion

        #region Propiedades Públicas de Instancia

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


        #endregion
 
    }
}
