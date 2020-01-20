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

using System.Collections.Generic;

namespace AeatModelos.Mod303e18v10_20
{

    /// <summary>
    /// Página 4 modelo 303. Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod303e18v10_20p04 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_20p04(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "004";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                 {++c,     new RegistroCampo(4,    1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"] , "<T"                            )}, //001
                 {++c,     new RegistroCampo(4,    3,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,               303,    0   )}, //002
                 {++c,     new RegistroCampo(4,    6,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,               4000,   0   )}, //003
                 {++c,     new RegistroCampo(4,   11,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,">"                        )}, //004
                 {++c,     new RegistroCampo(4,   12,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "PaginaComplementaria"          )}, //005
                 {++c,     new RegistroCampo(4,   13,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "500"                           )}, //006
                 {++c,     new RegistroCampo(4,   16,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "501",    null,     2,      true)}, //007
                 {++c,     new RegistroCampo(4,   33,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "502",    null,     2,      true)}, //008
                 // 'G', 'E' o blanco.
                 {++c,     new RegistroCampo(4,   50,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "503"                           )}, //009
                 {++c,     new RegistroCampo(4,   51,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "504"                           )}, //010
                 {++c,     new RegistroCampo(4,   56,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "505"                           )}, //011
                 {++c,     new RegistroCampo(4,   59,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "507",    null,     2,      true)}, //012
                 {++c,     new RegistroCampo(4,   76,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "507",    null,     2,      true)}, //013
                 // 'G', 'E' o blanco."
                 {++c,     new RegistroCampo(4,   93,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "508"                           )}, //014
                 {++c,     new RegistroCampo(4,   94,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "509"                           )}, //015
                 {++c,     new RegistroCampo(4,   99,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "510"                           )}, //016
                 {++c,     new RegistroCampo(4,  102,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "511",    null,     2,      true)}, //017
                 {++c,     new RegistroCampo(4,  119,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "512",    null,     2,      true)}, //018
                 {++c,     new RegistroCampo(4,  136,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "513"                           )}, //019
                 {++c,     new RegistroCampo(4,  137,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "514"                           )}, //020
                 {++c,     new RegistroCampo(4,  142,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "515"                           )}, //021
                 {++c,     new RegistroCampo(4,  145,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "516",    null,     2,      true)}, //022
                 {++c,     new RegistroCampo(4,  162,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "517",    null,     2,      true)}, //023
                 {++c,     new RegistroCampo(4,  179,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "518"                           )}, //024
                 {++c,     new RegistroCampo(4,  180,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "519"                           )}, //025
                 {++c,     new RegistroCampo(4,  185,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "520"                           )}, //026
                 {++c,     new RegistroCampo(4,  188,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "521",    null,     2,      true)}, //027
                 {++c,     new RegistroCampo(4,  205,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "522",    null,     2,      true)}, //028
                 {++c,     new RegistroCampo(4,  222,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "523"                           )}, //029
                 {++c,     new RegistroCampo(4,  223,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "524"                           )}, //030
                 {++c,     new RegistroCampo(4,  228,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "700",    null,     2,      true)}, //031
                 {++c,     new RegistroCampo(4,  245,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "701",    null,     2,      true)}, //032
                 {++c,     new RegistroCampo(4,  262,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "702",    null,     2,      true)}, //033
                 {++c,     new RegistroCampo(4,  279,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "703",    null,     2,      true)}, //034
                 {++c,     new RegistroCampo(4,  296,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "704",    null,     2,      true)}, //035
                 {++c,     new RegistroCampo(4,  313,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "705",    null,     2,      true)}, //036
                 {++c,     new RegistroCampo(4,  330,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "706",    null,     2,      true)}, //037
                 {++c,     new RegistroCampo(4,  347,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "707",    null,     2,      true)}, //038
                 {++c,     new RegistroCampo(4,  364,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "708",    null,     2,      true)}, //039
                 {++c,     new RegistroCampo(4,  381,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "709",    null,     2,      true)}, //040
                 {++c,     new RegistroCampo(4,  398,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "710",    null,     2,      true)}, //041
                 {++c,     new RegistroCampo(4,  415,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "711",    null,     2,      true)}, //042
                 {++c,     new RegistroCampo(4,  432,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "712",    null,     2,      true)}, //043
                 {++c,     new RegistroCampo(4,  449,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "713",    null,     2,      true)}, //044
                 {++c,     new RegistroCampo(4,  466,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "714",    null,     2,      true)}, //045
                 {++c,     new RegistroCampo(4,  483,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "715",    null,     2,      true)}, //046
                 {++c,     new RegistroCampo(4,  500,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "716",    null,     2,      true)}, //047
                 {++c,     new RegistroCampo(4,  517,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "717",    null,     2,      true)}, //048
                 {++c,     new RegistroCampo(4,  534,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "718",    null,     2,      true)}, //049
                 {++c,     new RegistroCampo(4,  551,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "719",    null,     2,      true)}, //050
                 {++c,     new RegistroCampo(4,  568,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "720",    null,     2,      true)}, //051
                 {++c,     new RegistroCampo(4,  585,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "721",    null,     2,      true)}, //052
                 {++c,     new RegistroCampo(4,  602,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "722",    null,     2,      true)}, //053
                 {++c,     new RegistroCampo(4,  619,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "723",    null,     2,      true)}, //054
                 {++c,     new RegistroCampo(4,  636,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "724",    null,     2,      true)}, //055
                 {++c,     new RegistroCampo(4,  653,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "725",    null,     2,      true)}, //056
                 {++c,     new RegistroCampo(4,  670,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "726",    null,     2,      true)}, //057
                 {++c,     new RegistroCampo(4,  687,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "727",    null,     2,      true)}, //058
                 {++c,     new RegistroCampo(4,  704,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "728",    null,     2,      true)}, //059
                 {++c,     new RegistroCampo(4,  721,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "729",    null,     2,      true)}, //060
                 {++c,     new RegistroCampo(4,  738,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "730",    null,     2,      true)}, //061
                 {++c,     new RegistroCampo(4,  755,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "731",    null,     2,      true)}, //062
                 {++c,     new RegistroCampo(4,  772,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "732",    null,     2,      true)}, //063
                 {++c,     new RegistroCampo(4,  789,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "733",    null,     2,      true)}, //064
                 {++c,     new RegistroCampo(4,  806,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "734",    null,     2,      true)}, //065
                 {++c,     new RegistroCampo(4,  823,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "735",    null,     2,      true)}, //066
                 {++c,     new RegistroCampo(4,  840, 672,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                   )}, //067
                 {++c,     new RegistroCampo(4, 1512, 12,   "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,             "</T30304000>")}  //068
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
