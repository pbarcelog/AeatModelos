/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2020 Irene Solutions SL
    Autores: Manuel Diago García, Juan Bautista Garcia Traver.

    Este programa es software libre; lo puede distribuir y/o modificar
    según los terminos de la licencia GNU Affero General Public License
    versión 3 según su redacción de la Free Software Foundation con la
    siguiente condición añadida en la sección 15 según se establece en
    la sección 7(a):

    PARA CUALQUIER PARTE DEL CÓGIO PROPIEDAD DE IRENE SOLUTIONS. IRENE 
    SOLUTIONS NO SE HACE RESPONSABLE DE LA VULNERACIÓN DE DERECHOS 
    DE TERCEROS.

    Este programa se distribuye con la esperanza de que sea útil, pero
    SIN GARANTÍA DE NINGÚN TIPO; ni siquiera la derivada de un acuerdo
    comercial o utilización para un propósito particular.
   
    Para más información puede consultar la licencia GNU Affero General
    Public http://www.gnu.org/licenses o escribir a la Free Software 
    Foundation, Inc. , 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, o descargarla en la siguiente URL:
        http://www.irenesolutions.com/terms-of-use.pdf 

    Las interfaces de usuario con versiones del código fuente del presente 
    proyecto, modificado o no, o código de objeto del mismo, deben incluir
    de manera visible los correspondientes avisos legales exigidos en la
    sección 5 de la licencia GNU Affero General Public.
    
    uede evitar el cumplimiento de lo establecido de lo establecido 
    anteriormente comprando una licencia comercial. 
    La compra de una licencia comercial es obligatoria
    desde el momento en que usted desarrolle software comercial incluyendo
    funcionalidades de AeatModelos sin la publicación del código fuente
    de sus propias aplicaciones.
    Estas actividades incluyen: La oferta de servicios de pago mediante
    aplicaciones web de cualquier tipo que incluyan la funcionalidad
    de AeatModelos.
    
    Para más información, contacte con la dirección: info@irenesolutions.com    
 */

using System.Collections.Generic;

namespace AeatModelos.Mod390e2019v100
{
    /// <summary>
    /// Página 6 modelo 390.
    /// </summary>
    public class Mod390e2019v100p06 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p06(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "006";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(6,       1,      2,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"        )}, //001
                {++c, new RegistroCampo(6,       3,      3,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  390,    0   )}, //002
                {++c, new RegistroCampo(6,       6,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  6000,   0   )}, //003
                {++c, new RegistroCampo(6,      11,      1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"         )}, //004
                {++c, new RegistroCampo(6,      12,      1,     "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //005
                {++c, new RegistroCampo(6,      13,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "7.658",   null,       2,      true)}, //006
                {++c, new RegistroCampo(6,      30,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "7.84",     null,       2,      true)}, //007
                {++c, new RegistroCampo(6,      47,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "7.659"                            )}, //008
                {++c, new RegistroCampo(6,      64,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "85"                               )}, //009
                {++c, new RegistroCampo(6,      81,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "86",      null,       2,      true)}, //010
                {++c, new RegistroCampo(6,      98,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "87"                               )}, //011
                {++c, new RegistroCampo(6,     103,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "88"                               )}, //012
                {++c, new RegistroCampo(6,     108,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "89"                               )}, //013
                {++c, new RegistroCampo(6,     113,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "90"                               )}, //014
                {++c, new RegistroCampo(6,     118,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "91"                               )}, //015
                {++c, new RegistroCampo(6,     123,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "8.658",   null,       2,      true)}, //016
                {++c, new RegistroCampo(6,     140,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "8.84",    null,       2,      true)}, //017
                {++c, new RegistroCampo(6,     157,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "92",      null,       2,      true)}, //018
                {++c, new RegistroCampo(6,     174,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "8.659"                            )}, //019
                {++c, new RegistroCampo(6,     191,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "93"                               )}, //020
                {++c, new RegistroCampo(6,     208,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "94",      null,       2,      true)}, //021
                {++c, new RegistroCampo(6,     225,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "95"                               )}, //022
                {++c, new RegistroCampo(6,     242,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "96"                               )}, //023
                {++c, new RegistroCampo(6,     259,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "524"                              )}, //024
                {++c, new RegistroCampo(6,     276,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "97"                               )}, //025
                {++c, new RegistroCampo(6,     293,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "98"                               )}, //026
                {++c, new RegistroCampo(6,     310,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "662"                              )}, //027
                {++c, new RegistroCampo(6,     327,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "525"                              )}, //028
                {++c, new RegistroCampo(6,     344,     17,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "526"                              )}, //029
                {++c, new RegistroCampo(6,     361,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "99",      null,       2,      true)}, //030
                {++c, new RegistroCampo(6,     378,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "653",     null,       2,      true)}, //031
                {++c, new RegistroCampo(6,     395,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "103",     null,       2,      true)}, //032
                {++c, new RegistroCampo(6,     412,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "104",     null,       2,      true)}, //033
                {++c, new RegistroCampo(6,     429,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "105",     null,       2,      true)}, //034
                {++c, new RegistroCampo(6,     446,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "110",     null,       2,      true)}, //035
                {++c, new RegistroCampo(6,     463,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "112",     null,       2,      true)}, //036
                {++c, new RegistroCampo(6,     480,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "100",     null,       2,      true)}, //037
                {++c, new RegistroCampo(6,     497,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "101",     null,       2,      true)}, //038
                {++c, new RegistroCampo(6,     514,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "102",     null,       2,      true)}, //039
                {++c, new RegistroCampo(6,     531,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "227",     null,       2,      true)}, //040
                {++c, new RegistroCampo(6,     548,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "228",     null,       2,      true)}, //041
                {++c, new RegistroCampo(6,     565,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "106",     null,       2,      true)}, //042
                {++c, new RegistroCampo(6,     582,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "107",     null,       2,      true)}, //043
                {++c, new RegistroCampo(6,     599,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "108",     null,       2,      true)}, //044
                {++c, new RegistroCampo(6,     616,    150,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //045
                {++c, new RegistroCampo(6,     766,     12,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,        "</T39006000>"        )}, //046

            };


        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
        }

        #endregion

    }
}
