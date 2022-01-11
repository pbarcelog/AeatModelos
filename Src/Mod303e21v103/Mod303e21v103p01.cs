﻿/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2021 Irene Solutions SL
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

using System.Collections.Generic;

namespace AeatModelos.Mod303e21v103
{
    /// <summary>
    /// Página 1 modelo 303.  Diseño de registro: DR303e21v103.xlsx.
    /// Casillas reordenadas y unifica casilla "Apellidos" con "Nombre" respecto a la versión anterior.
    /// </summary>
    public class Mod303e21v103p01 : RegistroModPagina
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e21v103p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,    2,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      "<T"        )}, //001
                {++c,    new RegistroCampo(1,   3,    3,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      303,    0   )}, //002
                {++c,    new RegistroCampo(1,   6,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      1000,   0   )}, //003
                {++c,    new RegistroCampo(1,  11,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      ">"         )}, //004
                {++c,    new RegistroCampo(1,  12,    1,  "A",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //005

                // PI :El tipo de declaración puede ser: C (solicitud de compensación) D (devolución) G (cuenta corriente tributaria-ingreso) 
                // I (ingreso) N (sin actividad/resultado cero) V (cuenta corriente tributaria -devolución) U (domiciliacion del ingreso en CCC)
                {++c,    new RegistroCampo(1,  13,    1,  "A",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoDeclaracion" ,        "I"         )}, //006
                {++c,    new RegistroCampo(1,  14,    9,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIF"                                  )}, //007
                {++c,    new RegistroCampo(1,  23,   80,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreRazonSocial"           )}, //008
                {++c,    new RegistroCampo(1, 103,    4,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Ejercicio" ,           Ejercicio, 0   )}, //009
                {++c,    new RegistroCampo(1, 107,    2,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Periodo", Periodo                     )}, //010
                // '1' SI, '2' NO.
                {++c,    new RegistroCampo(1, 109,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ForalConIvaImportPte",     2,     0   )}, //011
                //'1' SI, '2' NO.
                {++c,    new RegistroCampo(1, 110,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "RegDevolMensual" ,         2,     0   )}, //012
                // '1' SI (sólo RS),  '2' NO (RG + RS),'3' NO (sólo RG).
                {++c,    new RegistroCampo(1, 111,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ExclusivoRS" ,             3,     0   )}, //013
                {++c,    new RegistroCampo(1, 112,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "LiqConjunta" ,             2,     0   )}, //014
                {++c,    new RegistroCampo(1, 113,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ECC" ,                     2,     0   )}, //015
                {++c,    new RegistroCampo(1, 114,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DestinatarioECC" ,         2,     0   )}, //016
                {++c,    new RegistroCampo(1, 115,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "OpcionProrrataEspecial" ,  2,     0   )}, //017
                {++c,    new RegistroCampo(1, 116,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "RevocacionProrrataEspecial" , 2,  0   )}, //018
                {++c,    new RegistroCampo(1, 117,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ConcursoAcreedores" ,      2,     0   )}, //019
                {++c,    new RegistroCampo(1, 118,    8,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "FechaConcurso",    "00000000"         )}, //020
                {++c,    new RegistroCampo(1, 126,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "AutoConcurso"                         )}, //021
                {++c,    new RegistroCampo(1, 127,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "SiiVoluntario",            2,     0   )}, //022
                {++c,    new RegistroCampo(1, 128,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Exonerado390",             0,     0   )}, //023
                {++c,    new RegistroCampo(1, 129,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "VolumenOperacionesArt121", 0,     0   )}, //024
                {++c,    new RegistroCampo(1, 130,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "01" ,                     0           )}, //025
                {++c,    new RegistroCampo(1, 147,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "02" ,                     4           )}, //026
                {++c,    new RegistroCampo(1, 152,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "03" ,                     0           )}, //027
                {++c,    new RegistroCampo(1, 169,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "04" ,                     0           )}, //028
                {++c,    new RegistroCampo(1, 186,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "05" ,                     10          )}, //029
                {++c,    new RegistroCampo(1, 191,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "06" ,                     0           )}, //030
                {++c,    new RegistroCampo(1, 208,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "07" ,                     0           )}, //031
                {++c,    new RegistroCampo(1, 225,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "08" ,                     21          )}, //032
                {++c,    new RegistroCampo(1, 230,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "09" ,                     0           )}, //033
                {++c,    new RegistroCampo(1, 247,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "10" ,                     0           )}, //034
                {++c,    new RegistroCampo(1, 264,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "11" ,                     0           )}, //035
                {++c,    new RegistroCampo(1, 281,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "12" ,                     0           )}, //036
                {++c,    new RegistroCampo(1, 298,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "13" ,                     0           )}, //037
                {++c,    new RegistroCampo(1, 315,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "14" ,                     0,   2, true)}, //038
                {++c,    new RegistroCampo(1, 332,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "15" ,                     0,   2, true)}, //039
                {++c,    new RegistroCampo(1, 349,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "16" ,                     0           )}, //040
                {++c,    new RegistroCampo(1, 366,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "17" ,                     5.2         )}, //041
                {++c,    new RegistroCampo(1, 371,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "18" ,                     0           )}, //042
                {++c,    new RegistroCampo(1, 388,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "19" ,                     0           )}, //043
                {++c,    new RegistroCampo(1, 405,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "20" ,                     1.4         )}, //044
                {++c,    new RegistroCampo(1, 410,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "21" ,                     0           )}, //045
                {++c,    new RegistroCampo(1, 427,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "22" ,                     0           )}, //046
                {++c,    new RegistroCampo(1, 444,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "23" ,                     0           )}, //047
                {++c,    new RegistroCampo(1, 449,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "24" ,                     0           )}, //048
                {++c,    new RegistroCampo(1, 466,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "25" ,                     0,   2, true)}, //049
                {++c,    new RegistroCampo(1, 483,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "26" ,                     0,   2, true)}, //050
                {++c,    new RegistroCampo(1, 500,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "27" ,                     0,   2, true)}, //051
                {++c,    new RegistroCampo(1, 517,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "28" ,                     0           )}, //052
                {++c,    new RegistroCampo(1, 534,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "29" ,                     0           )}, //053
                {++c,    new RegistroCampo(1, 551,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "30" ,                     0           )}, //054
                {++c,    new RegistroCampo(1, 568,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "31" ,                     0           )}, //055
                {++c,    new RegistroCampo(1, 585,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "32" ,                     0           )}, //056
                {++c,    new RegistroCampo(1, 602,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "33" ,                     0           )}, //057
                {++c,    new RegistroCampo(1, 619,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "34" ,                     0           )}, //058
                {++c,    new RegistroCampo(1, 636,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "35" ,                     0           )}, //059
                {++c,    new RegistroCampo(1, 653,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "36" ,                     0           )}, //060
                {++c,    new RegistroCampo(1, 670,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "37" ,                     0           )}, //061
                {++c,    new RegistroCampo(1, 687,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "38" ,                     0           )}, //062
                {++c,    new RegistroCampo(1, 704,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "39" ,                     0           )}, //063
                {++c,    new RegistroCampo(1, 721,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "40" ,                     0,   2, true)}, //064
                {++c,    new RegistroCampo(1, 738,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "41" ,                     0,   2, true)}, //065
                {++c,    new RegistroCampo(1, 755,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "42" ,                     0,   2, true)}, //066
                {++c,    new RegistroCampo(1, 772,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "43" ,                     0,   2, true)}, //067
                {++c,    new RegistroCampo(1, 789,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "44" ,                     0,   2, true)}, //068
                {++c,    new RegistroCampo(1, 806,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "45" ,                     0,   2, true)}, //069
                {++c,    new RegistroCampo(1, 823,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "46" ,                     0,   2, true)}, //070
                {++c,    new RegistroCampo(1, 840,  600,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //071
                {++c,    new RegistroCampo(1,1440,   13,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //072
                {++c,    new RegistroCampo(1,1453,   12,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      "</T30301000>"              )}, //073
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
