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
    
    Puede evitar el cumplimiento de lo establecido de lo establecido 
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

namespace AeatModelos.Mod123e15v13
{

    /// <summary>
    /// Página 1 modelo 111.  Diseño de registro: dr111e16v18.xlsx.
    /// </summary>
    public class Mod123e15v13p01 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod123e15v13p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,      2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "<T"             )}, // 001
                {++c,    new RegistroCampo(1,   3,      3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  123, 0           )}, // 002
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
                {++c,    new RegistroCampo(1,   192,    17, "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "06",                  0, 2             )}, // 017
                {++c,    new RegistroCampo(1,   209,    17, "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "07",                  0, 2             )}, // 018
                {++c,    new RegistroCampo(1,   226,    17, "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "08",                  0, 2             )}, // 019
                {++c,    new RegistroCampo(1,   243,    1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Complementaria",      " "              )}, // 020
                {++c,    new RegistroCampo(1,   244,    13, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "JustificanteAnterior"                  )}, // 021
                {++c,    new RegistroCampo(1,   257,    34, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "IBAN"                                  )}, // 022
                {++c,    new RegistroCampo(1,   291,    185,"An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,  new string(' ', 96)              )}, // 023
                {++c,    new RegistroCampo(1,   476,    13, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,  new string(' ', 13)              )}, // 024
                {++c,    new RegistroCampo(1,   489,    12, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "</T12301000>"   )}, // 025
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
