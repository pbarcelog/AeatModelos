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

namespace AeatModelos.Mod130e15v11
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
            {"P01.012", "Liquidación (3). I. Actividades econ. Estim. Directa - [01] Ingresos computables correspondientes al conjunto …"},
            {"P01.013", "Liquidación (3). I. Actividades econ. Estim. Directa - [02] Gastos fiscalmente deducibles (…)"},
            {"P01.014", "Liquidación (3). I. Actividades econ. Estim. Directa - [03 ]Rendimiento neto ([01] - [02])."},
            {"P01.015", "Liquidación (3). I. Actividades econ. Estim. Directa - [04] 20 por 100 del importe de la casilla [03]."},
            {"P01.016", "Liquidación (3). I. Actividades econ. Estim. Directa - [05] A deducir : De los trim. anteriores, suma de los importes (…)"},
            {"P01.017", "Liquidación (3). I. Actividades econ. Estim. Directa - [06] A deducir: Retenciones e ingresos a cta. soportados (…)"},
            {"P01.018", "Liquidación (3). I. Actividades econ. Estim. Directa - [07] Pago fraccionado previo del trimestre ([04]-[05]-[06])"},
            {"P01.019", "Liquidación (3). II. Actividades agrícolas, ganaderas, etc. - [08] Volumen de ingresos del trimestre (…)"},
            {"P01.020", "Liquidación (3). II. Actividades agrícolas, ganaderas, etc. - [09] 2 por 100 del importe de la casilla [08]"},
            {"P01.021", "Liquidación (3). II. Actividades agrícolas, ganaderas, etc. - [10] A deducir: Retenciones e Ingresos a cuenta (…)"},
            {"P01.022", "Liquidación (3). II. Actividades agrícolas, ganaderas, etc. - [11] Pago fraccionado previo del trimestre (…) ([09]-[10])"},
            {"P01.023", "Liquidación (3). III. Total Liquidación - [12] Suma de pagos fraccionados del trimestre ([07]+[11])"},
            {"P01.024", "Liquidación (3). III. Total Liquidación - [13] A deducir: Minorac. por aplic. de la deducc. art. 110,3 del Reglam. del Impto."},
            {"P01.025", "Liquidación (3). III. Total Liquidación - [14] Diferencia ([12]-[13])"},
            {"P01.026", "Liquidación (3). III. Total Liquidación - [15] A deducir: Resultados negativos ejercicios anteriores"},
            {"P01.027", "Liquidación (3). III. Total Liquidación - [16] A deducir: cantidades al pago adquis. o rehab. vivienda habitual (…)"},
            {"P01.028", "Liquidación (3). III. Total Liquidación - [17] Total ([14]-[15]-[16])"},
            {"P01.029", "Liquidación (3). III. Total Liquidación - [18] A deducir (exclus. complementaria) Resultado anteriores liquidaciones (…)"},
            {"P01.030", "Liquidación (3). III. Total Liquidación - [19] Resultado de la autoliquidación ([17]-[18])"},
            {"P01.031", "Declaración complementaria."},
            {"P01.032", "Número de justificante de la declaración anterior"},
            {"P01.033", "Domiciliación IBAN"},
            {"P01.034", "Reservado AEAT"},
            {"P01.035", "Reservado para la Administración. Sello electronico"},
            {"P01.036", "Indicador de fin de registro."}
        };

        #endregion

    }
}
