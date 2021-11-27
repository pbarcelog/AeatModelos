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

        #region Variables Privadas

        /// <summary>
        /// Valor para el head ContentType de la petición.
        /// </summary>
        protected string _ContentType = "application/x-www-form-urlencoded";

        /// <summary>
        /// Valor para el método utilizado en la petición http.
        /// </summary>
        string _Method = "POST";

        /// <summary>
        /// Certificado de cliente para la conexión con los servicios
        /// de la aeat.
        /// </summary>
        protected X509Certificate2 _Certificado;

        /// <summary>
        /// Titular del certificado de cliente para la conexión 
        /// con los servicios
        /// de la aeat.
        /// </summary>        
        protected CertificadoTitular _CertificadoTitular;

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
        protected string _TextoFichero;

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
        protected Respuesta _Respuesta;

        /// <summary>
        /// Indica si la petición es para el entorno de
        /// pruebas (true) o de producción (false).
        /// </summary>
        bool _Test;

        /// <summary>
        /// Modelo sobre el cual se ha construido la petición.
        /// </summary>
        internal RegistroMod Modelo;

        #endregion

        #region Propiedades Privadas

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
        /// Titular del certificado de cliente para la conexión 
        /// con los servicios
        /// de la aeat.
        /// </summary>        
        internal CertificadoTitular CertificadoTitular 
        { 
            get
            {
                return _CertificadoTitular;
            } 
        }

        #endregion

        #region Construtores de Instancia

        /// <summary>
        /// Copnstruye una instancia de la clase
        /// Peticion.
        /// </summary>
        /// <param name="modelo">Modelo para el que se ha construido la 
        /// petición.</param>
        /// <param name="test">Indica si la presentación se realiza en el entorno en pruebas de la AEAT.</param>
        /// <param name="certRef">Ruta de certificado para la presentación, en caso de que se utilice uno externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// <param name="encoding">Tipo de encoding para el envío del registro.</param>
        public Peticion(RegistroMod modelo, bool test = false, string certRef = null, string certClave = null, Encoding encoding = null)
        {

            Modelo = modelo;
            _Test = test;

            modelo.Encoding = encoding == null ? modelo.Encoding : encoding;

            InicializaCertificado(certRef, certClave);

            _TextoFichero = modelo.AFichero().Replace("\n", "");

            InicializaFirmaBasica();

            _TextoPeticion = modelo.DatosPeticionPresentacion();
            _BytesPeticion = modelo.Encoding.GetBytes(_TextoPeticion);

        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// Inicializa el certificado a utilizar para transmitir la
        /// petición a la aeat.
        /// </summary>
        /// <param name="certRef">Ruta de certificado para la presentación, en caso de que se utilice uno externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        private void InicializaCertificado(string certRef, string certClave) 
        {
            _Certificado = Certificado.Cargar(certRef, certClave);

            _CertificadoTitular = Certificado.Titular(_Certificado);

            if (_CertificadoTitular == null)
                throw new Exception(Errores.MostrarMensaje("Peticion.000", $"{_Certificado.Subject}"));
        }

        /// <summary>
        /// Recupera la url donde se encuentra el servicio de la aeat requerido
        /// por la petición y su modelo.
        /// </summary>
        /// <param name="test">True para pruebas y false para produccíón.</param>
        /// <returns>Url del servicio de la aeat correspondiente al modelo de la petición.</returns>
        protected virtual string GeneraEnlace(bool test) 
        {
            var enlace = test ? Modelo.Enlaces.UrlPruebas : Modelo.Enlaces.UrlProduccion;

            if (enlace == null)
                throw new Exception(Errores.MostrarMensaje("Peticion.001", $"{Modelo.GetType().Name}"));

            return enlace;

        }

        /// <summary>
        /// Establece los valores de las variables de envío necesarias para la
        /// firma básica.
        /// </summary>
        protected virtual void InicializaFirmaBasica() 
        {
            Modelo.VariablesEnvio["FIRNIF"] = _CertificadoTitular.NIF;
            Modelo.VariablesEnvio["FIRNOMBRE"] = _CertificadoTitular.Nombre;
            Modelo.VariablesEnvio["F01"] = _TextoFichero;
        }

        /// <summary>
        /// Escribe los datos a envíar en el stream de la 
        /// petición.
        /// </summary>
        protected void EscribePeticion()
        {
            using (Stream stream = _HttpWebRequest.GetRequestStream())
                stream.Write(_BytesPeticion, 0, _BytesPeticion.Length);
        }

        /// <summary>
        /// Inicializa el objeto HttpWebRequest para mandar la petición.
        /// </summary>
        internal void PreparaPeticion() 
        {
            if (PeticionHttp != null)
                return;

            _Enlace = GeneraEnlace(_Test);

            _HttpWebRequest = (HttpWebRequest)WebRequest.Create(_Enlace);
            _HttpWebRequest.ContentType = _ContentType;
            _HttpWebRequest.Method = _Method;
            _HttpWebRequest.ClientCertificates.Add(_Certificado);
        }

        #endregion      

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Intenta presentar la declaración mediante el envío de la petición
        /// al servicio correspondiente de la AET, y devuelve la respuesta de 
        /// la misma.
        /// </summary>
        /// <returns>Respuesta a una petición de presentación</returns>
        public virtual Respuesta Presentar(bool test = false)
        {

            PreparaPeticion();
            EscribePeticion();

            _Respuesta = new Respuesta(this);

            return _Respuesta;
        }

        #endregion

    }
}
