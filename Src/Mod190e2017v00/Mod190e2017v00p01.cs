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

namespace AeatModelos.Mod190e2017v00
{
    /// <summary>
    /// Tipo 2 modelo 190. Diseño de registro: DR190_2017.pdf.
    /// </summary>
    public class Mod190e2017v00p01 : RegistroModPagina
    {

        #region Construtores de Instancia

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
                {++c,    new RegistroCampo(1,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  2,      0               )}, // 01
                {++c,    new RegistroCampo(1,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  190,      0             )}, // 02
                {++c,    new RegistroCampo(1,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Ejercicio,      0       )}, // 03
                {++c,    new RegistroCampo(1,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDeclarante"                )}, // 04
                {++c,    new RegistroCampo(1,  18,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFPerceptor"                 )}, //005
                {++c,    new RegistroCampo(1,  27,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFRepresentanteLegal"        )}, //006
                // APELLIDOS Y NOMBRE O DENOMINACIÓN DEL PERCEPTOR. Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(1,  36,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreDenominacion"  )}, //007
                // CÓDIGO PROVINCIA.
                {++c,    new RegistroCampo(1,  76,   2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Provincia", null, 0           )}, //008
                // CLAVE DE PERCEPCIÓN.
                {++c,    new RegistroCampo(1,  78,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ClavePercepcion"              )}, //009
                // SUBCLAVE DE PERCEPCIÓN.
                {++c,    new RegistroCampo(1,  79,   2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "SubClavePercepcion", null, 0  )}, //010
                // PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA. SIGNO NEGATIVO: "N". EN OTRO CASO SERÁ UN ESPACIO.
                {++c,    new RegistroCampo(1,  81,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //011
                // PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA
                {++c,    new RegistroCampo(1,  82,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,    null,     2           )}, //012
                // PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. RETENCIONES PRACTICADAS
                {++c,    new RegistroCampo(1,  95,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //013
                // PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN. SIGNO NEGATIVO: "N". EN OTRO CASO SERÁ UN ESPACIO.
                {++c,    new RegistroCampo(1, 108,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //014
                // PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN
                {++c,    new RegistroCampo(1, 109,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,    null,     2           )}, //015
                // PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA EFECTUADOS
                {++c,    new RegistroCampo(1, 122,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //016
                // PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA REPERCUTIDOS
                {++c,    new RegistroCampo(1, 135,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //017
                // EJERCICIO DEVENGO
                {++c,    new RegistroCampo(1, 148,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //018
                // RENTAS OBTENIDAS EN CEUOTA O MELILLA: "0": NO. "1": SÍ
                {++c,    new RegistroCampo(1, 152,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //019
                // DATOS ADICIONALES (solo en las claves A, B.01, B.03, C, E.01 y E.02).
                // AÑO DE NACIMIENTO. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 153,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //020
                // SITUACIÓN FAMILIAR. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 157,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //021
                // NIF DEL CÓNYUGE. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 158,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //022
                // DISCAPACIDAD. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 167,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //023
                // CONTRATO O RELACIÓN. Solo para percepciones correspondientes a la clave A.
                {++c,    new RegistroCampo(1, 168,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //024
                // -
                {++c,    new RegistroCampo(1, 169,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //025
                // MOVILIDAD GEOGRÁFICA. Solo para percepciones correspondientes a la clave A.
                {++c,    new RegistroCampo(1, 170,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //026
                // REDUCCIONES APLICABLES. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 171,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //027
                // GASTOS DEDUCIBLES. Solo para percepciones correspondientes a las claves A, B.01, B.03, C, E.01 y E.02.
                {++c,    new RegistroCampo(1, 184,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //028
                // PENSIONES COMPENSATORIAS. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 197,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //029
                // ANUALIDADES POR ALIMENTOS. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 210,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //030
                // HIJOS Y OTROS DESCENDIENTES. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 223,   6,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //031
                // HIJOS Y OTROS DESCENDIENTES CON DISCAPACIDAD. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 229,  12,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //032
                // ASCENDIENTES. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 241,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //033
                // ASCENDIENTES CON DISCAPACIDAD. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 245,   6,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //034
                // CÓMPUTO DE LOS 3 PRIMEROS HIJOS. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 251,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //035
                // COMUNICACIÓN PRÉSTAMOS VIVIENDA HABITUAL. Solo para percepciones correspondientes a las claves A, B.01, B.03 y C.
                {++c,    new RegistroCampo(1, 254,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  null,      0            )}, //036
                // PERCEPCIONES DINERARIAS DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA (Dineraria) DERIVADA DE INCAPACIDAD LABORAL
                // Solo para percepciones correspondientes a las claves A y B.01. SIGNO NEGATIVO: "N". EN OTRO CASO SERÁ UN ESPACIO.
                {++c,    new RegistroCampo(1, 255,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //037
                // PERCEPCIONES DINERARIAS DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA (Dineraria) DERIVADA DE INCAPACIDAD LABORAL
                // Solo para percepciones correspondientes a las claves A y B.01.
                {++c,    new RegistroCampo(1, 256,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,    null,     2           )}, //038
                // PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: RETENCIONES PRACTICADAS SOBRE PRESTACIONES DERIVADAS DE INCAPACIDAD LABORAL
                // Solo para percepciones correspondientes a las claves A y B.01.
                {++c,    new RegistroCampo(1, 269,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //039
                // PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN DE LA PERCEPCIÓN EN ESPECIE DERIVADA DE INCAPACIDAD LABORAL
                // Solo para percepciones correspondientes a la clave A. SIGNO NEGATIVO: "N". EN OTRO CASO SERÁ UN ESPACIO.
                {++c,    new RegistroCampo(1, 282,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //040
                // PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN DE LA PERCEPCIÓN EN ESPECIE DERIVADA DE INCAPACIDAD LABORAL
                // Solo para percepciones correspondientes a la clave A.
                {++c,    new RegistroCampo(1, 283,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,    null,     2           )}, //041
                // PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA EFECTUADOS POR PRESTACIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL
                // Solo para percepciones correspondientes a la clave A.
                {++c,    new RegistroCampo(1, 296,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //042
                // PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA REPERCUTIDOS POR PRESTACIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL
                // Solo para percepciones correspondientes a la clave A.
                {++c,    new RegistroCampo(1, 309,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, //043
                // BLANCOS.
                {++c,    new RegistroCampo(1, 322,  179, "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}  //044
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
