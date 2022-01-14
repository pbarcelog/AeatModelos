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


using System.Collections.Generic;

namespace AeatModelos.Mod303e22v100
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

            {"P01.001", "Inicio del identificador de modelo y página."},
            {"P01.002", "Modelo."},
            {"P01.003", "Página."},
            {"P01.004", "Fin de identificador de modelo. "},
            {"P01.005", "Indicador de página complementaria. "},
            {"P01.006", "Tipo Declaración"},
            {"P01.007", "Identificación (1) - NIF"},
            {"P01.008", "Identificación (1) - Apellidos y nombre o Razón social"},
            {"P01.009", "Devengo (2) - Ejercicio"},
            {"P01.010", "Devengo (2) - Período"},
            {"P01.011", "Identificación (1) - Tributación exclusivamente foral. Sujeto pasivo que tributa exclusivamente a una Administración tributaria Foral con IVA a la importación liquidado por la Aduana pendiente de ingreso"},
            {"P01.012", "Identificación (1) - Sujeto pasivo inscrito en el Registro de devolución mensual (art. 30 RIVA)"},
            {"P01.013", "Identificación (1) - Sujeto pasivo que tributa exclusivamente en régimen simplificado"},
            {"P01.014", "Identificación (1) - Autoliquidación conjunta"},
            {"P01.015", "Identificación (1) - Sujeto pasivo acogido al régimen especial del criterio de Caja (art. 163 undecies LIVA)"},
            {"P01.016", "Identificación (1) - Sujeto pasivo destinatario de operaciones acogidas al régimen especial del criterio de caja"},
            {"P01.017", "Identificación (1) - Opción por la aplicación de la prorrata especial (art. 103.Dos.1º LIVA)"},
            {"P01.018", "Identificación (1) - Revocación de la opción por la aplicación de la prorrata especial"},
            {"P01.019", "Identificación (1) - Sujeto pasivo declarado en concurso de acreedores en el presente período de liquidación"},
            {"P01.020", "Identificación (1) - Fecha en que se dictó el auto de declaración de concurso"},
            {"P01.021", "Identificación (1) - Auto de declaración de concurso dictado en el período"},
            {"P01.022", "Identificación (1) - Sujeto pasivo acogido voluntariamente al SII"},
            {"P01.023", "Identificación (1) - Sujeto pasivo exonerado de la Declaración-resumen anual del IVA, modelo 390"},
            {"P01.024", "Identificación (1) - Sujeto pasivo con volumen anual de operaciones distinto de cero (art. 121 LIVA)"},
            {"P01.025", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Base imponible [01]"},
            {"P01.026", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Tipo % [02]"},
            {"P01.027", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Cuota [03]"},
            {"P01.028", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Base imponible [04]"},
            {"P01.029", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Tipo % [05]"},
            {"P01.030", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Cuota [06]"},
            {"P01.031", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Base imponible [07]"},
            {"P01.032", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Tipo % [08]"},
            {"P01.033", "Liquidación (3) - Regimen General - IVA Devengado - Régimen general - Cuota [09]"},
            {"P01.034", "Liquidación (3) - Regimen General - IVA Devengado - Adquisiciones intracomunitarias de bienes y servicios - Base imponible  [10]"},
            {"P01.035", "Liquidación (3) - Regimen General - IVA Devengado - Adquisiciones intracomunitarias de bienes y servicios - Cuota [11]"},
            {"P01.036", "Liquidación (3) - Regimen General - IVA Devengado - Otras operaciones con inversión del sujeto pasivo (excepto. adq. intracom) - Base imponible  [12]"},
            {"P01.037", "Liquidación (3) - Regimen General - IVA Devengado - Otras operaciones con inversión del sujeto pasivo (excepto. adq. intracom) - Cuota [13]"},
            {"P01.038", "Liquidación (3) - Regimen General - IVA Devengado - Modificación bases y cuotas- Base imponible  [14]"},
            {"P01.039", "Liquidación (3) - Regimen General - IVA Devengado - Modificación bases y cuotas - Cuota [15]"},
            {"P01.040", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia- Base imponible [16]"},
            {"P01.041", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia - Tipo % [17]"},
            {"P01.042", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia - Cuota [18]"},
            {"P01.043", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia - Base imponible [19]"},
            {"P01.044", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia - Tipo % [20]"},
            {"P01.045", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia - Cuota [21]"},
            {"P01.046", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia - Base imponible [22]"},
            {"P01.047", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia - Tipo % [23]"},
            {"P01.048", "Liquidación (3) - Regimen General - IVA Devengado - Recargo equivalencia - Cuota [24]"},
            {"P01.049", "Liquidación (3) - Regimen General - IVA Devengado - Modificaciones bases y cuotas del recargo de equivalencia - Base imponible [25]"},
            {"P01.050", "Liquidación (3) - Regimen General - IVA Devengado - Modificaciones bases y cuotas del recargo de equivalencia - Cuota [26]"},
            {"P01.051", "Liquidación (3) - Regimen General - IVA Devengado - Total cuota devengada ( [03] + [06] + [09] + [11] + [13] + [15] + [18] + [21] + [24] + [26]) [27]"},
            {"P01.052", "Liquidación (3) - Regimen General - IVA Deducible - Por cuotas soportadas en operaciones interiores corrientes - Base [28]"},
            {"P01.053", "Liquidación (3) - Regimen General - IVA Deducible - Por cuotas soportadas en operaciones interiores corrientes - Cuota [29]"},
            {"P01.054", "Liquidación (3) - Regimen General - IVA Deducible - Por cuotas soportadas en operaciones interiores con bienes de inversión - Base [30] "},
            {"P01.055", "Liquidación (3) - Regimen General - IVA Deducible - Por cuotas soportadas en operaciones interiores con bienes de inversión - Cuota [31] "},
            {"P01.056", "Liquidación (3) - Regimen General - IVA Deducible - Por cuotas soportadas en las importaciones de bienes corrientes - Base [32]"},
            {"P01.057", "Liquidación (3) - Regimen General - IVA Deducible - Por cuotas soportadas en las importaciones de bienes corrientes - Cuota [33]"},
            {"P01.058", "Liquidación (3) - Regimen General - IVA Deducible - Por cuotas soportadas en las importaciones de bienes de inversión - Base [34]"},
            {"P01.059", "Liquidación (3) - Regimen General - IVA Deducible - Por cuotas soportadas en las importaciones de bienes de inversión - Cuota [35]"},
            {"P01.060", "Liquidación (3) - Regimen General - IVA Deducible - En adquisiciones intracomunitarias de bienes y servicios corrientes - Base [36]"},
            {"P01.061", "Liquidación (3) - Regimen General - IVA Deducible - En adquisiciones intracomunitarias de bienes y servicios corrientes - Cuota [37]"},
            {"P01.062", "Liquidación (3) - Regimen General - IVA Deducible - En adquisiciones intracomunitarias de bienes de inversión - Base [38]"},
            {"P01.063", "Liquidación (3) - Regimen General - IVA Deducible - En adquisiciones intracomunitarias de bienes de inversión - Cuota [39]"},
            {"P01.064", "Liquidación (3) - Regimen General - IVA Deducible - Rectificación de deducciones - Base [40]"},
            {"P01.065", "Liquidación (3) - Regimen General - IVA Deducible - Rectificación de deducciones - Cuota [41]"},
            {"P01.066", "Liquidación (3) - Regimen General - IVA Deducible - Compensaciones Régimen Especial A.G. y P. - Cuota [42]"},
            {"P01.067", "Liquidación (3) - Regimen General - IVA Deducible - Regularización inversiones - Cuota [43]"},
            {"P01.068", "Liquidación (3) - Regimen General - IVA Deducible - Regularización por aplicación del porcentaje definitivo de prorrata - Cuota [44]"},
            {"P01.069", "Liquidación (3) - Regimen General - IVA Deducible - Total a deducir ( [29] + [31] + [33] + [35] + [37] + [39] + [41] + [42] + [43] + [44] ) - Cuota [45]"},
            {"P01.070", "Liquidación (3) - Regimen General - IVA Deducible - Resultado régimen general ( [27] - [45] ) - Cuota [46]"},
            {"P01.071", "Reservado para la AEAT"},
            {"P01.072", "Reservado para la AEAT - Sello electrónico reservado para la AEAT "},
            {"P01.073", "Indicador de fin de registro"},

            {"P03.001", "Inicio del identificador de modelo y página."},
            {"P03.002", "Modelo."},
            {"P03.003", "Página."},
            {"P03.004", "Fin de identificador de modelo. "},
            {"P03.005", "Información adicional - Entregas intracomunitarias de bienes y servicios [59]"},
            {"P03.006", "Información adicional - Exportaciones y operaciones asimiladas [60]"},
            {"P03.007", "Operaciones no sujetas por reglas de localización (excepto las incluidas en la casilla 123) [120]"},
            {"P03.008", "Operaciones sujetas con inversión del sujeto pasivo [122]"},
            {"P03.009", "OSS. Operaciones no sujetas por reglas de localización acogidas a la OSS [123]"},
            {"P03.010", "OSS. Operaciones sujetas y acogidas a la OSS [124]"},
            {"P03.011", "Información adicional - Exclusivamente para operaciones de entrega de bienes y prestaciones de servicios a las que resulte de aplicación el régimen especial del criterio de Caja. Importes devengados en período de liquidación según art. 75 LIVA. - Base Imponible [62]"},
            {"P03.012", "Información adicional - Exclusivamente para operaciones de entrega de bienes y prestaciones de servicios a las que resulte de aplicación el régimen especial del criterio de Caja. Importes devengados en período de liquidación según art. 75 LIVA. - Cuota [63]"},            
            {"P03.013", "Información adicional - Exclusivamente para operaciones de entrega de bienes y prestaciones de servicios a las que resulte de aplicación el régimen especial del criterio de Caja. Cuotas de IVA soportados en operaciones que tributen por el régimen especial del criterio de caja conforme a la regla general de devengo contenida en el artículo 75 LIVA. - Base Imponible [74]"},
            {"P03.014", "Información adicional - Exclusivamente para operaciones de entrega de bienes y prestaciones de servicios a las que resulte de aplicación el régimen especial del criterio de Caja. Cuotas totales de IVA soportados en operaciones que tributen por el régimen especial del criterio de caja conforme a la regla general de devengo contenida en el artículo 75 de LIVA. - Cuota [75]"},
            {"P03.015", "Resultado - Regularización cuotas art. 80.cinco.5ª LIVA  [76]"},
            {"P03.016", "Resultado - Suma de resultados ( [46] + [58] + [76] ) [64]"},
            {"P03.017", "Resultado - % Atribuible a la Administración del Estado [65]"},
            {"P03.018", "Resultado - Atribuible a la Administración del Estado [66]"},
            {"P03.019", "Resultado - IVA a la importación liquidado por la Aduana pendiente de ingreso  [77]"},
            {"P03.020", "Resultado - Cuotas a compensar pendientes de periodos anteriores [110]"},
            {"P03.021", "Cuotas a compensar de periodos anteriores aplicadas en este periodo [78]"},
            {"P03.022", "Cuotas a compensar de periodos previos pendientes para periodos posteriores ([110] - [78]) [87]"},
            {"P03.023", "Resultado - Exclusivamente para sujetos pasivos que tributan conjuntamente a la Administración del Estado y a las Diputaciones Forales Resultado de la regularización anual [68]"},
            {"P03.024", "Resultado - Resultado ( [66] + [77] - [78] + [68] ) [69]"},
            {"P03.025", "Resultado - A deducir [70]"},
            {"P03.026", "Resultado - Resultado de la liquidación ( [69] - [70] ) [71]"},
            {"P03.027", "Declaración complementaria"},
            {"P03.028", "Número justificante declaración anterior"},
            {"P03.029", "Declaración Sin actividad"},
            {"P03.030", "Devolución. SWIFT-BIC"},
            {"P03.031", "Domiciliación/Devolución - IBAN "},
            {"P03.032", "Reservado para la AEAT"},
            {"P03.033", "Devolución - Banco/Bank name"},
            {"P03.034", "Devolución - Dirección del Banco/ Bank address"},
            {"P03.035", "Devolución - Ciudad/City"},
            {"P03.036", "Devolución - Código País/Country code"},
            {"P03.037", "Devolución - Marca SEPA"},
            {"P03.038", "Reservado para la AEAT"},
            {"P03.039", "Indicador de fin de registro"},


            {"P04.001", "Inicio del identificador de modelo y página."},
            {"P04.002", "Modelo."},
            {"P04.003", "Página."},
            {"P04.004", "Fin de identificador de modelo. "},
            {"P04.005", "Indicador de página complementaria. Blanco (No complementaria) o 'C' (Complementaria)"},
            {"P04.006", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: B - Clave - Principal"},
            {"P04.007", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: C - Epígrafe IAE - Principal"},
            {"P04.008", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: B - Clave - Otras - 1ª"},
            {"P04.009", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: C - Epígrafe IAE - Otras - 1ª"},
            {"P04.010", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: B - Clave - Otras - 2ª"},
            {"P04.011", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: C - Epígrafe IAE - Otras - 2ª"},
            {"P04.012", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: B - Clave - Otras - 3ª"},
            {"P04.013", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: C - Epígrafe IAE - Otras - 3ª"},
            {"P04.014", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: B - Clave - Otras - 4ª"},
            {"P04.015", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: C - Epígrafe IAE - Otras - 4ª"},
            {"P04.016", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: B - Clave - Otras - 5ª"},
            {"P04.017", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: C - Epígrafe IAE - Otras - 5ª"},
            {"P04.018", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA: D - Marque si ha efectuado operaciones por las que tenga obligación de presentar la declaración anual de operaciones con terceras personas."},
            {"P04.019", "Información de la tributación por razón de territorio: Álava [89]"},
            {"P04.020", "Información de la tributación por razón de territorio: Guipuzcoa [90]"},
            {"P04.021", "Información de la tributación por razón de territorio: Vizcaya [91]"},
            {"P04.022", "Información de la tributación por razón de territorio: Navarra [92]"},
            {"P04.023", "Información de la tributación por razón de territorio: Territorio común [107]"},
            {"P04.024", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones en régimen general [80]"},
            {"P04.025", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones en régimen especial del criterio de caja conforme art. 75 LIVA [81]"},
            {"P04.026", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Entregas intracomunitarias de bienes y servicios [93]"},
            {"P04.027", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Exportaciones y otras operaciones exentas con derecho a deducción [94]"},
            {"P04.028", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones exentas sin derecho a deducción [83]"},
            {"P04.029", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones no sujetas por reglas de localización o con inversión del sujeto pasivo [84]"},
            {"P04.030", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Entregas de bienes objeto de instalación o montaje en otros Estados miembros [85]"},
            {"P04.031", "Reservado para la AEAT"},
            {"P04.032", "Reservado para la AEAT"},
            {"P04.033", "Reservado para la AEAT"},
            {"P04.034", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones en régimen simplificado [86]"},
            {"P04.035", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones en régimen especial de la agricultura, ganadería y pesca [95]"},
            {"P04.036", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones realizadas por sujetos pasivos acogidos al régimen especial del recargo de equivalencia [96]"},
            {"P04.037", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones en Régimen especial de bienes usados, objetos de arte, antigüedades y objetos de colección [97]"},
            {"P04.038", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Operaciones en régimen especial de Agencias de Viajes [98]"},
            {"P04.039", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Entregas de bienes inmuebles no habituales, operaciones financieras y relativas al oro de inversión no habituales [79]"},
            {"P04.040", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Entregas de bienes de inversión [99]"},
            {"P04.041", "Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA - Operaciones realizadas en el ejercicio - Total volumen de operaciones ([80]+[81]+[93]+[94]+[83]+[84]+[85]+[86]+[95]+[96]+[97]+[98]-[79]-[99]) [88]"},
            {"P04.042", "Reservado para la AEAT"},
            {"P04.043", "Indicador de fin de registro"},

            {"P05.001", "Inicio del identificador de modelo y página."},
            {"P05.002", "Modelo."},
            {"P05.003", "Página."},
            {"P05.004", "Fin de identificador de modelo. "},
            {"P05.005", "Indicador de página complementaria. Blanco (No complementaria) o 'C' (Complementaria)"},
            {"P05.006", "Prorratas - 1 - Código CNAE [500]"},
            {"P05.007", "Prorratas - 1 - Importe de operaciones [501]"},
            {"P05.008", "Prorratas - 1 - Importe de operaciones con derecho a deducción [502]"},
            {"P05.009", "Prorratas - 1 - Tipo de prorrata [503]"},
            {"P05.010", "Prorratas - 1 - % de prorrata [504]"},
            {"P05.011", "Prorratas - 2 - Código CNAE [505]"},
            {"P05.012", "Prorratas - 2 - Importe de operaciones [506]"},
            {"P05.013", "Prorratas - 2 - Importe de operaciones con derecho a deducción [507]"},
            {"P05.014", "Prorratas - 2 - Tipo de prorrata [508]"},
            {"P05.015", "Prorratas - 2 - % de prorrata [509]"},
            {"P05.016", "Prorratas - 3 - Código CNAE [510]"},
            {"P05.017", "Prorratas - 3 - Importe de operaciones [511]"},
            {"P05.018", "Prorratas - 3 - Importe de operaciones con derecho a deducción [512]"},
            {"P05.019", "Prorratas - 3 - Tipo de prorrata [513]"},
            {"P05.020", "Prorratas - 3 - % de prorrata [514]"},
            {"P05.021", "Prorratas - 4 - Código CNAE [515]"},
            {"P05.022", "Prorratas - 4 - Importe de operaciones [516]"},
            {"P05.023", "Prorratas - 4 - Importe de operaciones con derecho a deducción [517]"},
            {"P05.024", "Prorratas - 4 - Tipo de prorrata [518]"},
            {"P05.025", "Prorratas - 4 - % de prorrata [519]"},
            {"P05.026", "Prorratas - 5 - Código CNAE [520]"},
            {"P05.027", "Prorratas - 5 - Importe de operaciones [521]"},
            {"P05.028", "Prorratas - 5 - Importe de operaciones con derecho a deducción [522]"},
            {"P05.029", "Prorratas - 5 - Tipo de prorrata [523]"},
            {"P05.030", "Prorratas - 5 - % de prorrata [524]"},
            {"P05.031", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Operac. Interiores - Bienes y servic. - Base imponible [700]"},
            {"P05.032", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Operac. Interiores - Bienes y servic. - Cuota deducible [701]"},
            {"P05.033", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Operac. Interiores - Bienes inversión - Base imponible [702]"},
            {"P05.034", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Operac. Interiores - Bienes inversión - Cuota deducible [703]"},
            {"P05.035", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Importaciones - Bienes corrientes - Base imponible [704]"},
            {"P05.036", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Importaciones - Bienes corrientes - Cuota deducible [705]"},
            {"P05.037", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Importaciones - Bienes inversión - Base imponible [706]"},
            {"P05.038", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Importaciones - Bienes inversión - Cuota deducible [707]"},
            {"P05.039", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Adquisic. intracomun. - Bienes corrientes - Base imponible [708]"},
            {"P05.040", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Adquisic. intracomun.  - Bienes corrientes - Cuota deducible [709]"},
            {"P05.041", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Adquisic. intracomun. - Bienes inversión - Base imponible [710]"},
            {"P05.042", "13. Reg. Deducc. Diferenc.- 1 - IVA ded. Adquisic. intracomun. - Bienes inversión - Cuota deducible [711]"},
            {"P05.043", "13. Reg. Deducc. Diferenc.- 1 - Compensac. rég. especial agric./ganad./pesca - Base impon. [712] "},
            {"P05.044", "13. Reg. Deducc. Diferenc.- 1 - Compensac. rég. especial agric./ganad./pesca - Cuota deduc. [713] "},
            {"P05.045", "13. Reg. Deducc. Diferenc.- 1 - Rectificación de deducciones - Base impon.  [714]"},
            {"P05.046", "13. Reg. Deducc. Diferenc.- 1 - Rectificación de deducciones - Cuota deduc. [715]"},
            {"P05.047", "13. Reg. Deducc. Diferenc.- 1 - Regularización de inversiones [716]"},
            {"P05.048", "13. Reg. Deducc. Diferenc.- 1 - Suma de deducciones [717]"},
            {"P05.049", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Operac. Interiores - Bienes y servic. - Base imponible [718]"},
            {"P05.050", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Operac. Interiores - Bienes y servic. - Cuota deducible [719]"},
            {"P05.051", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Operac. Interiores - Bienes inversión - Base imponible [720]"},
            {"P05.052", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Operac. Interiores - Bienes inversión - Cuota deducible [721]"},
            {"P05.053", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Importaciones - Bienes corrientes - Base imponible [722]"},
            {"P05.054", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Importaciones - Bienes corrientes - Cuota deducible [723]"},
            {"P05.055", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Importaciones - Bienes inversión - Base imponible [724]"},
            {"P05.056", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Importaciones - Bienes inversión - Cuota deducible [725]"},
            {"P05.057", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Adquisic. intracomun. - Bienes corrientes - Base imponible [726]"},
            {"P05.058", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Adquisic. intracomun.  - Bienes corrientes - Cuota deducible [727]"},
            {"P05.059", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Adquisic. intracomun. - Bienes inversión - Base imponible [728]"},
            {"P05.060", "13. Reg. Deducc. Diferenc.- 2 - IVA ded. Adquisic. intracomun. - Bienes inversión - Cuota deducible [729]"},
            {"P05.061", "13. Reg. Deducc. Diferenc.- 2 - Compensac. rég. especial agric./ganad./pesca - Base impon. [730] "},
            {"P05.062", "13. Reg. Deducc. Diferenc.- 2 - Compensac. rég. especial agric./ganad./pesca - Cuota deduc. [731] "},
            {"P05.063", "13. Reg. Deducc. Diferenc.- 2 - Rectificación de deducciones - Base impon.  [732]"},
            {"P05.064", "13. Reg. Deducc. Diferenc.- 2 - Rectificación de deducciones - Cuota deduc. [733]"},
            {"P05.065", "13. Reg. Deducc. Diferenc.- 2 - Regularización de inversiones [734]"},
            {"P05.066", "13. Reg. Deducc. Diferenc.- 2 - Suma de deducciones [735]"},
            {"P05.067", "Reservado para la AEAT"},
            {"P05.068", "Indicador de fin de registro"},
        };

        #endregion

    }


}
