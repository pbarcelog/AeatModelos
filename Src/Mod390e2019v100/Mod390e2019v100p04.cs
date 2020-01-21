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
    /// Página 4 modelo 390.
    /// </summary>
    public class Mod390e2019v100p04 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p04(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "004";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(4,    1,     2,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"        )}, //001
                {++c, new RegistroCampo(4,    3,     3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  390,    0   )}, //002
                {++c, new RegistroCampo(4,    6,     5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  4000,   0   )}, //003
                {++c, new RegistroCampo(4,    11,    1,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"         )}, //004
                {++c, new RegistroCampo(4,    12,    1,    "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //005
                {++c, new RegistroCampo(4,    13,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "60",      null,       2,      true)}, //006
                {++c, new RegistroCampo(4,    30,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "61",      null,       2,      true)}, //007
                {++c, new RegistroCampo(4,    47,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "660",     null,       2,      true)}, //008
                {++c, new RegistroCampo(4,    64,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "661",     null,       2,      true)}, //009
                {++c, new RegistroCampo(4,    81,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "639",     null,       2,      true)}, //010
                {++c, new RegistroCampo(4,    98,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "62",      null,       2,      true)}, //011
                {++c, new RegistroCampo(4,   115,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "651",     null,       2,      true)}, //012
                {++c, new RegistroCampo(4,   132,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "652",     null,       2,      true)}, //013
                {++c, new RegistroCampo(4,   149,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "63",      null,       2,      true)}, //014
                {++c, new RegistroCampo(4,   166,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "522",     null,       2,      true)}, //015
                {++c, new RegistroCampo(4,   183,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "64",      null,       2,      true)}, //016
                {++c, new RegistroCampo(4,   200,   17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "65",      null,       2,      true)}, //017
                {++c, new RegistroCampo(4,   217,  150,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //018
                {++c, new RegistroCampo(4,   367,   12,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,        "</T39004000>"        )}, //019

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
