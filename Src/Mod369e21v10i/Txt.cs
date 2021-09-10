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

namespace AeatModelos.Mod369e21v10i
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
            {"I01.001", "Inicio del identificador de modelo y página"},
            {"I01.002", "Modelo"},
            {"I01.003", "Página"},
            {"I01.004", "Fin de identificador de modelo"},
            {"I01.005", "Régimen"},
            {"I01.006", "Categoría"},
            {"I01.007", "Tipo de pago"},
            {"I01.008", "NRC Pago"},
            {"I01.009", "Importe pagado"},
            {"I01.010", "Complementaria"},
            {"I01.011", "1. Declarante. País"},            
            {"I01.012", "1. Declarante. NIF"},
            {"I01.013", "1. Declarante. Número de operador en el régimen (NIOSS)"},
            {"I01.014", "1. Declarante . Apellidos y nombre o razón social"},
            {"I01.015", "1. Actúa a través de intermediario"},
            {"I01.016", "1. Nº de identificación del intermediario (NIOSSIn)"},
            {"I01.017", "2. Ejercicio y período. Ejercicio"},
            {"I01.018", "2. Ejercicio y período. Tipo de periodo"},
            {"I01.019", "2. Ejercicio y período. Periodo"},
            {"I01.020", "2. Ejercicio y periodo. Fecha desde"},
            {"I01.021", "2. Ejercicio y período. Fecha hasta"},
            {"I01.022", "2. Ejercicio y período. Declaración sin actividad"},
            {"I01.024", "Reservado"},
            {"I01.025", "Constante '</T36910>'"},
            {"J01.001", "3. Importaciones de bienes de menos de 150 €. Código de país/EM de consumo."},
            {"J01.002", "3. Importaciones de bienes de menos de 150 €. Tipo (%) de IVA."},
            {"J01.003", "3. Importaciones de bienes de menos de 150 €. Tipo IVA."},
            {"J01.004", "3. Importaciones de bienes de menos de 150 €. Base imponible (€)."},
            {"J01.005", "3. Importaciones de bienes de menos de 150 €. Cuota IVA (€)."},
            {"I02.001", "Inicio del identificador de modelo y página"},
            {"I02.002", "Modelo"},
            {"I02.003", "Página"},
            {"I02.004", "Fin de identificador de modelo"},
            {"I02.005", "Complementaria"},
            {"J02.001", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Código País EM de consumo."},
            {"J02.002", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Ejercicio."},
            {"J02.003", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Ejercicio."},
            {"J02.004", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Periodo."},
            {"J02.005", "4. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Cuota IVA corregida (€)."}
        };


        #endregion

    }
}
