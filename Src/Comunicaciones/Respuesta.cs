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
using System.Collections.Generic;
using System.IO;
using System.Net;
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
        /// Números mágicos del pdf para verificar posibles errores en el
        /// enlace devuelto por la aeat (bug conocido en el entorno de pruebas).
        /// </summary>
        static byte[] _PdfNumerosMagicos = new byte[4] { 0x25, 0x50, 0x44, 0x46 };

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
            _ContenidoTexto = RegistroMod.Encoding.GetString(_ContenidoBinario);

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

            byte[] binarioRespuesta = null;

            using (WebClient webClient = new WebClient())
                binarioRespuesta = webClient.DownloadData(EnlacePdf);


            bool esPdf = (binarioRespuesta[0] == _PdfNumerosMagicos[0]) &&
                (binarioRespuesta[1] == _PdfNumerosMagicos[1]) &&
                (binarioRespuesta[2] == _PdfNumerosMagicos[2]) &&
                (binarioRespuesta[3] == _PdfNumerosMagicos[3]);

            if (esPdf)
            {
                DatosPdf = binarioRespuesta;
            }
            else 
            {
                // Esto es un 'hack - chapuzilla' para solucionar un bug en el entorno de pruebas
                // de la aeat (resulta que en ocasiones devuelven una url de producción en el entorno
                // de pruebas en la que no está el documento pdf)
                var enlaceTest = EnlacePdf.Replace("https://www2.agenciatributaria.gob.es", "https://www7.aeat.es");
                binarioRespuesta = DescargaPdfEnlaceTest(enlaceTest);

                esPdf = (binarioRespuesta[0] == _PdfNumerosMagicos[0]) &&
                (binarioRespuesta[1] == _PdfNumerosMagicos[1]) &&
                (binarioRespuesta[2] == _PdfNumerosMagicos[2]) &&
                (binarioRespuesta[3] == _PdfNumerosMagicos[3]);

                if (!esPdf)
                    throw new Exception("Error al descargar el documento pdf.");

                DatosPdf = binarioRespuesta;

            }

        }

        /// <summary>
        /// Prueba la descarga con certificado desde pruebas.
        /// </summary>
        /// <param name="enlace">Url del pdf a descargar.</param>
        /// <returns>Datos binarios de la respuesta.</returns>
        private byte[] DescargaPdfEnlaceTest(string enlace) 
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(enlace);
            httpWebRequest.Method = "GET";
            httpWebRequest.ClientCertificates.Add(Certificado.Cargar());

            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            byte[] result = null;

            using (var stream = httpWebResponse.GetResponseStream())
            using (BinaryReader lectorBinario = new BinaryReader(stream))
                result = lectorBinario.ReadBytes((int)_HttpWebResponse.ContentLength);

            return result;

        }

    }
}
