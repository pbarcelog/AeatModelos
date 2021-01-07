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
    
    Puede evitar el cumplimiento de lo establecido 
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

using AeatModelos.Configuracion;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace AeatModelos.Comunicaciones
{

    /// <summary>
    /// Funcionalidades trabajo certificado cliente. 
    /// </summary>
    public static class Certificado
    {

        #region Métodos Públicos Estáticos

        /// <summary>
        /// Devuelve el certificado establecido en la configuración. 
        /// </summary>
        /// <param name="certRef">>Referencia para la carga del certificado,
        /// según el modo:
        /// <para>AlmacenWindows: Huella del certificado.</para>
        /// <para>Archivo: Ruta al cerfificado.</para> 
        /// </param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// <returns>Devuelve el certificado de la configuración.</returns>
        public static X509Certificate2 Cargar(string certRef = null, string certClave = null)
        {
            bool isWindows = (Environment.OSVersion.Platform == PlatformID.Win32NT) ||
                                (Environment.OSVersion.Platform == PlatformID.Win32S) ||
                                (Environment.OSVersion.Platform == PlatformID.Win32Windows) ||
                                (Environment.OSVersion.Platform == PlatformID.WinCE);
           
            if (Parametros.Actuales?.Certificados?.CertificadoModo == CertificadosModos.AlmacenWindows && !isWindows)
                throw new PlatformNotSupportedException(
                    Errores.MostrarMensaje("Certificado.000", 
                    $"'{Parametros.Actuales?.Certificados?.CertificadoModo}'", 
                    $"{Environment.OSVersion.Platform}")
                );

            X509Certificate2 certificado = null;

            if (Parametros.Actuales?.Certificados?.CertificadoModo == CertificadosModos.AlmacenWindows)
            {
                certificado = CargarPorHuella(certRef, certClave);
                
                if (certificado == null)
                    throw new Exception(
                        Errores.MostrarMensaje("Certificado.001", 
                        $"'{Parametros.Actuales?.Certificados?.HuellaDigital}'")
                    );
            }

            if (Parametros.Actuales?.Certificados?.CertificadoModo == CertificadosModos.Archivo)
            {
                certificado = CargarPorArchivo(certRef, certClave);
                
                if (certificado == null)
                    throw new Exception(
                        Errores.MostrarMensaje("Certificado.002", 
                        $"'{Parametros.Actuales?.Certificados?.RutaArchivo}'")
                    );
            }
            
            if (certificado.NotAfter < DateTime.Now)
                throw new ArgumentNullException(
                  Errores.MostrarMensaje("Certificado.003", $"{certificado.NotAfter}")
                );

            return certificado;
        }

        /// <summary>
        /// Devuelve el titular del cerficado.
        /// </summary>
        /// <param name="certificado">Certificado a analizar.</param>
        /// <returns>Titular.</returns>
        public static CertificadoTitular Titular(X509Certificate2 certificado)
        {

            string cn = null;

            switch (certificado.Issuer)
            {

                case "CN=AC FNMT Usuarios, OU=Ceres, O=FNMT-RCM, C=ES":

                    cn = Regex.Match(certificado.Subject, @"(?<=CN=)[^,]+").Value;

                    return new CertificadoTitular
                    {
                        NIF = Regex.Match(cn, @"(?<=-\s*)[^\s]+$").Value.Trim(),
                        Nombre = Regex.Match(cn, @"^[^-]+").Value.Trim()
                    };

                case "C=ES, O=ACCV, OU=PKIACCV, CN=ACCVCA-120":

                    cn = Regex.Match(certificado.Subject, @"(?<=CN=)[^,]+").Value;

                    return new CertificadoTitular
                    {
                        NIF = Regex.Match(cn, @"(?<=-\s*NIF:\s*)[^\s]+$").Value.Trim(),
                        Nombre = Regex.Match(cn, @"^[^-]+").Value.Trim()
                    };

                case "CN=AC Representación, OU=CERES, O=FNMT-RCM, C=ES":

                    cn = Regex.Match(certificado.Subject, @"(?<=O=)[^,]+").Value;

                    return new CertificadoTitular
                    {
                        NIF = Regex.Match(certificado.Subject, @"(?<=VATES\s*-\s*)[^,]+").Value.Trim(),
                        Nombre = Regex.Match(certificado.Subject, @"(?<=O=)[^,]+").Value.Trim()
                    };
            }

            return null;
        }

        /// <summary>
        /// Devuelve el certificado establecido en la configuración por su
        /// hash o huella digital. 
        /// </summary>
        /// <param name="certRef">Huella de certificado, en caso de utilizar certificado externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// <returns>Devuelve el certificado de la 
        /// configuración por hash para las comunicaciones.
        /// Si no existe devuelve null.</returns>
        internal static X509Certificate2 CargarPorHuella(string certRef = null, string certClave = null)
        {
            string huellaDigital = Parametros.Actuales?.Certificados?.HuellaDigital;
            if (!String.IsNullOrWhiteSpace(certRef))
                huellaDigital = certRef;

            X509Store store = new X509Store();
            store.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 cert in store.Certificates)
                if (cert.Thumbprint.ToUpper() == $"{huellaDigital}".ToUpper())
                    return cert;

            // Probamos en LocalMachine
            X509Store storeLM = new X509Store(StoreLocation.LocalMachine);
            storeLM.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 cert in storeLM.Certificates)
                if (cert.Thumbprint.ToUpper() == $"{huellaDigital}".ToUpper())
                    return cert;

            return null;
        }

        /// <summary>
        /// Devuelve el certificado establecido en la configuración
        /// mediante una ruta a un fichero de certificado.
        /// </summary>
        /// <param name="certRef">Ruta del certificado, en caso de utilizar certificado externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// <returns>Devuelve el certificado de la 
        /// configuración para las comunicaciones.</returns>
        internal static X509Certificate2 CargarPorArchivo(string certRef = null, string certClave = null)
        {
            string rutaCertificado = Parametros.Actuales?.Certificados?.RutaArchivo;
            if (!String.IsNullOrWhiteSpace(certRef))
                rutaCertificado = certRef;

            string claveCertificado = Parametros.Actuales?.Certificados?.Clave;
            if (!String.IsNullOrWhiteSpace(certRef)) // En caso de que se indique certificado, paso su correspondiente clave.
                claveCertificado = certClave;

            if (!string.IsNullOrEmpty(rutaCertificado) && File.Exists(rutaCertificado))
            {
                if (string.IsNullOrEmpty(claveCertificado))
                    return new X509Certificate2(rutaCertificado);
                else
                    return new X509Certificate2(rutaCertificado, claveCertificado);
            }

            return null;
        }

        #endregion
    }
}
