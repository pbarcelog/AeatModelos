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

namespace AeatModelos.Mod131e2019v1_00
{

    /// <summary>
    /// Página 1 modelo 303.  Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod131e2019v1_00p01 : RegistroMod
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod131e2019v1_00p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,     1,   2,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             "<T"                )}, 
                {++c,    new RegistroCampo(1,     3,   3,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             "131"               )},
                {++c,    new RegistroCampo(1,     6,   5,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             "01000"             )},
                {++c,    new RegistroCampo(1,    11,   1,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             ">"                 )},
                {++c,    new RegistroCampo(1,    12,   1,    "A", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             " "                 )},
                {++c,    new RegistroCampo(1,    13,   1,    "A", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "TipoDeclaracion",                "U"                 )},
                {++c,    new RegistroCampo(1,    14,   9,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "NIF"                                                 )},
                {++c,    new RegistroCampo(1,    23,  60,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ApellidosRazonSocial"                                )},
                {++c,    new RegistroCampo(1,    83,  20,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"] ,     "Nombre"                                              )},
                {++c,    new RegistroCampo(1,   103,   4,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Ejercicio" ,                     Ejercicio, 0        )},
                {++c,    new RegistroCampo(1,   107,   2,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Periodo",                        Periodo             )},
                {++c,    new RegistroCampo(1,   109,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE1"                                        )},
                {++c,    new RegistroCampo(1,   113,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto1",               0, 2                )},
                {++c,    new RegistroCampo(1,   130,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable1",           0, 2                )},
                {++c,    new RegistroCampo(1,   135,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje1", 0, 2                )},
                {++c,    new RegistroCampo(1,   152,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE2"                                        )},
                {++c,    new RegistroCampo(1,   156,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto2",               0, 2                )},
                {++c,    new RegistroCampo(1,   173,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable2",           0, 2                )},
                {++c,    new RegistroCampo(1,   178,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje2", 0, 2                )},
                {++c,    new RegistroCampo(1,   195,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE3"                                        )},
                {++c,    new RegistroCampo(1,   199,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto3",               0, 2                )},
                {++c,    new RegistroCampo(1,   216,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable3",           0, 2                )},
                {++c,    new RegistroCampo(1,   221,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje3", 0, 2                )},
                {++c,    new RegistroCampo(1,   238,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE4"                                        )},
                {++c,    new RegistroCampo(1,   242,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto4",               0, 2                )},
                {++c,    new RegistroCampo(1,   259,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable4",           0, 2                )},
                {++c,    new RegistroCampo(1,   264,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje4", 0, 2                )},
                {++c,    new RegistroCampo(1,   281,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE5"                                        )},
                {++c,    new RegistroCampo(1,   285,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto5",               0, 2                )},
                {++c,    new RegistroCampo(1,   302,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable5",           0, 2                )},
                {++c,    new RegistroCampo(1,   307,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje5", 0, 2                )},
                {++c,    new RegistroCampo(1,   324,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "01",                             0, 2                )},
                {++c,    new RegistroCampo(1,   341,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "02",                             0, 2                )},
                {++c,    new RegistroCampo(1,   358,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "03",                             0, 2                )},
                {++c,    new RegistroCampo(1,   375,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "04",                             0, 2                )},
                {++c,    new RegistroCampo(1,   392,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "05",                             0, 2                )},
                {++c,    new RegistroCampo(1,   409,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "06",                             0, 2                )},
                {++c,    new RegistroCampo(1,   426,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "07",                             0, 2                )},
                {++c,    new RegistroCampo(1,   443,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "08",                             0, 2                )},
                {++c,    new RegistroCampo(1,   460,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "09",                             0, 2                )},
                {++c,    new RegistroCampo(1,   477,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "10",                             0, 2                )},
                {++c,    new RegistroCampo(1,   494,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "11",                             0, 2                )},
                {++c,    new RegistroCampo(1,   511,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "12",                             0, 2                )},
                {++c,    new RegistroCampo(1,   528,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "13",                             0, 2                )},
                {++c,    new RegistroCampo(1,   545,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "14",                             0, 2                )},
                {++c,    new RegistroCampo(1,   562,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "15",                             0, 2                )},
                {++c,    new RegistroCampo(1,   579,  34,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "IBAN"                                                )},
                {++c,    new RegistroCampo(1,   613,   1,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             " "                 )},
                {++c,    new RegistroCampo(1,   614,   13,  "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                                             )},
                {++c,    new RegistroCampo(1,   627, 100,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             new string(' ', 100))},
                {++c,    new RegistroCampo(1,   727,  13,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             new string(' ', 13) )},
                {++c,    new RegistroCampo(1,   740,  12,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "</T13101000>"                 )},
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
