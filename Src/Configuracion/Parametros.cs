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
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace AeatModelos.Configuracion
{
    /// <summary>
    /// Parámetros de la aplicación.
    /// </summary>
    [Serializable]
    [XmlRoot("Parametros")]
    public class Parametros
    {

        #region Variables Privadas Estáticas

        /// <summary>
        /// Separador rutas directorios y archivos win="\" and linux ="/".
        /// </summary>
        static char _SeparadorRutas = Path.DirectorySeparatorChar;

        /// <summary>
        /// Configuración actual.
        /// </summary>
        static Parametros _Actuales;

        #endregion

        #region Propiedades Privadas Estáticas

        /// <summary>
        /// Ruta al directorio de configuración.
        /// </summary>
        internal static string Directorio = System.Environment.GetFolderPath(
            Environment.SpecialFolder.CommonApplicationData) + $"{_SeparadorRutas}AeatModelos{_SeparadorRutas}";

        /// <summary>
        /// Nombre del fichero de configuración.
        /// </summary>
        internal static string NombreFichero = "config.xml";

        #endregion

        #region Construtores Estáticos

        /// <summary>
        /// Constructor estático de la clase Parametros.
        /// </summary>
        static Parametros()
        {
            Carga();
        }

        #endregion

        #region Métodos Privados Estáticos

        /// <summary>
        /// Inicia estaticos.
        /// </summary>
        /// <returns>La configuración cargada.</returns>
        internal static Parametros Carga()
        {

            _Actuales = new Parametros();


            string FullPath = $"{Directorio}{_SeparadorRutas}" + NombreFichero;

            XmlSerializer serializer = new XmlSerializer(_Actuales.GetType());
            if (File.Exists(FullPath))
            {
                using (StreamReader r = new StreamReader(FullPath))
                {
                    _Actuales = serializer.Deserialize(r) as Parametros;
                }
            }
            else
            {
                _Actuales = CargarPredeterminados();
            }

            VerificaDirectorios();

            Guardar();

            return _Actuales;
        }

        /// <summary>
        /// Devuelve la configuración por defecto.
        /// </summary>
        /// <returns>Configuración por defecto.</returns>
        internal static Parametros CargarPredeterminados()
        {
            return new Parametros()
            {
                Version = $"{Assembly.GetExecutingAssembly().GetName().Version}",
                Plataforma = $"{Environment.OSVersion.Platform}",
                Pruebas = true,
                Certificados = Certificados.CargarPredeterminados()
            };
        }

        /// <summary>
        /// Aseguro existencia de directorios de trabajo.
        /// </summary>
        private static void VerificaDirectorios()
        {
            if (!Directory.Exists(Directorio))
                Directory.CreateDirectory(Directorio);
        }

        #endregion

        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Configuración en curso.
        /// </summary>
        public static Parametros Actuales
        {
            get
            {
                return _Actuales;
            }
            set
            {
                _Actuales = value;
            }
        }

        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Identificación de la versión de la aplicación.
        /// </summary>
        [XmlElement("Version")]
        public string Version { get; set; }

        /// <summary>
        /// Identificación de la plataforma en la que se
        /// encuentra instalada la versión.
        /// </summary>
        [XmlElement("Plataforma")]
        public string Plataforma { get; set; }

        /// <summary>
        /// Indicador de pruebas.
        /// </summary>
        [XmlElement("Pruebas")]
        public bool Pruebas { get; set; }

        /// <summary>
        /// Datos de configuración para el certificado
        /// de cliente a utilizar en la conexión TLS
        /// con la aeat..
        /// </summary>
        [XmlElement("Certificados")]
        public Certificados Certificados { get; set; }

        #endregion

        #region Métodos Públicos Estáticos

        /// <summary>
        /// Guarda la configuración en curso actual.
        /// </summary>
        public static void Guardar()
        {

            VerificaDirectorios();

            string FullPath = $"{Directorio}{_SeparadorRutas}" + NombreFichero;

            XmlSerializer serializer = new XmlSerializer(Actuales.GetType());

            using (StreamWriter w = new StreamWriter(FullPath))
            {
                serializer.Serialize(w, Actuales);
            }

        }

        #endregion

    }
}
