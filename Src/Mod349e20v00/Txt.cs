/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2021 Irene Solutions SL
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

using System.Collections.Generic;

namespace AeatModelos.Mod349e20v00
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
            {"000.006", "Blancos ---------"},
            {"000.007", "Persona con quien relacionarse - Teléfono"},
            {"000.008", "Persona con quien relacionarse - Apellidos y Nombre"},
            {"000.009", "Número identificativo de la declaración"},
            {"000.010", "Declaración complementaria o sustitutiva - Declaración complementaria"},
            {"000.011", "Declaración complementaria o sustitutiva - Declaración sustitutiva"},
            {"000.012", "Número identificativo de la declaración anterior"},
            {"000.013", "Periodo"},
            {"000.014", "Número total de operadores intracomunitarios"},
            {"000.015", "Importe de las operaciones intracomunitarias"},
            {"000.016", "Número total de operadores intracomunitarios con rectificaciones"},
            {"000.017", "Importe de las rectificaciones"},
            {"000.018", "Indicador cambio periodicidad en la obligación de declarar"},
            {"000.019", "Blancos ---------"},
            {"000.020", "NIF del representante legal"},
            {"000.021", "Blancos ---------"},

            {"P01.001", "Tipo de registro"},
            {"P01.002", "Modelo de la declaración"},
            {"P01.003", "Ejercicio"},
            {"P01.004", "NIF del declarante"},
            {"P01.005", "Blancos ---------"},
            {"P01.006", "NIF operador intracomunitario"},
            {"P01.007", "Apellidos y Nombre/Razón social/Denominación del operador intracomunitario"},
            {"P01.008", "Clave operación"},
            {"P01.009", "Base imponible o importe"},
            {"P01.010", "Blancos ---------"},
            {"P01.011", "NIF empresario o profesional destinatario final sustituto"},
            {"P01.012", "Apellidos y Nombre/Razón social/Denominación del sujeto pasivo sustituto"},
            {"P01.013", "Blancos ---------"},

            {"P02.001", "Tipo de registro"},
            {"P02.002", "Modelo de la declaración"},
            {"P02.003", "Ejercicio"},
            {"P02.004", "NIF del declarante"},
            {"P02.005", "Blancos ---------"},
            {"P02.006", "NIF operador intracomunitario"},
            {"P02.007", "Apellidos y Nombre/Razón social/Denominación del operador intracomunitario"},
            {"P02.008", "Clave operación"},
            {"P02.009", "Blancos ---------"},
            {"P02.010", "Rectificaciones - Ejercicio"},
            {"P02.011", "Rectificaciones - Periodo"},
            {"P02.012", "Base imponible o importes rectificados"},
            {"P02.013", "Base imponible declarada anteriormente"},
            {"P02.014", "NIF empresario o profesional destinatario final sustituto"},
            {"P02.015", "Apellidos y Nombre/Razón social/Denominación del sujeto pasivo sustituto"},
            {"P02.016", "Blancos ---------"},
        };

        #endregion
    }
}
