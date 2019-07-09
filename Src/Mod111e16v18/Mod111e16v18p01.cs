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

namespace AeatModelos.Mod111e16v18
{

    /// <summary>
    /// Página 1 modelo 111.  Diseño de registro: dr111e16v18.xlsx.
    /// </summary>
    public class Mod111e16v18p01 : RegistroMod
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod111e16v18p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   2,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "<T"             )}, 
                {++c,    new RegistroCampo(1,   3,   3,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  111, 0           )},
                {++c,    new RegistroCampo(1,   6,   2,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  1, 0          )},
                {++c,    new RegistroCampo(1,   8,   4,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "000>"           )},
                {++c,    new RegistroCampo(1,   12,   1,    "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  " "              )},
                {++c,    new RegistroCampo(1,   13,   1,    "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "TipoDeclaracion",     "U"              )},
                {++c,    new RegistroCampo(1,   14,   9,    "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "NIF"                                   )},
                {++c,    new RegistroCampo(1,   23,   60,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ApellidosRazonSocial"                  )},
                {++c,    new RegistroCampo(1,   83,   20,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"] ,     "Nombre"                                )},
                {++c,    new RegistroCampo(1,   103,   4,   "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Ejercicio" ,           Ejercicio, 0    )},
                {++c,    new RegistroCampo(1,   107,   2,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Periodo", Periodo                      )},
                {++c,    new RegistroCampo(1,   109,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "01",                  0, 0             )},
                {++c,    new RegistroCampo(1,   117,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "02",                  0, 2             )},
                {++c,    new RegistroCampo(1,   134,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "03",                  0, 2             )},
                {++c,    new RegistroCampo(1,   151,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "04",                  0, 0             )},
                {++c,    new RegistroCampo(1,   159,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "05",                  0, 2             )},
                {++c,    new RegistroCampo(1,   176,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "06",                  0, 2             )},
                {++c,    new RegistroCampo(1,   193,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "07",                  0, 0             )},
                {++c,    new RegistroCampo(1,   201,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "08",                  0, 2             )},
                {++c,    new RegistroCampo(1,   218,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "09",                  0, 2             )},
                {++c,    new RegistroCampo(1,   235,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "10",                  0, 0             )},
                {++c,    new RegistroCampo(1,   243,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "11",                  0, 2             )},
                {++c,    new RegistroCampo(1,   260,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "12",                  0, 2             )},
                {++c,    new RegistroCampo(1,   277,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "13",                  0, 0             )},
                {++c,    new RegistroCampo(1,   285,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "14",                  0, 2             )},
                {++c,    new RegistroCampo(1,   302,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "15",                  0, 2             )},
                {++c,    new RegistroCampo(1,   319,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "16",                  0, 0             )},
                {++c,    new RegistroCampo(1,   327,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "17",                  0, 2             )},
                {++c,    new RegistroCampo(1,   344,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "18",                  0, 2             )},
                {++c,    new RegistroCampo(1,   361,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "19",                  0, 0             )},
                {++c,    new RegistroCampo(1,   369,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "20",                  0, 2             )},
                {++c,    new RegistroCampo(1,   386,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "21",                  0, 2             )},
                {++c,    new RegistroCampo(1,   403,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "22",                  0, 0             )},
                {++c,    new RegistroCampo(1,   411,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "23",                  0, 2             )},
                {++c,    new RegistroCampo(1,   428,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "24",                  0, 2             )},
                {++c,    new RegistroCampo(1,   445,   8,   "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "25",                  0, 0             )},
                {++c,    new RegistroCampo(1,   453,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "26",                  0, 2             )},
                {++c,    new RegistroCampo(1,   470,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "27",                  0, 2             )},
                {++c,    new RegistroCampo(1,   487,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "28",                  0, 2             )},
                {++c,    new RegistroCampo(1,   504,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "29",                  0, 2             )},
                {++c,    new RegistroCampo(1,   521,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "30",                  0, 2             )},
                {++c,    new RegistroCampo(1,   538,   1,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  " "              )},
                {++c,    new RegistroCampo(1,   539,   13,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                               )},
                {++c,    new RegistroCampo(1,   552,   1,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                               )},
                {++c,    new RegistroCampo(1,   553,   34,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "IBAN"                                  )},
                {++c,    new RegistroCampo(1,   587,   389, "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,  new string(' ', 96)              )},
                {++c,    new RegistroCampo(1,   976,   13,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,  new string(' ', 13)              )},
                {++c,    new RegistroCampo(1,   989,   12,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "</T11101000>"   )},
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
