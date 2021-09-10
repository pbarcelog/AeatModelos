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

namespace AeatModelos.Mod369e21v10u
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
            {"U01.001", "Inicio del identificador de modelo y página"},
            {"U01.002", "Modelo"},
            {"U01.003", "Página"},
            {"U01.004", "Fin de identificador de modelo"},
            {"U01.005", "Régimen"},
            {"U01.006", "Categoría"},
            {"U01.007", "Tipo de pago"},
            {"U01.008", "NRC Pago"},
            {"U01.009", "Importe pagado"},
            {"U01.010", "Complementaria"},
            {"U01.011", "1. Declarante. País"},
            {"U01.012", "1. Declarante. NIF"},
            {"U01.013", "1. Declarante . Apellidos y nombre o razón social"},
            {"U01.014", "2. Ejercicio y período. Ejercicio"},
            {"U01.015", "2. Ejercicio y período. Tipo de periodo"},
            {"U01.016", "2. Ejercicio y período. Periodo"},
            {"U01.017", "2. Ejercicio y periodo. Fecha desde"},
            {"U01.018", "2. Ejercicio y período. Fecha hasta"},
            {"U01.019", "2. Ejercicio y período. Declaración sin actividad"},
            {"U01.021", "Reservado"},
            {"U01.022", "Constante '</T36904>'"},
            {"V01.001", "3. Prestaciones de servicios desde el EMID España y desde establecimientos permanentes situados fuera de la UE. Código de país/EM de consumo."},
            {"V01.002", "3. Prestaciones de servicios desde el EMID España y desde establecimientos permanentes situados fuera de la UE. Tipo (%) de IVA."},
            {"V01.003", "3. Prestaciones de servicios desde el EMID España y desde establecimientos permanentes situados fuera de la UE. Tipo IVA."},
            {"V01.004", "3. Prestaciones de servicios desde el EMID España y desde establecimientos permanentes situados fuera de la UE. Base imponible (€)."},
            {"V01.005", "3. Prestaciones de servicios desde el EMID España y desde establecimientos permanentes situados fuera de la UE. Cuota IVA (€)."},
            {"U02.001", "Inicio del identificador de modelo y página"},
            {"U02.002", "Modelo"},
            {"U02.003", "Página"},
            {"U02.004", "Fin de identificador de modelo"},
            {"U02.005", "Complementaria"},
            {"V02.001", "4. Entregas de bienes expedidos o transportados desde EMID España. Código País EM de consumo."},
            {"V02.002", "4. Entregas de bienes expedidos o transportados desde EMID España. Tipo (%) de IVA."},
            {"V02.003", "4. Entregas de bienes expedidos o transportados desde EMID España. Tipo IVA."},
            {"V02.004", "4. Entregas de bienes expedidos o transportados desde EMID España. Base imponible (€)."},
            {"V02.005", "4. Entregas de bienes expedidos o transportados desde EMID España. Cuota IVA (€)."},
            {"U03.001", "Inicio del identificador de modelo y página"},
            {"U03.002", "Modelo"},
            {"U03.003", "Página"},
            {"U03.004", "Fin de identificador de modelo"},
            {"U03.005", "Complementaria"},
            {"V03.001", "5. Prestaciones de servicios desde establecimientos permanentes en otros EM distintos de España. Establecimiento Permanente. Código País."},
            {"V03.002", "5. Prestaciones de servicios desde establecimientos permanentes en otros EM distintos de España. Establecimiento Permanente. NIVA/Otros códigos identificativos."},
            {"V03.003", "5. Prestaciones de servicios desde establecimientos permanentes en otros EM distintos de España. Código País/EM de consumo."},
            {"V03.004", "5. Prestaciones de servicios desde establecimientos permanentes en otros EM distintos de España.Tipo (%) de IVA."},
            {"V03.005", "5. Prestaciones de servicios desde establecimientos permanentes en otros EM distintos de España. Tipo de IVA."},
            {"V03.006", "5. Prestaciones de servicios desde establecimientos permanentes en otros EM distintos de España. Base imponible (€)."},
            {"V03.007", "5. Prestaciones de servicios desde establecimientos permanentes en otros EM distintos de España. Cuota IVA (€)."},
            {"U04.001", "Inicio del identificador de modelo y página"},
            {"U04.002", "Modelo"},
            {"U04.003", "Página"},
            {"U04.004", "Fin de identificador de modelo"},
            {"U04.005", "Complementaria"},
            {"V04.001", "6. Entregas de bienes expedidos o transportados desde otros EM distintos de España. Código País."},
            {"V04.002", "6. Entregas de bienes expedidos o transportados desde otros EM distintos de España. NIVA/Otros códigos identificativos."},
            {"V04.003", "6. Entregas de bienes expedidos o transportados desde otros EM distintos de España. Código País/EM de consumo."},
            {"V04.004", "6. Entregas de bienes expedidos o transportados desde otros EM distintos de España. Tipo (%) de IVA."},
            {"V04.005", "6. Entregas de bienes expedidos o transportados desde otros EM distintos de España. Tipo de IVA."},
            {"V04.006", "6. Entregas de bienes expedidos o transportados desde otros EM distintos de España. Base imponible (€)."},
            {"V04.007", "6. Entregas de bienes expedidos o transportados desde otros EM distintos de España. Cuota IVA (€)."},
            {"U05.001", "Inicio del identificador de modelo y página"},
            {"U05.002", "Modelo"},
            {"U05.003", "Página"},
            {"U05.004", "Fin de identificador de modelo"},
            {"U05.005", "Complementaria"},
            {"V05.001", "7. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Código País EM de consumo."},
            {"V05.002", "7. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Ejercicio."},
            {"V05.003", "7. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Tipo de periodo."},
            {"V05.004", "7. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Tipo de periodo."},
            {"V05.005", "7. Correcciones de declaraciones de períodos anteriores (máx. 3 años). Cuota IVA corregida (€)."},
            {"U06.001", "Inicio del identificador de modelo y página"},
            {"U06.002", "Modelo"},
            {"U06.003", "Página"},
            {"U06.004", "Fin de identificador de modelo"},
            {"U06.005", "Complementaria"},
            {"U06.006", "Reservado"}
        };


        #endregion

    }
}
