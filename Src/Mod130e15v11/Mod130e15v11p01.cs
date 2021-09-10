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
    
    Puede evitar el cumplimiento de lo establecido 
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

using System;
using System.Collections.Generic;

namespace AeatModelos.Mod130e15v11
{

    /// <summary>
    /// Página 1 modelo 130. Diseño de registro: DR130e15v11.xlsx.
    /// </summary>
    public class Mod130e15v11p01 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod130e15v11p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "130";

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   2,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "<T"                 )}, // 01
                {++c,    new RegistroCampo(1,   3,   3,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null, Convert.ToInt32(Modelo), 0            )}, // 02
                {++c,    new RegistroCampo(1,   6,   2,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  1, 0                 )}, // 03
                {++c,    new RegistroCampo(1,   8,   4,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "000>"               )}, // 04
                {++c,    new RegistroCampo(1,   12,   1,    "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  " "                  )}, // 05
                // I (ingreso), U (domiciliación), G (ingreso a anotar en CCT), N (negativa) y B (resultado al deducir)
                {++c,    new RegistroCampo(1,   13,   1,    "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "TipoDeclaracion",     "U"                  )}, // 06
                {++c,    new RegistroCampo(1,   14,   9,    "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "NIF"                                       )}, // 07
                {++c,    new RegistroCampo(1,   23,   60,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ApellidosRazonSocial"                      )}, // 08
                {++c,    new RegistroCampo(1,   83,   20,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"] ,     "Nombre"                                    )}, // 09
                {++c,    new RegistroCampo(1,   103,   4,   "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Ejercicio" ,           Ejercicio, 0        )}, // 10
                {++c,    new RegistroCampo(1,   107,   2,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Periodo", Periodo                          )}, // 11
                {++c,    new RegistroCampo(1,   109,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "01",                  0, 2                 )}, // 12
                {++c,    new RegistroCampo(1,   126,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "02",                  0, 2                 )}, // 13
                {++c,    new RegistroCampo(1,   143,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "03",                  0, 2,        true    )}, // 14
                {++c,    new RegistroCampo(1,   160,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "04",                  0, 2                 )}, // 15
                {++c,    new RegistroCampo(1,   177,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "05",                  0, 2                 )}, // 16
                {++c,    new RegistroCampo(1,   194,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "06",                  0, 2                 )}, // 17
                {++c,    new RegistroCampo(1,   211,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "07",                  0, 2,        true    )}, // 18
                {++c,    new RegistroCampo(1,   228,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "08",                  0, 2                 )}, // 19
                {++c,    new RegistroCampo(1,   245,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "09",                  0, 2                 )}, // 20
                {++c,    new RegistroCampo(1,   262,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "10",                  0, 2                 )}, // 21
                {++c,    new RegistroCampo(1,   279,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "11",                  0, 2                 )}, // 22
                {++c,    new RegistroCampo(1,   296,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "12",                  0, 2,       false    )}, // 23
                {++c,    new RegistroCampo(1,   313,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "13",                  0, 2                 )}, // 24
                {++c,    new RegistroCampo(1,   330,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "14",                  0, 2,        true    )}, // 25
                {++c,    new RegistroCampo(1,   347,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "15",                  0, 2                 )}, // 26
                {++c,    new RegistroCampo(1,   364,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "16",                  0, 2                 )}, // 27
                {++c,    new RegistroCampo(1,   381,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "17",                  0, 2,        true    )}, // 28
                {++c,    new RegistroCampo(1,   398,   17,  "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "18",                  0, 2                 )}, // 29
                {++c,    new RegistroCampo(1,   415,   17,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "19",                  0, 2                 )}, // 30
                // blanco o "X"
                {++c,    new RegistroCampo(1,   432,   1,   "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Complementaria",      " "                  )}, // 31
                {++c,    new RegistroCampo(1,   433,   13,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "JustificanteAnterior"                      )}, // 32
                {++c,    new RegistroCampo(1,   446,   34,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "IBAN"                                      )}, // 33
                {++c,    new RegistroCampo(1,   480,   96,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,  new string(' ', 96)                  )}, // 34
                {++c,    new RegistroCampo(1,   576,   13,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,  new string(' ', 13)                  )}, // 35
                {++c,    new RegistroCampo(1,   589,   12,  "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  $"</T{Modelo}01000>" )}, // 36
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
