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

namespace AeatModelos.Mod115e15v13
{

    /// <summary>
    /// Página 1 modelo 111.  Diseño de registro: dr111e16v18.xlsx.
    /// </summary>
    public class Mod115e15v13p01 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod115e15v13p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,      2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "<T"             )}, // 001
                {++c,    new RegistroCampo(1,   3,      3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  115, 0           )}, // 002
                {++c,    new RegistroCampo(1,   6,      2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  1, 0             )}, // 003
                {++c,    new RegistroCampo(1,   8,      4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "000>"           )}, // 004
                {++c,    new RegistroCampo(1,   12,     1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  " "              )}, // 005
                {++c,    new RegistroCampo(1,   13,     1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "TipoDeclaracion",     "U"              )}, // 006
                {++c,    new RegistroCampo(1,   14,     9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "NIF"                                   )}, // 007
                {++c,    new RegistroCampo(1,   23,     60, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ApellidosRazonSocial"                  )}, // 008
                {++c,    new RegistroCampo(1,   83,     20, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Nombre"                                )}, // 009
                {++c,    new RegistroCampo(1,   103,    4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Ejercicio" ,           Ejercicio, 0    )}, // 010
                {++c,    new RegistroCampo(1,   107,    2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Periodo", Periodo                      )}, // 011
                {++c,    new RegistroCampo(1,   109,    15, "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "01",                  0, 0             )}, // 012
                {++c,    new RegistroCampo(1,   124,    17, "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "02",                  0, 2             )}, // 013
                {++c,    new RegistroCampo(1,   141,    17, "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "03",                  0, 2             )}, // 014
                {++c,    new RegistroCampo(1,   158,    17, "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "04",                  0, 2             )}, // 015
                {++c,    new RegistroCampo(1,   175,    17, "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "05",                  0, 2             )}, // 016
                {++c,    new RegistroCampo(1,   192,    1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  " "              )}, // 017
                {++c,    new RegistroCampo(1,   193,    13, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                               )}, // 018
                {++c,    new RegistroCampo(1,   206,    34, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "IBAN"                                  )}, // 019
                {++c,    new RegistroCampo(1,   240,    236,"An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,  new string(' ', 96)              )}, // 020
                {++c,    new RegistroCampo(1,   476,    13, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,  new string(' ', 13)              )}, // 021
                {++c,    new RegistroCampo(1,   489,    12, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "</T11501000>"   )}, // 022
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
