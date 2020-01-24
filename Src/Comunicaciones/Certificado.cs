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
    public class Certificado
    {

        /// <summary>
        /// Devuelve el certificado establecido en la configuración. 
        /// </summary>
        /// <returns>Devuelve el certificado de la 
        /// configuración.</returns>
        public static X509Certificate2 Cargar() 
        {

            bool isWindows = (Environment.OSVersion.Platform == PlatformID.Win32NT) ||
                                (Environment.OSVersion.Platform == PlatformID.Win32S) ||
                                (Environment.OSVersion.Platform == PlatformID.Win32Windows) ||
                                (Environment.OSVersion.Platform == PlatformID.WinCE);

            if (Parametros.Actuales?.Certificados?.CertificadoModo == CertificadosModos.AlmacenWindows && !isWindows)
                throw new PlatformNotSupportedException($"El modo de gestión de certificados" +
                    $" '{Parametros.Actuales?.Certificados?.CertificadoModo}'" +
                    $" no es compatible con la plataforma {Environment.OSVersion.Platform}.");

            X509Certificate2 certificado = null;

            if (Parametros.Actuales?.Certificados?.CertificadoModo == CertificadosModos.AlmacenWindows) 
            {

                certificado = CargarPorHuella();

                if (certificado == null) 
                    throw new Exception($"No se ha encontrado un certificado con la huella digital" +
                        $" '{Parametros.Actuales?.Certificados?.HuellaDigital}' ni en el" +
                        $"almacén de certificados del usuario ni en el de la máquina local.");

            }

            if (Parametros.Actuales?.Certificados?.CertificadoModo == CertificadosModos.Archivo)
            {

                certificado = CargarPorArchivo();

                if (certificado == null)
                    throw new Exception($"No se ha podido cargar el archivo de certificado" +
                        $" '{Parametros.Actuales?.Certificados?.RutaArchivo}'. Revise la ruta" +
                        $"al archivo y la contraseña.");

            }

            if (certificado.NotAfter < DateTime.Now)
                throw new ArgumentNullException(
                  $"El certificado establecido en la configuración dejó de" +
                  $"ser válido después de {certificado.NotAfter}.");

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
        /// <returns>Devuelve el certificado de la 
        /// configuración por hash para las comunicaciones.
        /// Si no existe devuelve null.</returns>
        internal static X509Certificate2 CargarPorHuella()
        {
            X509Store store = new X509Store();
            store.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 cert in store.Certificates)
                if (cert.Thumbprint.ToUpper() == $"{Parametros.Actuales?.Certificados?.HuellaDigital}".ToUpper())
                    return cert;

            // Probamos en LocalMachine
            X509Store storeLM = new X509Store(StoreLocation.LocalMachine);
            storeLM.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 cert in storeLM.Certificates)
                if (cert.Thumbprint.ToUpper() == $"{Parametros.Actuales?.Certificados?.HuellaDigital}".ToUpper())
                    return cert;

            return null;
        }

        /// <summary>
        /// Devuelve el certificado establecido en la configuración
        /// mediante una ruta a un fichero de certificado.
        /// </summary>
        /// <returns>Devuelve el certificado de la 
        /// configuración para las comunicaciones.</returns>
        internal static X509Certificate2 CargarPorArchivo()
        {

            if (!string.IsNullOrEmpty(Parametros.Actuales?.Certificados?.RutaArchivo) &&
                File.Exists(Parametros.Actuales?.Certificados?.RutaArchivo))
                if (string.IsNullOrEmpty(Parametros.Actuales?.Certificados?.Clave))
                    return new X509Certificate2(Parametros.Actuales?.Certificados?.RutaArchivo);
                else
                    return new X509Certificate2(Parametros.Actuales?.Certificados?.RutaArchivo,
                        Parametros.Actuales?.Certificados?.Clave);

            return null;

        }
    }
}
