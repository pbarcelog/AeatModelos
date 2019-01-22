/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2018 Irene Solutions SL
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
    /// Página 2 modelo 303. Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod303e18v10_10p02 : RegistroMod
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_10p02(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P02";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,     new RegistroCampo(2,    1,   2,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  "<T"         )},
                {++c,     new RegistroCampo(2,    3,   3,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  303,     0   )},
                {++c,     new RegistroCampo(2,    6,   5,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  2000,    0   )},
                {++c,     new RegistroCampo(2,   11,   1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  ">"          )},
                {++c,     new RegistroCampo(2,   12,   1,    "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "PaginaComplementaria" ," "         )},
                {++c,     new RegistroCampo(2,   13,   2,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,   15,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,   32,   6,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,   38,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,   55,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,   60,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,   77,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,   94,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  111,   2,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  113,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  130,   6,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0,      5   )},
                {++c,     new RegistroCampo(2,  136,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  153,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  158,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  175,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  192,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  209,   4,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   ""          )},
                {++c,     new RegistroCampo(2,  213,   1,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   " "         )},
                {++c,     new RegistroCampo(2,  214,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  224,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  241,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  251,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  268,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  278,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  295,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  305,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  322,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  332,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  349,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  359,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  376,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  386,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  403,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  420,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  437,   3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  440,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  445,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  462,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  479,   3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  482,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  499,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  504,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  521,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  538,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  555,   4,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   ""          )},
                {++c,     new RegistroCampo(2,  559,   1,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   " "         )},
                {++c,     new RegistroCampo(2,  560,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  570,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  587,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  597,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  614,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  624,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  641,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  651,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  668,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  678,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  695,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  705,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  722,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  732,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  749,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  766,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  783,   3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  786,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  791,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  808,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  825,   3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  828,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  845,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  850,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  867,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  884,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0           )},
                {++c,     new RegistroCampo(2,  901,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "47",                   0           )},
                {++c,     new RegistroCampo(2,  918,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "48",                   0           )},
                {++c,     new RegistroCampo(2,  935,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "49",                   0           )},
                {++c,     new RegistroCampo(2,  952,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "50",                   0           )},
                {++c,     new RegistroCampo(2,  969,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "51",                   0           )},
                {++c,     new RegistroCampo(2,  986,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "52",                   0           )},
                {++c,     new RegistroCampo(2, 1003,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "53",                   0           )},
                {++c,     new RegistroCampo(2, 1020,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "54",                   0           )},
                {++c,     new RegistroCampo(2, 1037,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "55",                   0           )},
                {++c,     new RegistroCampo(2, 1054,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "56",                   0           )},
                {++c,     new RegistroCampo(2, 1071,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "57",                   0           )},
                {++c,     new RegistroCampo(2, 1088,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "58",                   0           )},
                {++c,     new RegistroCampo(2, 1105, 590,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null, new string(' ', 590)          )},
                {++c,     new RegistroCampo(2, 1695,  12,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,"</T30302000>"                 )}
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
