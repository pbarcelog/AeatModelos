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
    /// Página 4 modelo 390.
    /// </summary>
    public class Mod390e2019v100p04 : RegistroModPagina
    {

        #region Construtores de Instancia

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
