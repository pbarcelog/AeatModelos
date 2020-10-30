/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2020 Irene Solutions SL
    Autores: Manuel Diago García, Juan Bautista García Traver.

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

using System.Collections.Generic;

namespace AeatModelos.Mod180e14v00
{
    /// <summary>
    /// Descripciones de campos.
    /// </summary>
    public class Txt
    {
        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Diccionario con las descripciones de campo
        /// según clave (página.numcampo).
        /// </summary>
        public static Dictionary<string, string> Den = new Dictionary<string, string>() 
        {
            {"000.001", "Tipo de registro"},
            {"000.002", "Modelo de la declaración"},
            {"000.003", "Ejercicio"},
            {"000.004", "NIF del declarante"},
            {"000.005", "Apellidos y Nombre/Razón social"},
            {"000.006", "Tipo de soporte"},
            {"000.007", "Persona con quien relacionarse - Teléfono"},
            {"000.008", "Persona con quien relacionarse - Apellidos y Nombre"},
            {"000.009", "Número identificativo de la declaración"},
            {"000.010", "Declaración complementaria o sustitutiva - Declaración complementaria"},
            {"000.011", "Declaración complementaria o sustitutiva - Declaración sustitutiva"},
            {"000.012", "Número identificativo de la declaración anterior"},
            {"000.013", "Número total de perceptores"},
            {"000.014", "Base retenciones e ingresos a cuenta. Signo negativo"},
            {"000.015", "Base retenciones e ingresos a cuenta"},
            {"000.016", "Retenciones e ingresos a cuenta"},
            {"000.017", "Blancos ---------"},
            {"000.018", "Sello electrónico"},

            {"P01.001", "Tipo de registro"},
            {"P01.002", "Modelo de la declaración"},
            {"P01.003", "Ejercicio"},
            {"P01.004", "NIF del declarante"},
            {"P01.005", "NIF del perceptor"},
            {"P01.006", "NIF del representante legal"},
            {"P01.007", "Apellidos y Nombre/Razón social/Denominación del perceptor"},
            {"P01.008", "Código provincia"},
            {"P01.009", "Modalidad"},
            {"P01.010", "Base retenciones e ingresos a cuenta. Signo negativo"},
            {"P01.011", "Base retenciones e ingresos a cuenta"},
            {"P01.012", "% Retención"},
            {"P01.013", "Retenciones e ingresos a cuenta"},
            {"P01.014", "Ejercicio devengo"},
            {"P01.015", "Situación del inmueble"},
            {"P01.016", "Referencia catastral"},
            {"P01.017", "Dirección del inmueble - Tipo de vía"},
            {"P01.018", "Dirección del inmueble - Nombre vía pública"},
            {"P01.019", "Dirección del inmueble - Tipo de numeración"},
            {"P01.020", "Dirección del inmueble - Número de casa"},
            {"P01.021", "Dirección del inmueble - Calificador del número"},
            {"P01.022", "Dirección del inmueble - Bloque"},
            {"P01.023", "Dirección del inmueble - Portal"},
            {"P01.024", "Dirección del inmueble - Escalera"},
            {"P01.025", "Dirección del inmueble - Planta o piso"},
            {"P01.026", "Dirección del inmueble - Puerta"},
            {"P01.027", "Dirección del inmueble - Complemento"},
            {"P01.028", "Dirección del inmueble - Localidad o población"},
            {"P01.029", "Dirección del inmueble - Municipio"},
            {"P01.030", "Dirección del inmueble - Código de municipio"},
            {"P01.031", "Dirección del inmueble - Código de provincia"},
            {"P01.032", "Dirección del inmueble - Código postal"},
            {"P01.033", "Blancos ---------"},
        };

        #endregion
    }
}
