/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2021 Irene Solutions SL
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

using AeatModelos.Comunicaciones;
using System;

namespace AeatModelos
{

    /// <summary>
    /// Representa un registro de modelo que tiene contenido de texto
    /// o constutiye una página del modelo a presentar mediante el 
    /// nuevo sistema de presentación de declaraciones puesto en
    /// marcha para el año 2022.
    /// </summary>
    public class RegistroModPaginaPresBasicaDos : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public RegistroModPaginaPresBasicaDos(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            // Cambia el orden y el número de variables en la presentación telemática si procede.
            if (Convert.ToInt32(Ejercicio) > 2021)
                OrdenVariablesEnvio = new string[9] { "MODELO", "EJERCICIO", "PERIODO", "NRC", "IDI", "F01", "FIR",  "FIRNIF", "FIRNOMBRE" };

        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// Inicia los enlaces de los servicios correspondientes al modelo.
        /// </summary>
        internal override void IniciaEnlaces()
        {

            if (Convert.ToInt32(Ejercicio) > 2021)
                Enlaces = new GestorDeEnlaces(Comunicaciones.Enlaces.PftwPicwPresBasicaDos,
                    Comunicaciones.Enlaces.PftwPicwPresBasicaDosPruebas);
            else
                base.IniciaEnlaces();

        }

        /// <summary>
        /// Obtiene los datos de presentación para la petición de presentación
        /// de un modelo concreto al servicio de presentación de la AEAT.
        /// </summary>
        /// <returns>Datos de presentación para la petición de presentación
        /// de un modelo concreto al servicio de presentación de la AEAT.</returns>
        internal override string DatosPeticionPresentacion()
        {

            if (Convert.ToInt32(Ejercicio) > 2021)
            {

                string[] segmentos = new string[OrdenVariablesEnvio.Length];
                var segmentoIndice = 0;

                foreach (var variable in OrdenVariablesEnvio)
                {
                    var valor = VariablesEnvio[variable];
                    var segmento = string.IsNullOrEmpty(variable) ? valor : $"\"{variable}\":\"{valor}\"";
                    segmentos[segmentoIndice++] = segmento;
                }

                var json = $"{{{string.Join(",", segmentos)}}}";

                return json;

            }
            else
            {
                return base.DatosPeticionPresentacion();
            }

        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Presenta la declaración.
        /// <param name="test">Indica si la presentación se realiza en el entorno en pruebas de la AEAT.</param>
        /// <param name="certRef">Ruta de certificado para la presentación, en caso de que se utilice uno externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// </summary>
        /// <returns>Respuesta a la operación de presentación.</returns>
        public override Respuesta Presentar(bool test = false, string certRef = null, string certClave = null)
        {

            if (!_Confirmado)
                throw new InvalidOperationException(Errores.MostrarMensaje("RegistroMod.003"));

            if (Convert.ToInt32(Ejercicio) > 2021)
                return new PeticionPresBasicaDos(this, test, certRef, certClave, System.Text.Encoding.UTF8).Presentar();
            else
                return base.Presentar(test, certRef, certClave);            

        }

        #endregion

    }
}
