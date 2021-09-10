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

using System.Text.RegularExpressions;

namespace AeatModelos.Comunicaciones
{

    /// <summary>
    /// Representa una respuesta de la AEAT a una petición de presentación
    /// envíada al sistema de presentación básica dos.
    /// </summary>
    public class RespuestaPresBasicaDos : Respuesta
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="peticion">Petición a la que pertenece la respuesta.</param>
        public RespuestaPresBasicaDos(PeticionPresBasicaDos peticion) : base(peticion)
        {
        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// Devuelve true si la respuesta de la aeat indica que la
        /// presentación ha sido errónea.
        /// </summary>
        /// <returns>True si errónea y false si correcta.</returns>
        protected override bool CompruebaErronea()
        {
            return Regex.IsMatch(_ContenidoTexto, "(\"|'){0,1}errores(\"|'){0,1}:\\[[^\\]]+");
        }

        /// <summary>
        /// Realiza las labores necesarias en caso de que la respuesta
        /// sea errónea.
        /// </summary>
        protected override void TratarErrores()
        {

            var errores = Regex.Match(_ContenidoTexto, "(?<=(\"|'){0,1}errores(\"|'){0,1}:\\s*\\[)[^\\]]*").Value;

            if (errores == null)
                return;

            foreach (var error in errores.Split(','))
                Errores.Add(new RespuestaError(Regex.Match(error, "(?<=\")[^\"]*(?=\")").Value));
        }

        /// <summary>
        /// Obtiene el código CSV de una respuesta correcta.
        /// </summary>
        protected override void RecuperaCSV()
        {
            CSV = Regex.Match(_ContenidoTexto, "(?<=(\"|'|“|”){0,1}\\s*CodigoSeguroVerificacion\\s*(\"|'|“|”){ 0,1}\\s *:(\"|'){0,1})[^(\"|'|“|”)]*").Value;
        }

        /// <summary>
        /// Obtiene el enlace al pdf de la declaración obtenida
        /// en una respuesta correcta.
        /// </summary>
        protected override void RecuperaEnlacePdf()
        {
            EnlacePdf = Regex.Match(_ContenidoTexto, "(?<=(\"|'|“|”){0,1}\\s*urlPdf(\"|'|“|”){0,1}\\s*:\\s* (\"|'|“|”){0,1})[^(\"|'|“|”)]*").Value;
        }

        #endregion

    }
}
