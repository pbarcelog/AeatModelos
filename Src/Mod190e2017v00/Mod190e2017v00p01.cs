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

using System.Collections.Generic;

namespace AeatModelos.Mod190e2017v00
{
    /// <summary>
    /// Tipo 2 modelo 190. Diseño de registro: DR190_2017.pdf.
    /// </summary>
    public class Mod190e2017v00p01 : RegistroModPagina
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod190e2017v00p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "001";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "1"                     )}, // 01
                {++c,    new RegistroCampo(1,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "190"                   )}, // 02
                {++c,    new RegistroCampo(1,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Ejercicio               )}, // 03
                {++c,    new RegistroCampo(1,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDeclarante"                )}, // 04
                {++c,    new RegistroCampo(1,  18,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFPerceptor"                 )}, //005
                {++c,    new RegistroCampo(1,  27,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFRepresentanteLegal"        )}, //006
                // APELLIDOS Y NOMBRE O DENOMINACIÓN DEL PERCEPTOR. Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(1,  36,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreDenominacion"  )}, //007
                // CÓDIGO PROVINCIA.
                {++c,    new RegistroCampo(1,  76,   2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //008
                // CLAVE DE PERCEPCIÓN.
                {++c,    new RegistroCampo(1,  78,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //009
                // SUBCLAVE DE PERCEPCIÓN.
                {++c,    new RegistroCampo(1,  79,   2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //010
                // PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA
                {++c,    new RegistroCampo(1,  81,  14,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //011
                // PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. RETENCIONES PRACTICADAS
                {++c,    new RegistroCampo(1,  95,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //012
                // PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN
                {++c,    new RegistroCampo(1, 108,  14,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //013
                // PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA EFECTUADOS
                {++c,    new RegistroCampo(1, 122,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //014
                // PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA REPERCUTIDOS
                {++c,    new RegistroCampo(1, 135,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //015
                // EJERCICIO DEVENGO
                {++c,    new RegistroCampo(1, 148,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //016
                // RENTAS OBTENIDAS EN CEUOTA O MELILLA: "0": NO. "1": SÍ
                {++c,    new RegistroCampo(1, 152,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //017
                // DATOS ADICIONALES (solo en las claves A, B.01, B.03, C, E.01 y E.02).
                // AÑO DE NACIMIENTO. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 153,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //018
                // SITUACIÓN FAMILIAR. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 157,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //019
                // NIF DEL CÓNYUGE. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 158,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //020
                // DISCAPACIDAD. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 167,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //021
                // CONTRATO O RELACIÓN. Solo para percepciones correspondientes a la clave A.
                {++c,    new RegistroCampo(1, 168,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //022
                // -
                {++c,    new RegistroCampo(1, 169,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //023
                // MOVILIDAD GEOGRÁFICA. Solo para percepciones correspondientes a la clave A.
                {++c,    new RegistroCampo(1, 170,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //024
                // REDUCCIONES APLICABLES. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 171,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //025
                // GASTOS DEDUCIBLES. Solo para percepciones correspondientes a las claves A, B.01, B.03, C, E.01 y E.02.
                {++c,    new RegistroCampo(1, 184,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //026
                // PENSIONES COMPENSATORIAS. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 197,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //027
                // ANUALIDADES POR ALIMENTOS. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 210,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //028
                // HIJOS Y OTROS DESCENDIENTES. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 229,  12,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //029
                // ASCENDIENTES. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 241,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //030
                // ASCENDIENTES CON DISCAPACIDAD. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 245,   6,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //031
                // CÓMPUTO DE LOS 3 PRIMEROS HIJOS. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 251,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //032
                // COMUNICACIÓN PRÉSTAMOS VIVIENDA HABITUAL. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 254,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //033
                // PERCEPCIONES DINERARIAS DERIVADAS DE INCAPACIDAD LABORAL. Solo para percepciones correspondientes a las claves A y B.01.
                {++c,    new RegistroCampo(1, 255,  27,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //034
                {++c,    new RegistroCampo(1, 311,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "14" ,                  0,   2, true)}, //035
                {++c,    new RegistroCampo(1, 328,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "15" ,                  0,   2, true)}, //036
                {++c,    new RegistroCampo(1, 345,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "16" ,                  0           )}, //037
                {++c,    new RegistroCampo(1, 362,  5,   "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "17" ,                  5.2         )}, //038
                {++c,    new RegistroCampo(1, 367,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "18" ,                  0           )}, //039
                {++c,    new RegistroCampo(1, 384,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "19" ,                  0           )}, //040
                {++c,    new RegistroCampo(1, 401,  5,   "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "20" ,                  1.4         )}, //041
                {++c,    new RegistroCampo(1, 406,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "21" ,                  0           )}, //042
                {++c,    new RegistroCampo(1, 423,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "22" ,                  0           )}, //043
                {++c,    new RegistroCampo(1, 440,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "23" ,                  0           )}, //044
                {++c,    new RegistroCampo(1, 445,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "24" ,                  0           )}, //045
                {++c,    new RegistroCampo(1, 462,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "25" ,                  0,   2, true)}, //046
                {++c,    new RegistroCampo(1, 479,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "26" ,                  0,   2, true)}, //047
                {++c,    new RegistroCampo(1, 496,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "27" ,                  0,   2, true)}, //048
                {++c,    new RegistroCampo(1, 513,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "28" ,                  0           )}, //049
                {++c,    new RegistroCampo(1, 530,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "29" ,                  0           )}, //050
                {++c,    new RegistroCampo(1, 547,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "30" ,                  0           )}, //051
                {++c,    new RegistroCampo(1, 564,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "31" ,                  0           )}, //052
                {++c,    new RegistroCampo(1, 581,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "32" ,                  0           )}, //053
                {++c,    new RegistroCampo(1, 598,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "33" ,                  0           )}, //054
                {++c,    new RegistroCampo(1, 615,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "34" ,                  0           )}, //055
                {++c,    new RegistroCampo(1, 632,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "35" ,                  0           )}, //056
                {++c,    new RegistroCampo(1, 649,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "36" ,                  0           )}, //057
                {++c,    new RegistroCampo(1, 666,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "37" ,                  0           )}, //058
                {++c,    new RegistroCampo(1, 683,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "38" ,                  0           )}, //059
                {++c,    new RegistroCampo(1, 700,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "39" ,                  0           )}, //060
                {++c,    new RegistroCampo(1, 717,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "40" ,                  0,   2, true)}, //061
                {++c,    new RegistroCampo(1, 734,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "41" ,                  0,   2, true)}, //062
                {++c,    new RegistroCampo(1, 751,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "42" ,                  0,   2, true)}, //063
                {++c,    new RegistroCampo(1, 768,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "43" ,                  0,   2, true)}, //064
                {++c,    new RegistroCampo(1, 785,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "44" ,                  0,   2, true)}, //065
                {++c,    new RegistroCampo(1, 802,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "45" ,                  0,   2, true)}, //066
                {++c,    new RegistroCampo(1, 819,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "46" ,                  0,   2, true)}, //067
                {++c,    new RegistroCampo(1, 836,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "VolumenOperacionesArt121"          )}, //068
                {++c,    new RegistroCampo(1, 837,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ForalConIvaImportPte",2,      0    )}, //069
                {++c,    new RegistroCampo(1, 838,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "SiiVoluntario",       2,      0    )}, //070
                {++c,    new RegistroCampo(1, 839,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Exonerado390",        0,      0    )}, //071
                {++c,    new RegistroCampo(1, 840, 578,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                )}, //072
                {++c,    new RegistroCampo(1, 1418, 13,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                )}, //073
                {++c,    new RegistroCampo(1, 1431, 12,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      "</T30301000>"           )}  //074
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
