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
    /// Página 6 modelo 390.
    /// </summary>
    public class Mod390e2019v100p06 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p06(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "001";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(6,       1,      2,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"        )}, //001
                {++c, new RegistroCampo(6,       3,      3,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  390,    0   )}, //002
                {++c, new RegistroCampo(6,       6,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  6000,   0   )}, //003
                {++c, new RegistroCampo(6,      11,      1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"         )}, //004
                {++c, new RegistroCampo(6,      12,      1,     "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //005
                {++c, new RegistroCampo(6,      13,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //006
                {++c, new RegistroCampo(6,      30,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //007
                {++c, new RegistroCampo(6,      47,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //008
                {++c, new RegistroCampo(6,      64,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //009
                {++c, new RegistroCampo(6,      81,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //010
                {++c, new RegistroCampo(6,      98,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //011
                {++c, new RegistroCampo(6,     103,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //012
                {++c, new RegistroCampo(6,     108,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //013
                {++c, new RegistroCampo(6,     113,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //014
                {++c, new RegistroCampo(6,     118,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //015
                {++c, new RegistroCampo(6,     123,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //016
                {++c, new RegistroCampo(6,     140,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //017
                {++c, new RegistroCampo(6,     157,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //018
                {++c, new RegistroCampo(6,     174,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //019
                {++c, new RegistroCampo(6,     191,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //020
                {++c, new RegistroCampo(6,     208,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //021
                {++c, new RegistroCampo(6,     225,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //022
                {++c, new RegistroCampo(6,     242,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //023
                {++c, new RegistroCampo(6,     259,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //024
                {++c, new RegistroCampo(6,     276,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //025
                {++c, new RegistroCampo(6,     293,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //026
                {++c, new RegistroCampo(6,     310,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //027
                {++c, new RegistroCampo(6,     327,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //028
                {++c, new RegistroCampo(6,     344,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //029
                {++c, new RegistroCampo(6,     361,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //030
                {++c, new RegistroCampo(6,     378,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //031
                {++c, new RegistroCampo(6,     395,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //032
                {++c, new RegistroCampo(6,     412,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //033
                {++c, new RegistroCampo(6,     429,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //034
                {++c, new RegistroCampo(6,     446,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //035
                {++c, new RegistroCampo(6,     463,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //036
                {++c, new RegistroCampo(6,     480,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //037
                {++c, new RegistroCampo(6,     497,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //038
                {++c, new RegistroCampo(6,     514,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //039
                {++c, new RegistroCampo(6,     531,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //040
                {++c, new RegistroCampo(6,     548,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //041
                {++c, new RegistroCampo(6,     565,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //042
                {++c, new RegistroCampo(6,     582,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //043
                {++c, new RegistroCampo(6,     599,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //044
                {++c, new RegistroCampo(6,     616,    150,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //045
                {++c, new RegistroCampo(6,     766,     12,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,        "</T39006000>"        )}, //046

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
