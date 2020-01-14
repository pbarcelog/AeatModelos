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

namespace AeatModelos.Mod303e18v10_10
{

    /// <summary>
    /// Página 3 modelo 303. Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod303e18v10_10p03 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_10p03(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P03";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                 {++c,     new RegistroCampo(3,    1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,  "<T"                )},
                 {++c,     new RegistroCampo(3,    3,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,  303,        0       )},
                 {++c,     new RegistroCampo(3,    6,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,  3000,       0       )},
                 {++c,     new RegistroCampo(3,   11,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,  ">"                 )},
                 {++c,     new RegistroCampo(3,   12,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "59"                        )},
                 {++c,     new RegistroCampo(3,   29,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "60"                        )},
                 {++c,     new RegistroCampo(3,   46,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "61"                        )},
                 {++c,     new RegistroCampo(3,   63,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "62"                        )},
                 {++c,     new RegistroCampo(3,   80,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "63"                        )},
                 {++c,     new RegistroCampo(3,   97,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "74"                        )},
                 {++c,     new RegistroCampo(3,  114,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "75"                        )},
                 {++c,     new RegistroCampo(3,  131,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"] , "76",   0                   )},
                 {++c,     new RegistroCampo(3,  148,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "64"                        )},
                 {++c,     new RegistroCampo(3,  165,   5,  "Num",  Txt.Den["P03.B14"],                         "65",   100,    2           )},
                 {14.1m,   new RegistroCampo(3,  170,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                        )},
                 {++c,     new RegistroCampo(3,  174,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "66"                        )},
                 {++c,     new RegistroCampo(3,  191,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "77" ,  0                   )},
                 {++c,     new RegistroCampo(3,  208,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "67",   0                   )},
                 {++c,     new RegistroCampo(3,  225,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "68",   0                   )},
                 {++c,     new RegistroCampo(3,  242,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "69", null,  2,         true)},
                 {++c,     new RegistroCampo(3,  259,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "70", null,  2,         true)},
                 {++c,     new RegistroCampo(3,  276,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "71", null,  2,         true)},
                 // 'X' o blanco
                 {++c,     new RegistroCampo(3,  293,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Complementaria"             )},
                 {++c,     new RegistroCampo(3,  294,  13,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Justificante"               )},
                 {++c,     new RegistroCampo(3,  307,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                        )},
                 {++c,     new RegistroCampo(3,  308,  11,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                        )},
                 {++c,     new RegistroCampo(3,  319,  34,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "IBAN"                      )},
                 {++c,     new RegistroCampo(3,  353,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                        )},
                 {++c,     new RegistroCampo(3,  354,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                        )},
                 {++c,     new RegistroCampo(3,  358,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                        )},
                 {++c,     new RegistroCampo(3,  359,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                        )},
                 {++c,     new RegistroCampo(3,  363,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null                        )},
                 {++c,     new RegistroCampo(3,  364,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  368,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  369,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  373,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  374,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  378,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  379,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  383,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  384,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "80"                        )},
                 {++c,     new RegistroCampo(3,  401,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "81"                        )},
                 {++c,     new RegistroCampo(3,  418,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "93"                        )},
                 {++c,     new RegistroCampo(3,  435,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "83"                        )},
                 {++c,     new RegistroCampo(3,  452,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "84"                        )},
                 {++c,     new RegistroCampo(3,  469,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "85"                        )},
                 {++c,     new RegistroCampo(3,  486,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "86"                        )},
                 {++c,     new RegistroCampo(3,  503,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "79"                        )},
                 {++c,     new RegistroCampo(3,  520,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "88"                        )},
                 {++c,     new RegistroCampo(3,  537,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3,  538,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "89"                        )},
                 {++c,     new RegistroCampo(3,  543,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "90"                        )},
                 {++c,     new RegistroCampo(3,  548,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "91"                        )},
                 {++c,     new RegistroCampo(3,  553,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "92"                        )},
                 {++c,     new RegistroCampo(3,  558,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "94"                        )},
                 {++c,     new RegistroCampo(3,  575,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "95"                        )},
                 {++c,     new RegistroCampo(3,  592,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "96"                        )},
                 {++c,     new RegistroCampo(3,  609,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "97"                        )},
                 {++c,     new RegistroCampo(3,  626,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "98"                        )},
                 {++c,     new RegistroCampo(3,  643,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "99"                        )},
                 {++c,     new RegistroCampo(3,  660, 468,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                               )},
                 {++c,     new RegistroCampo(3, 1128,  12,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"] ,     null,   "</T30303000>"  )}
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
