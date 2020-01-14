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

        /// <summary>
        /// Separador rutas directorios y archivos win="\" and linux ="/".
        /// </summary>
        static char _SeparadorRutas = System.IO.Path.DirectorySeparatorChar;

        /// <summary>
        /// Configuración actual.
        /// </summary>
        static Parametros _Actuales;

        /// <summary>
        /// Ruta al directorio de configuración.
        /// </summary>
        internal static string Directorio = System.Environment.GetFolderPath(
            Environment.SpecialFolder.CommonApplicationData) + $"{_SeparadorRutas}AeatModelos{_SeparadorRutas}";

        /// <summary>
        /// Nombre del fichero de configuración.
        /// </summary>
        internal static string NombreFichero = "config.xml";

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

        /// <summary>
        /// Constructor estático de la clase Parametros.
        /// </summary>
        static Parametros()
        {
            Carga();
        }

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

    }
}
