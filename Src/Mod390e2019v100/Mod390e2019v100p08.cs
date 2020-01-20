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
    /// Página 8 modelo 390.
    /// </summary>
    public class Mod390e2019v100p08 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p08(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "001";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(8,       1,      2,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"        )}, //001
                {++c, new RegistroCampo(8,       3,      3,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  390,    0   )}, //002
                {++c, new RegistroCampo(8,       6,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  8000,   0   )}, //003
                {++c, new RegistroCampo(8,      11,      1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"         )}, //004
                {++c, new RegistroCampo(8,      12,      1,     "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //005
                {++c, new RegistroCampo(8,      13,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //006
                {++c, new RegistroCampo(8,      30,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //007
                {++c, new RegistroCampo(8,      47,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //008
                {++c, new RegistroCampo(8,      64,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //009
                {++c, new RegistroCampo(8,      81,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //010
                {++c, new RegistroCampo(8,      98,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //011
                {++c, new RegistroCampo(8,     115,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //012
                {++c, new RegistroCampo(8,     132,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //013
                {++c, new RegistroCampo(8,     149,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //014
                {++c, new RegistroCampo(8,     166,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //015
                {++c, new RegistroCampo(8,     183,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //016
                {++c, new RegistroCampo(8,     200,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //017
                {++c, new RegistroCampo(8,     217,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //018
                {++c, new RegistroCampo(8,     234,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //019
                {++c, new RegistroCampo(8,     251,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //020
                {++c, new RegistroCampo(8,     268,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //021
                {++c, new RegistroCampo(8,     285,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //022
                {++c, new RegistroCampo(8,     302,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //023
                {++c, new RegistroCampo(8,     319,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //024
                {++c, new RegistroCampo(8,     336,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //025
                {++c, new RegistroCampo(8,     353,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //026
                {++c, new RegistroCampo(8,     370,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //027
                {++c, new RegistroCampo(8,     387,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //028
                {++c, new RegistroCampo(8,     404,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //029
                {++c, new RegistroCampo(8,     421,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //030
                {++c, new RegistroCampo(8,     438,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //031
                {++c, new RegistroCampo(8,     455,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //032
                {++c, new RegistroCampo(8,     472,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //033
                {++c, new RegistroCampo(8,     489,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //034
                {++c, new RegistroCampo(8,     506,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //035
                {++c, new RegistroCampo(8,     523,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //036
                {++c, new RegistroCampo(8,     540,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //037
                {++c, new RegistroCampo(8,     557,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //038
                {++c, new RegistroCampo(8,     574,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //039
                {++c, new RegistroCampo(8,     591,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //040
                {++c, new RegistroCampo(8,     608,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //041
                {++c, new RegistroCampo(8,     625,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //042
                {++c, new RegistroCampo(8,     642,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //043
                {++c, new RegistroCampo(8,     659,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //044
                {++c, new RegistroCampo(8,     676,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //045
                {++c, new RegistroCampo(8,     693,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //046
                {++c, new RegistroCampo(8,     710,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //047
                {++c, new RegistroCampo(8,     727,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //048
                {++c, new RegistroCampo(8,     744,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //049
                {++c, new RegistroCampo(8,     761,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //050
                {++c, new RegistroCampo(8,     778,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //051
                {++c, new RegistroCampo(8,     795,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //052
                {++c, new RegistroCampo(8,     812,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //053
                {++c, new RegistroCampo(8,     829,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //054
                {++c, new RegistroCampo(8,     846,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //055
                {++c, new RegistroCampo(8,     863,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //056
                {++c, new RegistroCampo(8,     880,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //057
                {++c, new RegistroCampo(8,     897,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //058
                {++c, new RegistroCampo(8,     914,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      null,       2,      true)}, //059
                {++c, new RegistroCampo(8,     931,    150,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //060
                {++c, new RegistroCampo(8,    1081,     12,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,        "</T39008000>"        )}, //061

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
