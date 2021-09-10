﻿/*
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

namespace AeatModelos.Mod303e18v10_20
{

    /// <summary>
    /// Página 1 modelo 303.  Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod303e18v10_20p01 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_20p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "303";

            string p = "001";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   2, "An",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"              )}, // 01
                {++c,    new RegistroCampo(1,   3,   3, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null, Convert.ToInt32(Modelo),    0      )}, // 02
                {++c,    new RegistroCampo(1,   6,   5, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  1000,   0         )}, // 03
                {++c,    new RegistroCampo(1,  11,   1, "An ",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"               )}, // 04
                {++c,    new RegistroCampo(1,  12,   1, "A",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                     )}, // 05

                // PI :El tipo de declaración puede ser: C (solicitud de compensación) 
                // D (devolución) G (cuenta corriente tributaria-ingreso) I (ingreso) 
                // N (sin actividad/resultado cero) V (cuenta corriente tributaria -devolución)
                // U (domiciliacion del ingreso en CCC)
                {++c,    new RegistroCampo(1,  13,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoDeclaracion" ,     "I"              )}, // 06
                {++c,    new RegistroCampo(1,  14,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIF"                                    )}, // 07
                {++c,    new RegistroCampo(1,  23,  60,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosRazonSocial"                   )}, // 08
                {++c,    new RegistroCampo(1,  83,  20,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Nombre"                                 )}, // 09
                {++c,    new RegistroCampo(1, 103,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Ejercicio" ,           Ejercicio, 0     )}, // 10
                {++c,    new RegistroCampo(1, 107,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Periodo", Periodo                       )}, // 11
                //'1' SI, '2' NO.
                {++c,    new RegistroCampo(1, 109,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "RegDevolMensual" ,     2,      0        )}, // 12
                // '1' SI (sólo RS),  '2' NO (RG + RS),'3' NO (sólo RG).
                {++c,    new RegistroCampo(1, 110,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ExclusivoRS" ,         3,      0        )}, // 13
                {++c,    new RegistroCampo(1, 111,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "LiqConjunta" ,         2,      0        )}, // 14
                {++c,    new RegistroCampo(1, 112,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ConcursoAcreedores" ,  2,      0        )}, // 15
                {++c,    new RegistroCampo(1, 113,   8,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "FechaConcurso", "00000000"              )}, // 16
                {++c,    new RegistroCampo(1, 121,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "AutoConcurso"                           )}, // 17
                {++c,    new RegistroCampo(1, 122,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ECC" ,                 2,      0        )}, // 18
                {++c,    new RegistroCampo(1, 123,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DestinatarioECC" ,     2,      0        )}, // 19
                {++c,    new RegistroCampo(1, 124,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "OpcionProrrataEspecial" , 2,   0        )}, // 20
                {++c,    new RegistroCampo(1, 125,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "RevocacionProrrataEspecial" , 2, 0      )}, // 21
                {++c,    new RegistroCampo(1, 126,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "01" ,                  0                )}, // 22
                {++c,    new RegistroCampo(1, 143,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "02" ,                  4                )}, // 23
                {++c,    new RegistroCampo(1, 148,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "03" ,                  0                )}, // 24
                {++c,    new RegistroCampo(1, 165,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "04" ,                  0                )}, // 25
                {++c,    new RegistroCampo(1, 182,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "05" ,                  10               )}, // 26
                {++c,    new RegistroCampo(1, 187,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "06" ,                  0                )}, // 27
                {++c,    new RegistroCampo(1, 204,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "07" ,                  0                )}, // 28
                {++c,    new RegistroCampo(1, 221,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "08" ,                  21               )}, // 29
                {++c,    new RegistroCampo(1, 226,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "09" ,                  0                )}, // 30
                {++c,    new RegistroCampo(1, 243,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "10" ,                  0                )}, // 31
                {++c,    new RegistroCampo(1, 260,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "11" ,                  0                )}, // 32
                {++c,    new RegistroCampo(1, 277,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "12" ,                  0                )}, // 33
                {++c,    new RegistroCampo(1, 294,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "13" ,                  0                )}, // 34
                {++c,    new RegistroCampo(1, 311,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "14" ,                  0,   2, true     )}, // 35
                {++c,    new RegistroCampo(1, 328,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "15" ,                  0,   2, true     )}, // 36
                {++c,    new RegistroCampo(1, 345,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "16" ,                  0                )}, // 37
                {++c,    new RegistroCampo(1, 362,  5,   "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "17" ,                  5.2              )}, // 38
                {++c,    new RegistroCampo(1, 367,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "18" ,                  0                )}, // 39
                {++c,    new RegistroCampo(1, 384,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "19" ,                  0                )}, // 40
                {++c,    new RegistroCampo(1, 401,  5,   "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "20" ,                  1.4              )}, // 41
                {++c,    new RegistroCampo(1, 406,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "21" ,                  0                )}, // 42
                {++c,    new RegistroCampo(1, 423,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "22" ,                  0                )}, // 43
                {++c,    new RegistroCampo(1, 440,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "23" ,                  0                )}, // 44
                {++c,    new RegistroCampo(1, 445,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "24" ,                  0                )}, // 45
                {++c,    new RegistroCampo(1, 462,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "25" ,                  0,   2, true     )}, // 46
                {++c,    new RegistroCampo(1, 479,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "26" ,                  0,   2, true     )}, // 47
                {++c,    new RegistroCampo(1, 496,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "27" ,                  0,   2, true     )}, // 48
                {++c,    new RegistroCampo(1, 513,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "28" ,                  0                )}, // 49
                {++c,    new RegistroCampo(1, 530,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "29" ,                  0                )}, // 50
                {++c,    new RegistroCampo(1, 547,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "30" ,                  0                )}, // 51
                {++c,    new RegistroCampo(1, 564,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "31" ,                  0                )}, // 52
                {++c,    new RegistroCampo(1, 581,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "32" ,                  0                )}, // 53
                {++c,    new RegistroCampo(1, 598,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "33" ,                  0                )}, // 54
                {++c,    new RegistroCampo(1, 615,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "34" ,                  0                )}, // 55
                {++c,    new RegistroCampo(1, 632,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "35" ,                  0                )}, // 56
                {++c,    new RegistroCampo(1, 649,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "36" ,                  0                )}, // 57
                {++c,    new RegistroCampo(1, 666,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "37" ,                  0                )}, // 58
                {++c,    new RegistroCampo(1, 683,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "38" ,                  0                )}, // 59
                {++c,    new RegistroCampo(1, 700,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "39" ,                  0                )}, // 60
                {++c,    new RegistroCampo(1, 717,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "40" ,                  0,   2, true     )}, // 61
                {++c,    new RegistroCampo(1, 734,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "41" ,                  0,   2, true     )}, // 62
                {++c,    new RegistroCampo(1, 751,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "42" ,                  0,   2, true     )}, // 63
                {++c,    new RegistroCampo(1, 768,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "43" ,                  0,   2, true     )}, // 64
                {++c,    new RegistroCampo(1, 785,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "44" ,                  0,   2, true     )}, // 65
                {++c,    new RegistroCampo(1, 802,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "45" ,                  0,   2, true     )}, // 66
                {++c,    new RegistroCampo(1, 819,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "46" ,                  0,   2, true     )}, // 67
                {++c,    new RegistroCampo(1, 836,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "VolumenOperacionesArt121"               )}, // 68
                {++c,    new RegistroCampo(1, 837,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ForalConIvaImportPte",2,      0         )}, // 69
                {++c,    new RegistroCampo(1, 838,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "SiiVoluntario",       2,      0         )}, // 70
                {++c,    new RegistroCampo(1, 839,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Exonerado390",        0,      0         )}, // 71
                {++c,    new RegistroCampo(1, 840, 578,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                     )}, // 72
                {++c,    new RegistroCampo(1, 1418, 13,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                     )}, // 73
                {++c,    new RegistroCampo(1, 1431, 12,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      $"</T{Modelo}01000>"          )}  // 74
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
