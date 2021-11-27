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

        #region Variables Privadas

        /// <summary>
        /// Expresión regular para determinar si el texto de la respuesta indica
        /// que se han dado errores al realizar la petición de presentación
        /// </summary>
        static Regex _RgError = new Regex(@"(?<=<title>)Errores en modelo \d{3}(?=</title>)");

        /// <summary>
        /// Expresión regular para determina otra respuesta de error.
        /// </summary>
        static Regex _RgErrorEntradaIncorrecta = new Regex(@"<title>Entrada incorrecta</title>");

        /// <summary>
        /// Expresión regular leer los errores de la declaración
        /// en su caso como un bloque de texto.
        /// </summary>
        static Regex _RgErrores = new Regex("(?<=Err\\[\\d+\\]\\s*=\\s*\")[^\"]+(?=\")");

        /// <summary>
        /// Expresión regular leer los errores de la declaración
        /// en su caso como un bloque de texto.
        /// </summary>
        static Regex _RgErroresEntradaIncorrecta = new Regex("(?<=<div class=\"AEAT_bloque_errores\">\\s*)[^\\s][\\S\\s]+?(?=\\s*</div>)");

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
        protected HttpWebResponse _HttpWebResponse;

        /// <summary>
        /// Petición a la que pertenece la respuesta.
        /// </summary>
        protected Peticion _Peticion;

        /// <summary>
        /// Bytes de la respuesta.
        /// </summary>
        byte[] _ContenidoBinario;

        /// <summary>
        /// Texto de la respuesta.
        /// </summary>
        protected string _ContenidoTexto;

        #endregion     

        #region Construtores de Instancia

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
            _ContenidoTexto = _Peticion.Modelo.Encoding.GetString(_ContenidoBinario);

            Erronea = CompruebaErronea();

            _HttpWebResponse.Close();

            if (Erronea)
                TratarErrores();
            else
                TratarExito();
        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// Devuelve true si la respuesta de la aeat indica que la
        /// presentación ha sido errónea.
        /// </summary>
        /// <returns>True si errónea y false si correcta.</returns>
        protected virtual bool CompruebaErronea() 
        { 
            return _RgError.IsMatch(_ContenidoTexto) ||
                _RgErrorEntradaIncorrecta.IsMatch(_ContenidoTexto);
        }

        /// <summary>
        /// Lee los bytes de la respuesta del stream del objeto
        /// HttpWebResponse utilizado para recoger la respuesta de
        /// la AEAT.
        /// </summary>
        protected virtual void LeeContenido()
        {

            using (var stream = _HttpWebResponse.GetResponseStream())
            using (BinaryReader lectorBinario = new BinaryReader(stream))
                _ContenidoBinario = lectorBinario.ReadBytes((int)_HttpWebResponse.ContentLength);

        }

        /// <summary>
        /// Realiza las labores necesarias en caso de que la respuesta
        /// sea errónea.
        /// </summary>
        protected virtual void TratarErrores()
        {

            foreach (Match error in _RgErrores.Matches(_ContenidoTexto))
                Errores.Add(new RespuestaError(error.Value));

            foreach (Match error in _RgErroresEntradaIncorrecta.Matches(_ContenidoTexto))
                Errores.Add(new RespuestaError(error.Value));

        }

        /// <summary>
        /// Obtiene el código CSV de una respuesta correcta.
        /// </summary>
        protected virtual void RecuperaCSV() 
        {
            CSV = _RgCsv.Match(_ContenidoTexto).Value;
        }

        /// <summary>
        /// Obtiene el enlace al pdf de la declaración obtenida
        /// en una respuesta correcta.
        /// </summary>
        protected virtual void RecuperaEnlacePdf() 
        {
            EnlacePdf = _RgPdfEnlace.Match(_ContenidoTexto).Value;
        }

        /// <summary>
        /// Realiza las labores necesarias en caso de que la respuesta
        /// se satisfactoria.
        /// </summary>
        protected virtual void TratarExito()
        {

            RecuperaCSV();
            RecuperaEnlacePdf();

            if (string.IsNullOrEmpty(EnlacePdf))
                throw new InvalidDataException($"Enlace a PDF de declaración no encontrado para el CSV: {CSV}.\nCompruebe " + 
                    "la validación del CSV en la página web de la AEAT.");

            byte[] binarioRespuesta = null;

            using (WebClient webClient = new WebClient())
                binarioRespuesta = webClient.DownloadData(EnlacePdf);

            bool esPdf = EsFormatoPDF(binarioRespuesta);

            if (!esPdf)
            {
                // Esto es un 'hack - chapuzilla' para solucionar un bug en el entorno de pruebas
                // de la aeat (resulta que en ocasiones devuelven una url de producción en el entorno
                // de pruebas en la que no está el documento pdf)

                var enlaceTest = EnlacePdf.Replace("https://www2.agenciatributaria.gob.es", "https://www7.aeat.es");
                binarioRespuesta = RegistroMod.DescargaPdfMedianteEnlace(enlaceTest);

                esPdf = EsFormatoPDF(binarioRespuesta);

                if (!esPdf)
                {
                    // Esto es otro 'hack - chapuzilla' para cuando la presentación en real tiene el servidor parado.
                    // Probamos a descargar el documento PDF desde otro repositorio de la AEAT (disponible dentro del
                    // apartado de colaboradores con el certificado de colaborador para un CSV presentado).

                    binarioRespuesta = RegistroMod.DescargarPdfMedianteCSV(CSV);

                    esPdf = EsFormatoPDF(binarioRespuesta);

                    if (!esPdf)
                        throw new Exception(AeatModelos.Errores.MostrarMensaje("Respuesta.000",
                            _Peticion.Modelo.Encoding.GetString(binarioRespuesta)));
                }                    
            }

            DatosPdf = binarioRespuesta;
        }

        /// <summary>
        /// Comprueba si el archivo binario es un documento PDF.
        /// </summary>
        /// <param name="binario">Bytes con un posible documento PDF.</param>
        /// <returns>True en caso de ser un fichero PDF.</returns>
        protected bool EsFormatoPDF(byte[] binario)
        {
            bool esPdf = 
                (binario[0] == _PdfNumerosMagicos[0]) &&
                (binario[1] == _PdfNumerosMagicos[1]) &&
                (binario[2] == _PdfNumerosMagicos[2]) &&
                (binario[3] == _PdfNumerosMagicos[3]);

            return esPdf;
        }

        /// <summary>
        /// Prueba la descarga con certificado.
        /// </summary>
        /// <param name="enlace">Url del pdf a descargar.</param>
        /// <returns>Datos binarios de la respuesta.</returns>
        internal virtual byte[] DescargaPdfEnlace(string enlace)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(enlace);
            httpWebRequest.Method = "GET";
            httpWebRequest.ClientCertificates.Add(Certificado.Cargar());

            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            byte[] result = null;

            using (var stream = httpWebResponse.GetResponseStream())
            using (BinaryReader lectorBinario = new BinaryReader(stream))
                result = lectorBinario.ReadBytes((int)httpWebResponse.ContentLength);

            return result;
        }

        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Estado de la petición.
        /// </summary>
        public string Estado { get; private set; }

        /// <summary>
        /// Indica si no se ha realizado la presentación debido a errores.
        /// </summary>
        public bool Erronea { get; protected set; }

        /// <summary>
        /// Errors producidos en la presentación.
        /// </summary>
        public List<RespuestaError> Errores { get; private set; }

        /// <summary>
        /// Código seguro de verificación en caso de éxito.
        /// </summary>
        public string CSV { get; protected set; }

        /// <summary>
        /// Enlace al pdf de la autoliquidación en caso
        /// de éxito.
        /// </summary>
        public string EnlacePdf { get; protected set; }

        /// <summary>
        /// Datos binarios del pdf de la autoliquidación en caso
        /// de éxito.
        /// </summary>
        public byte[] DatosPdf { get; protected set; }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {

            if (Errores != null && Errores.Count > 0)
                return $"ER: [{Errores[0].Codigo}] [{Errores[0].Descripcion}";

            return $"OK: [CSV] {CSV}";

                
        }

        #endregion

    }
}
