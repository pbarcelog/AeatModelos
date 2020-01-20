/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2020 Irene Solutions SL
    Autores: Irene Solutions SL.

    Este programa es software libre; usted puede redistribuirlo y/o modificarlo
    bajo los términos establecidos en GNU Affero General Public License versión 3
    tal y como han sido publicados por la Free Software Foundation.

    Este programa se distribuye con la intención de que sea útil, pero SIN
    NIGÚN TIPO DE GARANTÍA.

    Para más detalles consulte la licencia GNU Affero General Public.
    Debe se haber recibido una copia de la misma con el presente programa;
    en caso contrario, consulte http://www.gnu.org/licenses o escriba a la 
    Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, o descargue la licencia en la URL:
        http://www.irenesolutions.com/terms-of-use.pdf
    
    Las interfaces de ususario con código modificado y versiones de los
    objetos contenidos en el presente programa deben mostrar las advertencias
    legaels apropiadas, como se requiere en la secion 5 de la licencia GNU Affero
    General Public.

    Usted puede ser liberado de los requerimiento de la licencia mediante
    la compra de una licencia comercial. La compra de la licencia es
    obligatoria en caso de que vaya a desarrollar actividades comerciales
    con el software AeatModelos sin publicar el código fuente de sus 
    propias aplicaciones.
    Estas actividades incluyen: ofrecer servicios de pago como mediante ASP,
    sirviendo los resultados obtenidos mediante el presente software mediante
    aplicaciones web, o empaquetando AeatModelos con un producto de código
    fuente no público.    
       
    Para más información, por favor contacte a Irene Solutions SL. en la
    dirección: info@irenesolutions.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeatModelos.Mod390e2019v100
{
    /// <summary>
    /// Página 3 modelo 390.
    /// </summary>
    public class Mod390e2019v100p03 : RegistroModPagina
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p03(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "001";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(3,      1,     2,     "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,                  "<T"        )}, //001
                {++c, new RegistroCampo(3,      3,     3,     "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,                  390,    0   )}, //002
                {++c, new RegistroCampo(3,      6,     5,     "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,                  3000,   0   )}, //003
                {++c, new RegistroCampo(3,     11,     1,     "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,                  ">"         )}, //004
                {++c, new RegistroCampo(3,     12,     1,     "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                               )}, //005
                {++c, new RegistroCampo(3,     13,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //006
                {++c, new RegistroCampo(3,     30,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //007
                {++c, new RegistroCampo(3,     47,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //008
                {++c, new RegistroCampo(3,     64,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //009
                {++c, new RegistroCampo(3,     81,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //010
                {++c, new RegistroCampo(3,     98,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //011
                {++c, new RegistroCampo(3,    115,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //012
                {++c, new RegistroCampo(3,    132,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //013
                {++c, new RegistroCampo(3,    149,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //014
                {++c, new RegistroCampo(3,    166,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //015
                {++c, new RegistroCampo(3,    183,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //016
                {++c, new RegistroCampo(3,    200,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //017
                {++c, new RegistroCampo(3,    217,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //018
                {++c, new RegistroCampo(3,    234,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //019
                {++c, new RegistroCampo(3,    251,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //020
                {++c, new RegistroCampo(3,    268,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //021
                {++c, new RegistroCampo(3,    285,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //022
                {++c, new RegistroCampo(3,    302,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //023
                {++c, new RegistroCampo(3,    319,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //024
                {++c, new RegistroCampo(3,    336,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //025
                {++c, new RegistroCampo(3,    353,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //026
                {++c, new RegistroCampo(3,    370,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //027
                {++c, new RegistroCampo(3,    387,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //028
                {++c, new RegistroCampo(3,    404,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //029
                {++c, new RegistroCampo(3,    421,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //030
                {++c, new RegistroCampo(3,    438,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //031
                {++c, new RegistroCampo(3,    455,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //032
                {++c, new RegistroCampo(3,    472,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //033
                {++c, new RegistroCampo(3,    489,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //034
                {++c, new RegistroCampo(3,    506,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //035
                {++c, new RegistroCampo(3,    523,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //036
                {++c, new RegistroCampo(3,    540,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //037
                {++c, new RegistroCampo(3,    557,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //038
                {++c, new RegistroCampo(3,    574,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //039
                {++c, new RegistroCampo(3,    591,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //040
                {++c, new RegistroCampo(3,    608,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //041
                {++c, new RegistroCampo(3,    625,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //042
                {++c, new RegistroCampo(3,    642,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //043
                {++c, new RegistroCampo(3,    659,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //044
                {++c, new RegistroCampo(3,    676,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //045
                {++c, new RegistroCampo(3,    693,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //046
                {++c, new RegistroCampo(3,    710,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //047
                {++c, new RegistroCampo(3,    727,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //048
                {++c, new RegistroCampo(3,    744,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //049
                {++c, new RegistroCampo(3,    761,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //050
                {++c, new RegistroCampo(3,    778,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //051
                {++c, new RegistroCampo(3,    795,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //052
                {++c, new RegistroCampo(3,    812,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //053
                {++c, new RegistroCampo(3,    829,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //054
                {++c, new RegistroCampo(3,    846,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //055
                {++c, new RegistroCampo(3,    863,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //056
                {++c, new RegistroCampo(3,    880,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //057
                {++c, new RegistroCampo(3,    897,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //058
                {++c, new RegistroCampo(3,    914,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //059
                {++c, new RegistroCampo(3,    931,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //060
                {++c, new RegistroCampo(3,    948,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //061
                {++c, new RegistroCampo(3,    965,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //062
                {++c, new RegistroCampo(3,    982,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //063
                {++c, new RegistroCampo(3,    999,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //064
                {++c, new RegistroCampo(3,   1016,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //065
                {++c, new RegistroCampo(3,   1033,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //066
                {++c, new RegistroCampo(3,   1050,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //067
                {++c, new RegistroCampo(3,   1067,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //068
                {++c, new RegistroCampo(3,   1084,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //069
                {++c, new RegistroCampo(3,   1101,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //070
                {++c, new RegistroCampo(3,   1118,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //071
                {++c, new RegistroCampo(3,   1135,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //072
                {++c, new RegistroCampo(3,   1152,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //073
                {++c, new RegistroCampo(3,   1169,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //074
                {++c, new RegistroCampo(3,   1186,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //075
                {++c, new RegistroCampo(3,   1203,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //076
                {++c, new RegistroCampo(3,   1220,    17,     "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,      null,       2,      true)}, //077
                {++c, new RegistroCampo(3,   1237,   150,     "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                               )}, //078
                {++c, new RegistroCampo(3,   1387,    12,     "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,          "</T39003000>"     )}, //079

            };


        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
        }
    }
}
