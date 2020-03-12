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

namespace AeatModelos.Mod131e2019v1_00
{

    /// <summary>
    /// Página 1 modelo 303.  Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod131e2019v1_00p01 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod131e2019v1_00p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,     1,   2,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             "<T"                )}, // 01
                {++c,    new RegistroCampo(1,     3,   3,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             "131"               )}, // 02
                {++c,    new RegistroCampo(1,     6,   5,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             "01000"             )}, // 03
                {++c,    new RegistroCampo(1,    11,   1,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             ">"                 )}, // 04
                {++c,    new RegistroCampo(1,    12,   1,    "A", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             " "                 )}, // 05
                {++c,    new RegistroCampo(1,    13,   1,    "A", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "TipoDeclaracion",                "U"                 )}, // 06
                {++c,    new RegistroCampo(1,    14,   9,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "NIF"                                                 )}, // 07
                {++c,    new RegistroCampo(1,    23,  60,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ApellidosRazonSocial"                                )}, // 08
                {++c,    new RegistroCampo(1,    83,  20,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"] ,     "Nombre"                                              )}, // 09
                {++c,    new RegistroCampo(1,   103,   4,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Ejercicio" ,                     Ejercicio, 0        )}, // 10
                {++c,    new RegistroCampo(1,   107,   2,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Periodo",                        Periodo             )}, // 11
                {++c,    new RegistroCampo(1,   109,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE1"                                        )}, // 12
                {++c,    new RegistroCampo(1,   113,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto1",               0, 2                )}, // 13
                {++c,    new RegistroCampo(1,   130,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable1",           0, 2                )}, // 14
                {++c,    new RegistroCampo(1,   135,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje1", 0, 2                )}, // 15
                {++c,    new RegistroCampo(1,   152,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE2"                                        )}, // 16
                {++c,    new RegistroCampo(1,   156,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto2",               0, 2                )}, // 17
                {++c,    new RegistroCampo(1,   173,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable2",           0, 2                )}, // 18
                {++c,    new RegistroCampo(1,   178,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje2", 0, 2                )}, // 19
                {++c,    new RegistroCampo(1,   195,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE3"                                        )}, // 20
                {++c,    new RegistroCampo(1,   199,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto3",               0, 2                )}, // 21
                {++c,    new RegistroCampo(1,   216,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable3",           0, 2                )}, // 22
                {++c,    new RegistroCampo(1,   221,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje3", 0, 2                )}, // 23
                {++c,    new RegistroCampo(1,   238,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE4"                                        )}, // 24
                {++c,    new RegistroCampo(1,   242,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto4",               0, 2                )}, // 25
                {++c,    new RegistroCampo(1,   259,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable4",           0, 2                )}, // 26
                {++c,    new RegistroCampo(1,   264,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje4", 0, 2                )}, // 27
                {++c,    new RegistroCampo(1,   281,   4,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "EpigrafeIAE5"                                        )}, // 28
                {++c,    new RegistroCampo(1,   285,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "RendimientoNeto5",               0, 2                )}, // 29
                {++c,    new RegistroCampo(1,   302,   5,  "Num", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "PorcentajeAplicable5",           0, 2                )}, // 30
                {++c,    new RegistroCampo(1,   307,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "ResultadoAplicacionPorcentaje5", 0, 2                )}, // 31
                {++c,    new RegistroCampo(1,   324,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "01",                             0, 2                )}, // 32
                {++c,    new RegistroCampo(1,   341,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "02",                             0, 2                )}, // 33
                {++c,    new RegistroCampo(1,   358,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "03",                             0, 2                )}, // 34
                {++c,    new RegistroCampo(1,   375,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "04",                             0, 2                )}, // 35
                {++c,    new RegistroCampo(1,   392,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "05",                             0, 2                )}, // 36
                {++c,    new RegistroCampo(1,   409,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "06",                             0, 2                )}, // 37
                {++c,    new RegistroCampo(1,   426,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "07",                             0, 2                )}, // 38
                {++c,    new RegistroCampo(1,   443,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "08",                             0, 2                )}, // 39
                {++c,    new RegistroCampo(1,   460,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "09",                             0, 2                )}, // 40
                {++c,    new RegistroCampo(1,   477,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "10",                             0, 2                )}, // 41
                {++c,    new RegistroCampo(1,   494,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "11",                             0, 2                )}, // 42
                {++c,    new RegistroCampo(1,   511,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "12",                             0, 2                )}, // 43
                {++c,    new RegistroCampo(1,   528,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "13",                             0, 2                )}, // 44
                {++c,    new RegistroCampo(1,   545,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "14",                             0, 2                )}, // 45
                {++c,    new RegistroCampo(1,   562,  17,    "N", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "15",                             0, 2                )}, // 46
                {++c,    new RegistroCampo(1,   579,  34,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "IBAN"                                                )}, // 47
                {++c,    new RegistroCampo(1,   613,   1,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "Complementaria",                 " "                 )}, // 48
                {++c,    new RegistroCampo(1,   614,   13,  "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      "JustificanteAnterior"                                )}, // 49
                {++c,    new RegistroCampo(1,   627, 100,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             new string(' ', 100))}, // 50
                {++c,    new RegistroCampo(1,   727,  13,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                             new string(' ', 13) )}, // 51
                {++c,    new RegistroCampo(1,   740,  12,   "An", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],      null,                  "</T13101000>"                 )}, // 52
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
