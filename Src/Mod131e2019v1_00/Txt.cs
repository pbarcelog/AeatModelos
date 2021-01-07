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

using System.Collections.Generic;

namespace AeatModelos.Mod131e2019v1_00
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
        public static Dictionary<string, string> Den = new Dictionary<string, string>() {
            {"000.001", "Constante."},
            {"000.002", "Modelo"},
            {"000.003", "Constante"},
            {"000.004", "Ejercicio de devengo (EEEE)"},
            {"000.005", "Período. (PP)"},
            {"000.006", "Constante"},
            {"000.007", "Constante"},
            {"000.008", "Reservado para la Administración. Rellenar con blancos"},
            {"000.009", "Versión del Programa (Nota 1)"},
            {"000.010", "Reservado para la Administración. Rellenar con blancos"},
            {"000.011", "NIF Empresa Desarrollo (Nota 1)"},
            {"000.012", "Reservado para la Administración. Rellenar con blancos"},
            {"000.013", "Constante"},
            {"000.015", "Constante. </T+ modelo+discriminante+Ejercicio+periodo+Tipo+>"},
            {"000.016", "Fin de Registro. Constante CRLF( Hexadecimal 0D0A, Decimal 1310)"},
            {"P01.001", "Inicio del identificador de modelo y página"},
            {"P01.002", "Modelo"},
            {"P01.003", "Página"},
            {"P01.004", "Fin de identificador de modelo"},
            {"P01.005", "Indicador de página complementaria"},
            {"P01.006", "Tipo de declaración"},
            {"P01.007", "Declarante (1). Sujeto pasivo. NIF"},
            {"P01.008", "Declarante (1). Sujeto pasivo. Apellidos"},
            {"P01.009", "Declarante (1). Sujeto pasivo. Nombre"},
            {"P01.010", "Devengo (2). Ejercicio"},
            {"P01.011", "Devengo (2). Periodo"},
            {"P01.012", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Actividad (epígrafe I.A.E.) - 1"},
            {"P01.013", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Rdto. neto actividad - 1"},
            {"P01.014", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Porcentaje aplicable 1"},
            {"P01.015", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Resultado aplicación porcentaje a cada actividad - 1"},
            {"P01.016", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Actividad (epígrafe I.A.E.) - 2"},
            {"P01.017", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Rdto. neto actividad - 2"},
            {"P01.018", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Porcentaje aplicable 2"},
            {"P01.019", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Resultado aplicación porcentaje a cada actividad - 2"},
            {"P01.020", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Actividad (epígrafe I.A.E.) - 3"},
            {"P01.021", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Rdto. neto actividad - 3"},
            {"P01.022", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Porcentaje aplicable 3"},
            {"P01.023", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Resultado aplicación porcentaje a cada actividad - 3"},
            {"P01.024", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Actividad (epígrafe I.A.E.) - 4"},
            {"P01.025", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Rdto. neto actividad - 4"},
            {"P01.026", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Porcentaje aplicable 4"},
            {"P01.027", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Resultado aplicación porcentaje a cada actividad - 4"},
            {"P01.028", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Actividad (epígrafe I.A.E.) - 5"},
            {"P01.029", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Rdto. neto actividad - 5"},
            {"P01.030", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Porcentaje aplicable 5"},
            {"P01.031", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Resultado aplicación porcentaje a cada actividad - 5"},
            {"P01.032", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Suma de rendimientos netos [01]"},
            {"P01.033", "Liquidación (3) - I. Activ. económicas estimac. objetiva - Pago fraccionado previo: suma de resultados [02]"},
            {"P01.034", "Liquidación (3) - II. Activ. económicas estimac. objetiva distintas - Volumen de ventas o ingresos [03]"},
            {"P01.035", "Liquidación (3) - II. Activ. económicas estimac. objetiva distintas - Pago fraccionado previo [04]"},
            {"P01.036", "Liquidación (3) - III. Activ. agrícolas, ganaderas estimac. objet. - Volumen ingresos trimestre [05]"},
            {"P01.037", "Liquidación (3) - III. Activ. agrícolas, ganaderas estimac. objet. - Pago fraccionado previo del trimestre [06]"},
            {"P01.038", "Liquidación (3) - IV. Total liquidación - Suma de los pagos fraccionados previos del trimestre [07]"},
            {"P01.039", "Liquidación (3) - IV. Total liquidación - A deducir: retenciones e ingresos a cuenta [08]"},
            {"P01.040", "Liquidación (3) - IV. Total liquidación - Minoración por aplicación de la deducción. Artículo 110.3.c de la Ley [09]"},
            {"P01.041", "Liquidación (3) - IV. Total liquidación - Diferencia [10]"},
            {"P01.042", "Liquidación (3) - IV. Total liquidación - A deducir: Resultados negativos de trimestres anteriores [11]"},
            {"P01.043", "Liquidación (3) - IV. Total liquidación - Pago de préstamos para la adquisición de vivienda habitual [12]"},
            {"P01.044", "Liquidación (3) - IV. Total liquidación - Total [13]"},
            {"P01.045", "Liquidación (3) - IV. Total liquidación - A deducir - Resultado a ingresar de las anteriores declaraciones [14]"},
            {"P01.046", "Liquidación (3) - IV. Total liquidación - Resultado de la declaración [15]"},
            {"P01.047", "Domiciliación IBAN"},
            {"P01.048", "Declaración complementaria."},
            {"P01.049", "Número de justificante de la declaración anterior"},
            {"P01.050", "Reservado AEAT"},
            {"P01.051", "Reservado para la Administración. Sello electronico"},
            {"P01.052", "Indicador de fin de registro."}
        };


        #endregion

    }
}
