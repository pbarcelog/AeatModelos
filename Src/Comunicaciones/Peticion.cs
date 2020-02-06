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
    
    uede evitar el cumplimiento de lo establecido de lo establecido 
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
        string _ContentType = "application/x-www-form-urlencoded";

        /// <summary>
        /// Valor para el método utilizado en la petición http.
        /// </summary>
        string _Method = "POST";

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

        #endregion

        #region Construtores de Instancia

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
                throw new Exception(Errores.MostrarMensaje("Peticion.000", $"{_Certificado.Subject}"));


            _Enlace = Enlaces.BuscaEnlaceModelo(modelo);
            
            if (_Enlace == null)
                throw new Exception(Errores.MostrarMensaje("Peticion.001", $"{modelo.GetType().Name}"));

            _HttpWebRequest = (HttpWebRequest)WebRequest.Create(_Enlace);
            _HttpWebRequest.ContentType = _ContentType;
            _HttpWebRequest.Method = _Method;
            _HttpWebRequest.ClientCertificates.Add(_Certificado);

            _TextoFichero = modelo.AFichero().Replace("\n", "");

            modelo.VariablesEnvio["FIRNIF"] = _CertificadoTitular.NIF;
            modelo.VariablesEnvio["FIRNOMBRE"] = _CertificadoTitular.Nombre;
            modelo.VariablesEnvio["F01"] = _TextoFichero;

            _TextoPeticion = modelo.DatosPeticionPresentacion();
            _BytesPeticion = RegistroMod.Encoding.GetBytes(_TextoPeticion);

        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// Escribe los datos a envíar en el stream de la 
        /// petición.
        /// </summary>
        private void EscribePeticion()
        {
            using (Stream stream = _HttpWebRequest.GetRequestStream())
                stream.Write(_BytesPeticion, 0, _BytesPeticion.Length);
        }

        #endregion      

        #region Métodos Públicos de Instancia

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

        #endregion


    }
}
