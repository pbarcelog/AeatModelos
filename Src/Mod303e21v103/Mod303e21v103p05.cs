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

namespace AeatModelos.Mod303e21v103
{
    /// <summary>
    /// Página 5 modelo 303. Diseño de registro: DR303e21v103.xlsx.
    /// Añade nueva página respecto a la versión anterior.
    /// </summary>
    public class Mod303e21v103p05 : RegistroModPagina
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e21v103p05(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
            string p = "P05";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,    1,    2,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      "<T"        )}, //001
                {++c,    new RegistroCampo(1,    3,    3,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      303,    0   )}, //002
                {++c,    new RegistroCampo(1,    6,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      5000,   0   )}, //003
                {++c,    new RegistroCampo(1,   11,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      ">"         )}, //004

                // Indicador de página complementaria. Blanco (No complementaria) o "C" (Complementaria)
                { ++c,    new RegistroCampo(1,   12,    1,  "A",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "IndicadorPagComplementaria"           )}, //005

                // *** Prorratas - 1 - 
                // Código CNAE [500].
                {++c,    new RegistroCampo(1,   13,    3,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "500"                                  )}, //006
                // Importe de operaciones [501].
                {++c,    new RegistroCampo(1,   16,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "501",                     0,   2, true)}, //007
                // Importe de operaciones con derecho a deducción [502].
                {++c,    new RegistroCampo(1,   33,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "502",                     0,   2, true)}, //008
                // Tipo de prorrata [503].
                {++c,    new RegistroCampo(1,   50,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "503"                                  )}, //009
                // % de prorrata [504].
                {++c,    new RegistroCampo(1,   51,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "504",                     0,   2      )}, //010
                                
                // *** Prorratas - 2 - 
                // Código CNAE [505].
                {++c,    new RegistroCampo(1,   56,    3,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "505"                                  )}, //011
                // Importe de operaciones [506].
                {++c,    new RegistroCampo(1,   59,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "506",                     0,   2, true)}, //012
                // Importe de operaciones con derecho a deducción [507].
                {++c,    new RegistroCampo(1,   76,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "507",                     0,   2, true)}, //013
                // Tipo de prorrata [508].
                {++c,    new RegistroCampo(1,   93,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "508"                                  )}, //014
                // % de prorrata [509].
                {++c,    new RegistroCampo(1,   94,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "509",                     0,   2      )}, //015
                
                // *** Prorratas - 3 - 
                // Código CNAE [510].
                {++c,    new RegistroCampo(1,   99,    3,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "510"                                  )}, //016
                // Importe de operaciones [511].
                {++c,    new RegistroCampo(1,  102,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "511",                     0,   2, true)}, //017
                // Importe de operaciones con derecho a deducción [512].
                {++c,    new RegistroCampo(1,  119,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "512",                     0,   2, true)}, //018
                // Tipo de prorrata [513].
                {++c,    new RegistroCampo(1,  136,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "513"                                  )}, //019
                // % de prorrata [514].
                {++c,    new RegistroCampo(1,  137,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "514",                     0,   2      )}, //020
                
                // *** Prorratas - 4 - 
                // Código CNAE [515].
                {++c,    new RegistroCampo(1,  142,    3,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "515"                                  )}, //021
                // Importe de operaciones [516].
                {++c,    new RegistroCampo(1,  145,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "516",                     0,   2, true)}, //022
                // Importe de operaciones con derecho a deducción [517].
                {++c,    new RegistroCampo(1,  162,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "517",                     0,   2, true)}, //023
                // Tipo de prorrata [518].
                {++c,    new RegistroCampo(1,  179,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "518"                                  )}, //024
                // % de prorrata [519].
                {++c,    new RegistroCampo(1,  180,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "519",                     0,   2      )}, //025
                
                // *** Prorratas - 5 - 
                // Código CNAE [520].
                {++c,    new RegistroCampo(1,  185,    3,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "520"                                  )}, //026
                // Importe de operaciones [521].
                {++c,    new RegistroCampo(1,  188,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "521",                     0,   2, true)}, //027
                // Importe de operaciones con derecho a deducción [522].
                {++c,    new RegistroCampo(1,  205,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "522",                     0,   2, true)}, //028
                // Tipo de prorrata [523].
                {++c,    new RegistroCampo(1,  222,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "523"                                  )}, //029
                // % de prorrata [524].
                {++c,    new RegistroCampo(1,  223,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "524",                     0,   2      )}, //030

                // *** 13. Reg. Deducc. Diferenc.- 1 -
                // IVA ded. Operac. Interiores - Bienes y servicios.
                {++c,    new RegistroCampo(1,  228,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "700",                     0,   2      )}, //031
                {++c,    new RegistroCampo(1,  245,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "701",                     0,   2      )}, //032
                // IVA ded. Operac. Interiores - Bienes inversión.
                {++c,    new RegistroCampo(1,  262,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "702",                     0,   2      )}, //033
                {++c,    new RegistroCampo(1,  279,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "703",                     0,   2      )}, //034
                // IVA ded. Importaciones - Bienes corrientes.
                {++c,    new RegistroCampo(1,  296,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "704",                     0,   2      )}, //035
                {++c,    new RegistroCampo(1,  313,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "705",                     0,   2      )}, //036
                // IVA ded. Importaciones - Bienes inversión.
                {++c,    new RegistroCampo(1,  330,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "706",                     0,   2      )}, //037
                {++c,    new RegistroCampo(1,  347,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "707",                     0,   2      )}, //038
                // IVA ded. Adquisic. intracomun. - Bienes corrientes.
                {++c,    new RegistroCampo(1,  364,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "708",                     0,   2      )}, //039
                {++c,    new RegistroCampo(1,  381,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "709",                     0,   2      )}, //040
                // IVA ded. Adquisic. intracomun. - Bienes inversión.
                {++c,    new RegistroCampo(1,  398,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "710",                     0,   2      )}, //041
                {++c,    new RegistroCampo(1,  415,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "711",                     0,   2      )}, //042
                // Compensac. rég. especial agric./ganad./pesca.
                {++c,    new RegistroCampo(1,  432,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "712",                     0,   2      )}, //043
                {++c,    new RegistroCampo(1,  449,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "713",                     0,   2      )}, //044
                // Rectificación de deducciones.
                {++c,    new RegistroCampo(1,  466,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "714",                     0,   2, true)}, //045
                {++c,    new RegistroCampo(1,  483,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "715",                     0,   2, true)}, //046
                // Regularización de inversiones.
                {++c,    new RegistroCampo(1,  500,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "716",                     0,   2, true)}, //047
                // Suma de deducciones.
                {++c,    new RegistroCampo(1,  517,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "717",                     0,   2, true)}, //048
                
                // *** 13. Reg. Deducc. Diferenc.- 2 -
                // IVA ded. Operac. Interiores - Bienes y servicios.
                {++c,    new RegistroCampo(1,  534,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "718",                     0,   2      )}, //049
                {++c,    new RegistroCampo(1,  551,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "719",                     0,   2      )}, //050
                // IVA ded. Operac. Interiores - Bienes inversión.
                {++c,    new RegistroCampo(1,  568,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "720",                     0,   2      )}, //051
                {++c,    new RegistroCampo(1,  585,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "721",                     0,   2      )}, //052
                // IVA ded. Importaciones - Bienes corrientes.
                {++c,    new RegistroCampo(1,  602,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "722",                     0,   2      )}, //053
                {++c,    new RegistroCampo(1,  619,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "723",                     0,   2      )}, //054
                // IVA ded. Importaciones - Bienes inversión.
                {++c,    new RegistroCampo(1,  636,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "724",                     0,   2      )}, //055
                {++c,    new RegistroCampo(1,  653,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "725",                     0,   2      )}, //056
                // IVA ded. Adquisic. intracomun. - Bienes corrientes.
                {++c,    new RegistroCampo(1,  670,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "726",                     0,   2      )}, //057
                {++c,    new RegistroCampo(1,  687,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "727",                     0,   2      )}, //058
                // IVA ded. Adquisic. intracomun. - Bienes inversión.
                {++c,    new RegistroCampo(1,  704,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "728",                     0,   2      )}, //059
                {++c,    new RegistroCampo(1,  721,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "729",                     0,   2      )}, //060
                // Compensac. rég. especial agric./ganad./pesca.
                {++c,    new RegistroCampo(1,  738,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "730",                     0,   2      )}, //061
                {++c,    new RegistroCampo(1,  755,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "731",                     0,   2      )}, //062
                // Rectificación de deducciones.
                {++c,    new RegistroCampo(1,  772,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "732",                     0,   2, true)}, //063
                {++c,    new RegistroCampo(1,  789,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "733",                     0,   2, true)}, //064
                // Regularización de inversiones.
                {++c,    new RegistroCampo(1,  806,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "734",                     0,   2, true)}, //065
                // Suma de deducciones.
                {++c,    new RegistroCampo(1,  823,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "735",                     0,   2, true)}, //066

                // Reservado AEAT.
                {++c,    new RegistroCampo(1,  840,  672,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //067
                {++c,    new RegistroCampo(1, 1512,   12,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      "</T30305000>"              )}, //068
            };
        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
        }

        #endregion
    }
}
