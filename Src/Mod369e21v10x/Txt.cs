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

namespace AeatModelos.Mod369e21v10x
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
            {"000.003", "Discriminante"},
            {"000.004", "Ejercicio de devengo (EEEE)"},
            {"000.005", "Período. (PP)"},
            {"000.006", "Tipo y cierre"},
            {"000.007", "Reservado"},
            {"000.008", "NIF del titular"},
            {"000.009", "Reservado"},
            {"000.010", "Inicio del identificador de modelo y página"},
            {"000.011", "Modelo"},
            {"000.012", "Página"},
            {"000.013", "Fin de identificador de modelo"},
            {"000.014", "Reservado."},
            {"000.015", "Constante </T36900>"},            
            {"X01.001", "Inicio del identificador de modelo y página"},
            {"X01.002", "Modelo"},
            {"X01.003", "Página"},
            {"X01.004", "Fin de identificador de modelo"},
            {"X01.005", "Régimen"},
            {"X01.006", "Categoría"},
            {"X01.007", "Tipo de pago"},
            {"X01.008", "NRC Pago"},
            {"X01.009", "Importe pagado"},
            {"X01.010", "1. Declarante. País"},
            {"X01.011", "1. Declarante. NIF"},
            {"X01.012", "1. Declarante. Número de operador en el régimen (NEUOSS)"},
            {"X01.013", "1. Declarante . Apellidos y nombre o razón social."},
            {"X01.014", "2. Ejercicio y período. Ejercicio"},
            {"X01.015", "2. Ejercicio y período. Tipo de periodo"},
            {"X01.016", "2. Ejercicio y período. Periodo"},
            {"X01.017", "2. Ejercicio y período. Declaración sin actividad"},
            {"Y01.001", "3. Prestaciones de servicios. Código de país/EM de consumo."},
            {"Y01.002", "3. Prestaciones de servicios. Tipo (%) de IVA."},
            {"Y01.003", "3. Prestaciones de servicios. Tipo IVA."},
            {"Y01.004", "3. Prestaciones de servicios. Base imponible (€)."},
            {"Y01.005", "3. Prestaciones de servicios. Cuota IVA (€)."},
            {"X02.001", "Inicio del identificador de modelo y página"},
            {"X02.002", "Modelo"},
            {"X02.003", "Página"},
            {"X02.004", "Fin de identificador de modelo"},
            {"X02.005", "Complementaria"},
            {"Y02.001", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Código País EM de consumo."},
            {"Y02.002", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Ejercicio."},
            {"Y02.003", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Tipo de periodo."},
            {"Y02.004", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Periodo."},
            {"Y02.005", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Cuota IVA corregida (€)."},
            {"X03.001", "Inicio del identificador de modelo y página"},
            {"X03.002", "Modelo"},
            {"X03.003", "Página"},
            {"X03.004", "Fin de identificador de modelo"},
            {"X03.005", "Complementaria"},
            {"X03.006", "Reservado"}
        };


        #endregion

    }
}
