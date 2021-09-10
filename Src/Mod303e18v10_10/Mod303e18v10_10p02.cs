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

namespace AeatModelos.Mod303e18v10_10
{

    /// <summary>
    /// Página 2 modelo 303. Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod303e18v10_10p02 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_10p02(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "303";

            string p = "P02";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,     new RegistroCampo(2,    1,   2,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  "<T"             )}, // 01
                {++c,     new RegistroCampo(2,    3,   3,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null, Convert.ToInt32(Modelo),     0    )}, // 02
                {++c,     new RegistroCampo(2,    6,   5,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  2000,    0       )}, // 03
                {++c,     new RegistroCampo(2,   11,   1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  ">"              )}, // 04
                {++c,     new RegistroCampo(2,   12,   1,    "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "PaginaComplementaria" ," "             )}, // 05
                {++c,     new RegistroCampo(2,   13,   2,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 06
                {++c,     new RegistroCampo(2,   15,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 07
                {++c,     new RegistroCampo(2,   32,   6,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 08
                {++c,     new RegistroCampo(2,   38,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 09
                {++c,     new RegistroCampo(2,   55,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 10
                {++c,     new RegistroCampo(2,   60,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 11
                {++c,     new RegistroCampo(2,   77,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 12
                {++c,     new RegistroCampo(2,   94,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 13
                {++c,     new RegistroCampo(2,  111,   2,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 14
                {++c,     new RegistroCampo(2,  113,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 15
                {++c,     new RegistroCampo(2,  130,   6,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0,      5       )}, // 16
                {++c,     new RegistroCampo(2,  136,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 17
                {++c,     new RegistroCampo(2,  153,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 18
                {++c,     new RegistroCampo(2,  158,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 19
                {++c,     new RegistroCampo(2,  175,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 20
                {++c,     new RegistroCampo(2,  192,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 21
                {++c,     new RegistroCampo(2,  209,   4,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   ""              )}, // 22
                {++c,     new RegistroCampo(2,  213,   1,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   " "             )}, // 23
                {++c,     new RegistroCampo(2,  214,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 24
                {++c,     new RegistroCampo(2,  224,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 25
                {++c,     new RegistroCampo(2,  241,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 26
                {++c,     new RegistroCampo(2,  251,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 27
                {++c,     new RegistroCampo(2,  268,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 28
                {++c,     new RegistroCampo(2,  278,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 29
                {++c,     new RegistroCampo(2,  295,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 30
                {++c,     new RegistroCampo(2,  305,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 31
                {++c,     new RegistroCampo(2,  322,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 32
                {++c,     new RegistroCampo(2,  332,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 33
                {++c,     new RegistroCampo(2,  349,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 34
                {++c,     new RegistroCampo(2,  359,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 35
                {++c,     new RegistroCampo(2,  376,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 36
                {++c,     new RegistroCampo(2,  386,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 37
                {++c,     new RegistroCampo(2,  403,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 38
                {++c,     new RegistroCampo(2,  420,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 39
                {++c,     new RegistroCampo(2,  437,   3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 40
                {++c,     new RegistroCampo(2,  440,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 41
                {++c,     new RegistroCampo(2,  445,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 42
                {++c,     new RegistroCampo(2,  462,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 43
                {++c,     new RegistroCampo(2,  479,   3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 44
                {++c,     new RegistroCampo(2,  482,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 45
                {++c,     new RegistroCampo(2,  499,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 46
                {++c,     new RegistroCampo(2,  504,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 47
                {++c,     new RegistroCampo(2,  521,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 48
                {++c,     new RegistroCampo(2,  538,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 49
                {++c,     new RegistroCampo(2,  555,   4,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   ""              )}, // 50
                {++c,     new RegistroCampo(2,  559,   1,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   " "             )}, // 51
                {++c,     new RegistroCampo(2,  560,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 52
                {++c,     new RegistroCampo(2,  570,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 53
                {++c,     new RegistroCampo(2,  587,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 54
                {++c,     new RegistroCampo(2,  597,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 55
                {++c,     new RegistroCampo(2,  614,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 56
                {++c,     new RegistroCampo(2,  624,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 57
                {++c,     new RegistroCampo(2,  641,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 58
                {++c,     new RegistroCampo(2,  651,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 59
                {++c,     new RegistroCampo(2,  668,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 60
                {++c,     new RegistroCampo(2,  678,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 61
                {++c,     new RegistroCampo(2,  695,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 62
                {++c,     new RegistroCampo(2,  705,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 63
                {++c,     new RegistroCampo(2,  722,  10,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 64
                {++c,     new RegistroCampo(2,  732,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 65
                {++c,     new RegistroCampo(2,  749,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 66
                {++c,     new RegistroCampo(2,  766,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 67
                {++c,     new RegistroCampo(2,  783,   3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 68
                {++c,     new RegistroCampo(2,  786,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 69
                {++c,     new RegistroCampo(2,  791,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 70
                {++c,     new RegistroCampo(2,  808,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 71
                {++c,     new RegistroCampo(2,  825,   3,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 72
                {++c,     new RegistroCampo(2,  828,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 73
                {++c,     new RegistroCampo(2,  845,   5,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 74
                {++c,     new RegistroCampo(2,  850,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 75
                {++c,     new RegistroCampo(2,  867,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 76
                {++c,     new RegistroCampo(2,  884,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                   0               )}, // 77
                {++c,     new RegistroCampo(2,  901,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "47",                   0               )}, // 78
                {++c,     new RegistroCampo(2,  918,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "48",                   0               )}, // 79
                {++c,     new RegistroCampo(2,  935,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "49",                   0               )}, // 80
                {++c,     new RegistroCampo(2,  952,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "50",                   0               )}, // 81
                {++c,     new RegistroCampo(2,  969,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "51",                   0               )}, // 82
                {++c,     new RegistroCampo(2,  986,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "52",                   0               )}, // 83
                {++c,     new RegistroCampo(2, 1003,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "53",                   0               )}, // 84
                {++c,     new RegistroCampo(2, 1020,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "54",                   0               )}, // 85
                {++c,     new RegistroCampo(2, 1037,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "55",                   0               )}, // 86
                {++c,     new RegistroCampo(2, 1054,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "56",                   0               )}, // 87
                {++c,     new RegistroCampo(2, 1071,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "57",                   0               )}, // 88
                {++c,     new RegistroCampo(2, 1088,  17,    "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "58",                   0               )}, // 89
                {++c,     new RegistroCampo(2, 1105, 590,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null, new string(' ', 590)              )}, // 90
                {++c,     new RegistroCampo(2, 1695,  12,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,      $"</T{Modelo}02000>"         )}  // 91
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
