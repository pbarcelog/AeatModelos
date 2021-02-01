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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeatModelos.Comunicaciones
{

    /// <summary>
    /// Representa una respuesta de la AEAT a una petición de presentación
    /// envíada al sistema TGVI.
    /// </summary>

    public class RespuestaTgvi : Respuesta
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="peticion">Petición a la que pertenece la respuesta.</param>
        public RespuestaTgvi(PeticionTgvi peticion) : base(peticion)
        {         
        }

        /// <summary>
        /// Identificador único de un envío, necesario para el envío de datos y la 
        /// presentación de un envío. Solo se devolverá si la operación se he 
        /// llevado a cabo con éxito.
        /// </summary>
        public string IdEnvio { get; private set; }

        /// <summary>
        /// Indica el siguiente bloque de datos que se espera recibir. Tras la inicialización 
        /// con éxito del envío tendrá siempre el valor 1. Solo se devolverá si la operación 
        /// se he llevado a cabo con éxito.
        /// </summary>
        public string SigBloque { get; private set; }

        /// <summary>
        /// Cookie establecida por la aeat para id sesión...
        /// Se debe respetar e posteriores peticiones.
        /// </summary>
        public string Cookie { get; private set; }

        /// <summary>
        /// Indica el estado en el que ha quedado el Envío. Dependiendo del estado, se 
        /// podrán realizar unas acciones u otras. Solo se devolverá si la operación se 
        /// ha llevado a cabo con éxito.
        /// </summary>
        public string EstadoEnvio { get; private set; }

        /// <summary>
        /// Expediente asociado a la presentación de la declaración. Puede 
        /// utilizarse para el servicio de baja.
        /// </summary>
        public string Expediente { get; private set; }

        /// <summary>
        /// Número total de registros Tipo 2 (no solo del último bloque remitido) que han sido validados 
        /// correctamente e incorporados al envío. Será un numérico con valor cero o positivo. Solo se 
        /// devolverá si la operación se he llevado a cabo con éxito.
        /// </summary>
        public int RegistrosEnviadosCorrectos { get; private set; }

        /// <summary>
        /// Número total de registros Tipo 2 (no solo del último bloque remitido) que presentan 
        /// errores y que no han sido incorporados al envío. Será un numérico con valor cero o 
        /// positivo. Solo se devolverá si la operación se he llevado a cabo con éxito.
        /// </summary>
        public int RegistrosEnviadosErroneos { get; private set; }

        /// <summary>
        /// Número total de registros Tipo 2 del bloque remitido que han sido validados 
        /// correctamente e incorporados al envío. Será un numérico con valor cero o positivo. 
        /// Solo se devolverá si la operación se he llevado a cabo con éxito.
        /// </summary>
        public int RegistrosEnvioCorrectos { get; private set; }

        /// <summary>
        /// Número total de registros Tipo 2 del bloque que presentan errores 
        /// y que no han sido incorporados al envío. Será un numérico con valor 
        /// cero o positivo. Solo se devolverá si la operación se he llevado a 
        /// cabo con éxito.
        /// </summary>
        public int RegistrosEnvioErroneos { get; private set; }


        /// <summary>
        /// Devuelve true si la respuesta de la aeat indica que la
        /// presentación ha sido errónea.
        /// </summary>
        /// <returns>True si errónea y false si correcta.</returns>
        protected override bool CompruebaErronea()
        {
            return _HttpWebResponse.Headers["CODIGO"].Trim() != "0";
        }


        /// <summary>
        /// Realiza las labores necesarias en caso de que la respuesta
        /// se errónea.
        /// </summary>
        protected override void TratarErrores()
        {
            Errores.Add(new RespuestaError(_HttpWebResponse.Headers["MENSAJE"].Trim()));
        }

        /// <summary>
        /// Realiza las labores necesarias en caso de que la respuesta
        /// se satisfactoria.
        /// </summary>
        protected override void TratarExito()
        {

            switch ((_Peticion as PeticionTgvi).Accion) 
            {

                case "InicializarEnvio":
                    IdEnvio = _HttpWebResponse.Headers["IDENVIO"].Trim();
                    SigBloque = _HttpWebResponse.Headers["SIGBLOQUE"].Trim();
                    Cookie = _HttpWebResponse.Headers["Set-Cookie"].Trim();
                    break;

                case "EnviarDatos":
                    IdEnvio = _HttpWebResponse.Headers["IDENVIO"].Trim();
                    EstadoEnvio = _HttpWebResponse.Headers["ESTADO"].Trim();
                    
                    if(EstadoEnvio != "FINALIZADO")
                        SigBloque = _HttpWebResponse.Headers["SIGBLOQUE"].Trim();

                    RegistrosEnviadosCorrectos = Convert.ToInt32(_HttpWebResponse.Headers["TOTALT2OK"].Trim());
                    RegistrosEnviadosErroneos = Convert.ToInt32(_HttpWebResponse.Headers["TOTALT2KO"].Trim());
                    RegistrosEnvioCorrectos = Convert.ToInt32(_HttpWebResponse.Headers["BLOQUET2OK"].Trim());
                    RegistrosEnvioErroneos = Convert.ToInt32(_HttpWebResponse.Headers["BLOQUET2KO"].Trim());

                    if (RegistrosEnviadosErroneos > 0)
                    {
                        Erronea = true;
                        Errores.Add(new RespuestaError($"Existen {RegistrosEnviadosErroneos} registros erróneos en el envío."));
                    }                        

                    break;

                case "PresentarEnvio":
                    IdEnvio = _HttpWebResponse.Headers["IDENVIO"].Trim();
                    CSV = _HttpWebResponse.Headers["CSV"].Trim();
                    Expediente = _HttpWebResponse.Headers["EXPEDIENTE"].Trim();
                    break;

                case "RecuperarErrores":
                    IdEnvio = _HttpWebResponse.Headers["IDENVIO"].Trim();
                    EstadoEnvio = _HttpWebResponse.Headers["ESTADO"].Trim();

                    Erronea = true;
                    Errores.Add(new RespuestaError(_ContenidoTexto)); // Añadimos el fichero devuelto con los registros erróneos.

                    break;

                default:
                    throw new ArgumentException($"'{(_Peticion as PeticionTgvi).Accion}' no es una acción válida.");
            }

        }

        /// <summary>
        /// Prueba la descarga con certificado.
        /// </summary>
        /// <param name="enlace">Url del pdf a descargar.</param>
        /// <returns>Datos binarios de la respuesta.</returns>
        internal override byte[] DescargaPdfEnlace(string enlace) 
        {
            EnlacePdf = enlace;
            DatosPdf = base.DescargaPdfEnlace(EnlacePdf);
            return DatosPdf;
        }

    }
}
