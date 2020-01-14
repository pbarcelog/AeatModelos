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


using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace AeatModelos.Comunicaciones
{


    /// <summary>
    /// Representa una respuesta de la AEAT a una petición de presentación
    /// envíada.
    /// </summary>
    public class Respuesta
    {

        /// <summary>
        /// Codificación utilizada por la AEAT.
        /// </summary>
        static Encoding _Encoding = Encoding.GetEncoding("ISO-8859-1");

        /// <summary>
        /// Expresión regular para determinar si el texto de la respuesta indica
        /// que se han dado errores al realizar la petición de presentación
        /// </summary>
        static Regex _RgError = new Regex(@"(?<=<title>)Errores en modelo \d{3}(?=</title>)");

        /// <summary>
        /// Expresión regular leer los errores de la declaración
        /// en su caso como un bloque de texto.
        /// </summary>
        static Regex _RgErrores = new Regex("(?<=Err\\[\\d+\\]\\s*=\\s*\")[^\"]+(?=\")");

        /// <summary>
        /// Expresión regular para obtener el código seguro de
        /// de verificación CSV de la presentación en su caso.
        /// </summary>
        static Regex _RgCsv = new Regex(@"(?<=<title>\s*)[\w]+");

        /// <summary>
        /// Expresión regular para extraer el enlace al documento pdf de la
        /// autoliquidación realizada en su caso.
        /// </summary>
        static Regex _RgPdfEnlace = new Regex("(?<=var\\s+urlPdf\\s*=\\s*\")[^\"]+");

        /// <summary>
        /// Respuesta http de la AEAT.
        /// </summary>
        HttpWebResponse _HttpWebResponse;

        /// <summary>
        /// Petición a la que pertenece la respuesta.
        /// </summary>
        Peticion _Peticion;

        /// <summary>
        /// Bytes de la respuesta.
        /// </summary>
        byte[] _ContenidoBinario;

        /// <summary>
        /// Texto de la respuesta.
        /// </summary>
        string _ContenidoTexto;

        /// <summary>
        /// Estado de la petición.
        /// </summary>
        public string Estado { get; private set; }

        /// <summary>
        /// Indica si no se ha realizado la presentación debido a errores.
        /// </summary>
        public bool Erronea { get; private set; }

        /// <summary>
        /// Errors producidos en la presentación.
        /// </summary>
        public List<RespuestaError> Errores { get; private set; }

        /// <summary>
        /// Código seguro de verificación en caso de éxito.
        /// </summary>
        public string CSV { get; private set; }

        /// <summary>
        /// Enlace al pdf de la autoliquidación en caso
        /// de éxito.
        /// </summary>
        public string EnlacePdf { get; private set; }

        /// <summary>
        /// Datos binarios del pdf de la autoliquidación en caso
        /// de éxito.
        /// </summary>
        public byte[] DatosPdf { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="peticion">Petición a la que pertenece la respuesta.</param>
        public Respuesta(Peticion peticion) 
        {

            _Peticion = peticion;

            Errores = new List<RespuestaError>();

            _HttpWebResponse = (HttpWebResponse)peticion.PeticionHttp.GetResponse();

            Estado = _HttpWebResponse.StatusDescription;

            LeeContenido();
            _ContenidoTexto = _Encoding.GetString(_ContenidoBinario);

            Erronea = _RgError.IsMatch(_ContenidoTexto);

            _HttpWebResponse.Close();

            if (Erronea)
                TratarErrores();
            else
                TratarExito();


        }

        /// <summary>
        /// Lee los bytes de la respuesta del stream del objeto
        /// HttpWebResponse utilizado para recoger la respuesta de
        /// la AEAT.
        /// </summary>
        private void LeeContenido() 
        {

            using (var stream = _HttpWebResponse.GetResponseStream()) 
                using (BinaryReader lectorBinario = new BinaryReader(stream)) 
                    _ContenidoBinario = lectorBinario.ReadBytes((int)_HttpWebResponse.ContentLength);
        
        }

        /// <summary>
        /// Realiza las labores necesarias en caso de que la respuesta
        /// se errónea.
        /// </summary>
        private void TratarErrores() 
        {

            foreach(Match error in _RgErrores.Matches(_ContenidoTexto))
                Errores.Add(new RespuestaError(error.Value));
        }

        /// <summary>
        /// Realiza las labores necesarias en caso de que la respuesta
        /// se satisfactoria.
        /// </summary>
        private void TratarExito() 
        {
            
            CSV = _RgCsv.Match(_ContenidoTexto).Value;
            EnlacePdf = _RgPdfEnlace.Match(_ContenidoTexto).Value;

            using (WebClient webClient = new WebClient())
                DatosPdf = webClient.DownloadData(EnlacePdf);

        }

    }
}
