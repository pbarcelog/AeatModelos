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

namespace AeatModelos.Mod193e2019v00
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
            {"000.014", "Base retenciones e ingresos a cuenta"},
            {"000.015", "Retenciones e ingresos a cuenta"},
            {"000.016", "Retenciones e ingresos a cuenta ingresados"},
            {"000.017", "Blancos ---------"},
            {"000.018", "Gastos art 26.1.a) Ley 35/2006"},
            {"000.019", "Naturaleza del declarante"},
            {"000.020", "Blancos ---------"},
            {"000.021", "Sello electrónico"},

            {"P01.001", "Tipo de registro"},
            {"P01.002", "Modelo de la declaración"},
            {"P01.003", "Ejercicio"},
            {"P01.004", "NIF del declarante"},
            {"P01.005", "NIF del perceptor"},
            {"P01.006", "NIF del representante legal"},
            {"P01.007", "Apellidos y Nombre/Razón social/Denominación del perceptor"},
            {"P01.008", "Pago a un mediador"},
            {"P01.009", "Código de provincia"},
            {"P01.010", "Clave código"},
            {"P01.011", "Código emisor"},
            {"P01.012", "Clave de percepción"},
            {"P01.013", "Naturaleza"},
            {"P01.014", "Pago"},
            {"P01.015", "Tipo código"},
            {"P01.016", "Código cuenta valores / número operación préstamo"},
            {"P01.017", "Pendiente"},
            {"P01.018", "Ejercicio devengo"},
            {"P01.019", "Tipo de percepción"},
            {"P01.020", "Importe de percepciones / remuneración al prestamista"},
            {"P01.021", "Blancos ---------"},
            {"P01.022", "Importe reducciones"},
            {"P01.023", "Base retenciones e ingresos a cuenta"},
            {"P01.024", "% retención"},
            {"P01.025", "Retenciones e ingresos a cuenta"},
            {"P01.026", "Penalizaciones"},
            {"P01.027", "Blancos ---------"},
            {"P01.028", "Naturaleza del declarante"},
            {"P01.029", "Fecha de inicio del préstamo"},
            {"P01.030", "Fecha de vencimiento del préstamo"},
            {"P01.031", "Compensaciones"},
            {"P01.032", "Garantías"},
            {"P01.033", "Blancos ---------"},

            {"P02.001", "Tipo de registro"},
            {"P02.002", "Modelo de la declaración"},
            {"P02.003", "Ejercicio"},
            {"P02.004", "NIF del declarante"},
            {"P02.005", "NIF del contribuyente"},
            {"P02.006", "NIF del representante legal"},
            {"P02.007", "Apellidos y Nombre/Razón social/Denominación del contribuyente"},
            {"P02.008", "Blancos ---------"},
            {"P02.009", "Importe de gastos"},
            {"P02.010", "Blancos ---------"},
        };

        #endregion
    }
}
