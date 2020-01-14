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
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AeatModelos.Comunicaciones
{

    /// <summary>
    /// Representa una petición a un servicios de declaraciones
    /// de la aeat para un modelo concreto.
    /// </summary>
    public class Peticion
    {

        /// <summary>
        /// Codificación utilizada por la AEAT.
        /// </summary>
        static Encoding _Encoding = Encoding.GetEncoding("ISO-8859-1");

        /// <summary>
        /// Certificado de cliente para la conexión con los servicios
        /// de la aeat.
        /// </summary>
        X509Certificate2 _Certificado;

        /// <summary>
        /// Titular del certificado de cliente para la conexión 
        /// con los servicios
        /// de la aeat.
        /// </summary>        
        CertificadoTitular _CertificadoTitular;

        /// <summary>
        /// Enlace al servicio de presentación de la aeat 
        /// para el modelo.
        /// </summary>        
        string _Enlace;

        /// <summary>
        /// Petición http.
        /// </summary>
        HttpWebRequest _HttpWebRequest;

        /// <summary>
        /// Fichero construido según el diseño de registro correspondiente
        /// de la aeat para el modelo.
        /// </summary>
        string _TextoFichero;

        /// <summary>
        /// Texto de la petición a enviar al servicio de presentación de la
        /// AEAT.
        /// </summary>
        string _TextoPeticion;

        /// <summary>
        /// Datos binarios de la petición con el encoding utilizado por
        /// la aeat.
        /// </summary>
        byte[] _BytesPeticion;

        /// <summary>
        /// Respuesta recibida una vez presentada la
        /// petición.
        /// </summary>
        Respuesta _Respuesta;

        /// <summary>
        /// Objeto HttpWebRequest base para la realización
        /// de la petición.
        /// </summary>
        internal HttpWebRequest PeticionHttp 
        {
            get 
            {
                return _HttpWebRequest;
            }
        }

        /// <summary>
        /// Copnstruye una instancia de la clase
        /// Peticion.
        /// </summary>
        /// <param name="modelo">Modelo para el que se ha construido la 
        /// petición.</param>
        public Peticion(RegistroMod modelo) 
        {

            _Certificado = Certificado.Cargar();

            _CertificadoTitular = Certificado.Titular(_Certificado);

            if (_CertificadoTitular == null)
                throw new Exception($"No se ha podido determinar el titular del certificado {_Certificado.Subject}.");


            _Enlace = Enlaces.BuscaEnlaceModelo(modelo);

            if (_Enlace == null)
                throw new Exception($"No se ha podido determinar el enlace al servicio" +
                    $" de presentación de la AEAT para el modelo {modelo.GetType().Name}.");

            _HttpWebRequest = (HttpWebRequest)WebRequest.Create(_Enlace);
            _HttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            _HttpWebRequest.Method = "POST";
            _HttpWebRequest.ClientCertificates.Add(_Certificado);

            _TextoFichero = modelo.AFichero();

            modelo.VariablesEnvio["FIRNIF"] = _CertificadoTitular.NIF;
            modelo.VariablesEnvio["FIRNOMBRE"] = _CertificadoTitular.Nombre;
            modelo.VariablesEnvio["F01"] = _TextoFichero;

            _TextoPeticion = modelo.DatosPeticionPresentacion();
            _BytesPeticion = _Encoding.GetBytes(_TextoPeticion);

        }

        /// <summary>
        /// Escribe los datos a envíar en el stream de la 
        /// petición.
        /// </summary>
        private void EscribePeticion() 
        {
            using (Stream stream = _HttpWebRequest.GetRequestStream())
                stream.Write(_BytesPeticion, 0, _BytesPeticion.Length);
        }

        /// <summary>
        /// Intenta presentar la declaración mediante el envío de la petición
        /// al servicio correspondiente de la AET, y devuelve la respuesta de 
        /// la misma.
        /// </summary>
        /// <returns>Respuesta a una petición de presentación</returns>
        public Respuesta Presentar() 
        {
            
            EscribePeticion();

            _Respuesta = new Respuesta(this);

            return _Respuesta;
        }


    }
}
