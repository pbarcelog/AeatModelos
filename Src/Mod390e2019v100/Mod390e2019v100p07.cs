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
    /// Página 7 modelo 390.
    /// </summary>
    public class Mod390e2019v100p07 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p07(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "001";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(7,       1,       2,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"        )}, //001
                {++c, new RegistroCampo(7,       3,       3,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  390,    0   )}, //002
                {++c, new RegistroCampo(7,       6,       5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  7000,   0   )}, //003
                {++c, new RegistroCampo(7,      11,       1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"         )}, //004
                {++c, new RegistroCampo(7,      12,       1,     "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //005
                {++c, new RegistroCampo(7,      13,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //006
                {++c, new RegistroCampo(7,      30,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //007
                {++c, new RegistroCampo(7,      47,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //008
                {++c, new RegistroCampo(7,      64,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //009
                {++c, new RegistroCampo(7,      81,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //010
                {++c, new RegistroCampo(7,      98,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //011
                {++c, new RegistroCampo(7,     115,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //012
                {++c, new RegistroCampo(7,     132,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //013
                {++c, new RegistroCampo(7,     149,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //014
                {++c, new RegistroCampo(7,     166,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //015
                {++c, new RegistroCampo(7,     183,      17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //016
                {++c, new RegistroCampo(7,     200,      40,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //017
                {++c, new RegistroCampo(7,     240,       3,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //018
                {++c, new RegistroCampo(7,     243,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //019
                {++c, new RegistroCampo(7,     260,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //020
                {++c, new RegistroCampo(7,     277,       1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //021
                {++c, new RegistroCampo(7,     278,       5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //022
                {++c, new RegistroCampo(7,     283,      40,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //023
                {++c, new RegistroCampo(7,     323,       3,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //024
                {++c, new RegistroCampo(7,     326,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //025
                {++c, new RegistroCampo(7,     343,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //026
                {++c, new RegistroCampo(7,     360,       1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //027
                {++c, new RegistroCampo(7,     361,       5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //028
                {++c, new RegistroCampo(7,     366,      40,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //029
                {++c, new RegistroCampo(7,     406,       3,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //030
                {++c, new RegistroCampo(7,     409,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //031
                {++c, new RegistroCampo(7,     426,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //032
                {++c, new RegistroCampo(7,     443,       1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //033
                {++c, new RegistroCampo(7,     444,       5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //034
                {++c, new RegistroCampo(7,     449,      40,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //035
                {++c, new RegistroCampo(7,     489,       3,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //036
                {++c, new RegistroCampo(7,     492,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //037
                {++c, new RegistroCampo(7,     509,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //038
                {++c, new RegistroCampo(7,     526,       1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //039
                {++c, new RegistroCampo(7,     527,       5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //040
                {++c, new RegistroCampo(7,     532,      40,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //041
                {++c, new RegistroCampo(7,     572,       3,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //042
                {++c, new RegistroCampo(7,     575,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //043
                {++c, new RegistroCampo(7,     592,      17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //044
                {++c, new RegistroCampo(7,     609,       1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //045
                {++c, new RegistroCampo(7,     610,       5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //046
                {++c, new RegistroCampo(7,     615,     150,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //047
                {++c, new RegistroCampo(7,     765,      12,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,        "</T39007000>"        )}, //048

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
