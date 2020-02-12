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

namespace AeatModelos.Mod390e2019v100
{
    /// <summary>
    /// Página 3 modelo 390.
    /// </summary>
    public class Mod390e2019v100p03 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p03(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "003";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(3,      1,     2,     "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,                  "<T"        )}, //001
                {++c, new RegistroCampo(3,      3,     3,     "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,                  390,    0   )}, //002
                {++c, new RegistroCampo(3,      6,     5,     "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,                  3000,   0   )}, //003
                {++c, new RegistroCampo(3,     11,     1,     "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,                  ">"         )}, //004
                {++c, new RegistroCampo(3,     12,     1,     "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                               )}, //005
                {++c, new RegistroCampo(3,     13,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "190",     null,       2,      true)}, //006
                {++c, new RegistroCampo(3,     30,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "191",     null,       2,      true)}, //007
                {++c, new RegistroCampo(3,     47,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "603",     null,       2,      true)}, //008
                {++c, new RegistroCampo(3,     64,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "604",     null,       2,      true)}, //009
                {++c, new RegistroCampo(3,     81,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "605",     null,       2,      true)}, //010
                {++c, new RegistroCampo(3,     98,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "606",     null,       2,      true)}, //011
                {++c, new RegistroCampo(3,    115,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "48",      null,       2,      true)}, //012
                {++c, new RegistroCampo(3,    132,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "49",      null,       2,      true)}, //013
                {++c, new RegistroCampo(3,    149,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "506",     null,       2,      true)}, //014
                {++c, new RegistroCampo(3,    166,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "507",     null,       2,      true)}, //015
                {++c, new RegistroCampo(3,    183,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "607",     null,       2,      true)}, //016
                {++c, new RegistroCampo(3,    200,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "608",     null,       2,      true)}, //017
                {++c, new RegistroCampo(3,    217,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "609",     null,       2,      true)}, //018
                {++c, new RegistroCampo(3,    234,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "610",     null,       2,      true)}, //019
                {++c, new RegistroCampo(3,    251,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "512",     null,       2,      true)}, //020
                {++c, new RegistroCampo(3,    268,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "513",     null,       2,      true)}, //021
                {++c, new RegistroCampo(3,    285,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "196",     null,       2,      true)}, //022
                {++c, new RegistroCampo(3,    302,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "197",     null,       2,      true)}, //023
                {++c, new RegistroCampo(3,    319,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "611",     null,       2,      true)}, //024
                {++c, new RegistroCampo(3,    336,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "612",     null,       2,      true)}, //025
                {++c, new RegistroCampo(3,    353,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "613",     null,       2,      true)}, //026
                {++c, new RegistroCampo(3,    370,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "614",     null,       2,      true)}, //027
                {++c, new RegistroCampo(3,    387,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "50",      null,       2,      true)}, //028
                {++c, new RegistroCampo(3,    404,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "51",      null,       2,      true)}, //029
                {++c, new RegistroCampo(3,    421,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "514",     null,       2,      true)}, //030
                {++c, new RegistroCampo(3,    438,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "515",     null,       2,      true)}, //031
                {++c, new RegistroCampo(3,    455,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "615",     null,       2,      true)}, //032
                {++c, new RegistroCampo(3,    472,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "616",     null,       2,      true)}, //033
                {++c, new RegistroCampo(3,    489,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "617",     null,       2,      true)}, //034
                {++c, new RegistroCampo(3,    506,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "618",     null,       2,      true)}, //035
                {++c, new RegistroCampo(3,    523,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "520",     null,       2,      true)}, //036
                {++c, new RegistroCampo(3,    540,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "521",     null,       2,      true)}, //037
                {++c, new RegistroCampo(3,    557,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "202",     null,       2,      true)}, //038
                {++c, new RegistroCampo(3,    574,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "203",     null,       2,      true)}, //039
                {++c, new RegistroCampo(3,    591,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "619",     null,       2,      true)}, //040
                {++c, new RegistroCampo(3,    608,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "620",     null,       2,      true)}, //041
                {++c, new RegistroCampo(3,    625,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "621",     null,       2,      true)}, //042
                {++c, new RegistroCampo(3,    642,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "622",     null,       2,      true)}, //043
                {++c, new RegistroCampo(3,    659,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "52",      null,       2,      true)}, //044
                {++c, new RegistroCampo(3,    676,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "53",      null,       2,      true)}, //045
                {++c, new RegistroCampo(3,    693,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "208",     null,       2,      true)}, //046
                {++c, new RegistroCampo(3,    710,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "209",     null,       2,      true)}, //047
                {++c, new RegistroCampo(3,    727,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "623",     null,       2,      true)}, //048
                {++c, new RegistroCampo(3,    744,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "624",     null,       2,      true)}, //049
                {++c, new RegistroCampo(3,    761,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "625",     null,       2,      true)}, //050
                {++c, new RegistroCampo(3,    778,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "626",     null,       2,      true)}, //051
                {++c, new RegistroCampo(3,    795,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "54",      null,       2,      true)}, //052
                {++c, new RegistroCampo(3,    812,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "55",      null,       2,      true)}, //053
                {++c, new RegistroCampo(3,    829,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "214",     null,       2,      true)}, //054
                {++c, new RegistroCampo(3,    846,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "215",     null,       2,      true)}, //055
                {++c, new RegistroCampo(3,    863,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "627",     null,       2,      true)}, //056
                {++c, new RegistroCampo(3,    880,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "628",     null,       2,      true)}, //057
                {++c, new RegistroCampo(3,    897,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "629",     null,       2,      true)}, //058
                {++c, new RegistroCampo(3,    914,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "630",     null,       2,      true)}, //059
                {++c, new RegistroCampo(3,    931,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "56",      null,       2,      true)}, //060
                {++c, new RegistroCampo(3,    948,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "57",      null,       2,      true)}, //061
                {++c, new RegistroCampo(3,    965,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "220",     null,       2,      true)}, //062
                {++c, new RegistroCampo(3,    982,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "221",     null,       2,      true)}, //063
                {++c, new RegistroCampo(3,    999,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "631",     null,       2,      true)}, //064
                {++c, new RegistroCampo(3,   1016,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "632",     null,       2,      true)}, //065
                {++c, new RegistroCampo(3,   1033,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "633",     null,       2,      true)}, //066
                {++c, new RegistroCampo(3,   1050,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "634",     null,       2,      true)}, //067
                {++c, new RegistroCampo(3,   1067,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "58",      null,       2,      true)}, //068
                {++c, new RegistroCampo(3,   1084,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "59",      null,       2,      true)}, //069
                {++c, new RegistroCampo(3,   1101,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "587",     null,       2,      true)}, //070
                {++c, new RegistroCampo(3,   1118,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "588",     null,       2,      true)}, //071
                {++c, new RegistroCampo(3,   1135,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "635",     null,       2,      true)}, //072
                {++c, new RegistroCampo(3,   1152,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "636",     null,       2,      true)}, //073
                {++c, new RegistroCampo(3,   1169,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "637",     null,       2,      true)}, //074
                {++c, new RegistroCampo(3,   1186,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "638",     null,       2,      true)}, //075
                {++c, new RegistroCampo(3,   1203,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "597",     null,       2,      true)}, //076
                {++c, new RegistroCampo(3,   1220,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "598",     null,       2,      true)}, //077
                {++c, new RegistroCampo(3,   1237,   150,     "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                               )}, //078
                {++c, new RegistroCampo(3,   1387,    12,     "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,          "</T39003000>"     )}, //079

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
