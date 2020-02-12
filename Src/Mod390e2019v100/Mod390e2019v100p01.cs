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

namespace AeatModelos.Mod390e2019v100
{

    /// <summary>
    /// Página 1 modelo 390.
    /// </summary>
    public class Mod390e2019v100p01 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "001";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,      1,     2,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"        )}, //001
                {++c,    new RegistroCampo(1,      3,     3,  "Num ",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  390,    0   )}, //002
                {++c,    new RegistroCampo(1,      6,     5,  "Num ",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  1000,   0   )}, //003
                {++c,    new RegistroCampo(1,     11,     1,  "An ",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"         )}, //004
                {++c,    new RegistroCampo(1,     12,     1,  "A",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //005
                {++c,    new RegistroCampo(1,     13,     1,  "A",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //006
                {++c,    new RegistroCampo(1,     14,     9,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIF"                              )},  //007
                {++c,    new RegistroCampo(1,     23,    60,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosRazonSocial"             )},  //008
                {++c,    new RegistroCampo(1,     83,    20,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Nombre"                           )},  //009
                {++c,    new RegistroCampo(1,    103,     4,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,     Ejercicio,              0)},  //010
                {++c,    new RegistroCampo(1,    107,     2,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //011
                //Registro de devolución mensual: "0" ó "1"
                {++c,    new RegistroCampo(1,    109,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,     "0"                      )},  //012
                // Regimen especial del grupo de entidades: "0" ó "1"
                {++c,    new RegistroCampo(1,    110,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,     "0"                      )},  //013
                {++c,    new RegistroCampo(1,    111,     7,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //014
                {++c,    new RegistroCampo(1,    118,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,     "0"                      )},  //015
                {++c,    new RegistroCampo(1,    119,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,     "0"                      )},  //016
                // Tipo régimen especial aplicable. Art 163 sexies.cinco. Si o No: "0" - blanco, "1" - Si, "2" .- No
                {++c,    new RegistroCampo(1,    120,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,     "0"                      )},  //017
                {++c,    new RegistroCampo(1,    121,     9,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //018
                // Concurso acreedores en este ejercicio: "0" - blanco, "1" - Si, "2" .- No
                {++c,    new RegistroCampo(1,    130,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ConcursoAcreedoresEjercicio",  "2")},  //019
                // Regimen especial del criterio de caja: "0" - blanco, "1" - Si, "2" .- No
                {++c,    new RegistroCampo(1,    131,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "RegimenEspecialCriterioCaja",  "2")},  //020
                // Ha sido destinatario del régimen especial del criterio de caja: "0" - blanco, "1" - Si, "2" .- No
                {++c,    new RegistroCampo(1,    132,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DestinatarioRegEspCriterioCaj","2")},  //021
                {++c,    new RegistroCampo(1,    133,     1,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //022
                {++c,    new RegistroCampo(1,    134,     1,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //023
                {++c,    new RegistroCampo(1,    135,    13,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //024
                {++c,    new RegistroCampo(1,    148,    40,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DescripActividad"                 )},  //025
                {++c,    new RegistroCampo(1,    188,     1,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ClaveActividad",     null,   0    )},  //026
                {++c,    new RegistroCampo(1,    189,     4,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "EpigrafeActividad"                )},  //027
                {++c,    new RegistroCampo(1,    193,    40,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //028
                {++c,    new RegistroCampo(1,    233,     1,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //029
                {++c,    new RegistroCampo(1,    234,     4,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //030
                {++c,    new RegistroCampo(1,    238,    40,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //031
                {++c,    new RegistroCampo(1,    278,     1,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //032
                {++c,    new RegistroCampo(1,    279,     4,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //033
                {++c,    new RegistroCampo(1,    283,    40,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //034
                {++c,    new RegistroCampo(1,    323,     1,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //035
                {++c,    new RegistroCampo(1,    324,     4,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //036
                {++c,    new RegistroCampo(1,    328,    40,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //037
                {++c,    new RegistroCampo(1,    368,     1,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //038
                {++c,    new RegistroCampo(1,    369,     4,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //039
                {++c,    new RegistroCampo(1,    373,    40,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //040
                {++c,    new RegistroCampo(1,    413,     1,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //041
                {++c,    new RegistroCampo(1,    414,     4,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //042
                // Declaración anual operaciones por terceras personas. "0" - No, "1" .- Sí
                {++c,    new RegistroCampo(1,    418,     1,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Obligado347",     "1"             )},  //043
                {++c,    new RegistroCampo(1,    419,     9,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //044
                {++c,    new RegistroCampo(1,    428,    37,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //045
                {++c,    new RegistroCampo(1,    465,     9,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //046
                {++c,    new RegistroCampo(1,    474,    80,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //047
                {++c,    new RegistroCampo(1,    554,     2,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //048
                {++c,    new RegistroCampo(1,    556,    17,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //049
                {++c,    new RegistroCampo(1,    573,     5,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //050
                {++c,    new RegistroCampo(1,    578,     2,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //051
                {++c,    new RegistroCampo(1,    580,     2,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //052
                {++c,    new RegistroCampo(1,    582,     2,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //053
                {++c,    new RegistroCampo(1,    584,     9,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //054
                {++c,    new RegistroCampo(1,    593,    20,  "A",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //055
                {++c,    new RegistroCampo(1,    613,    15,  "A",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //056
                {++c,    new RegistroCampo(1,    628,     5,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //057
                {++c,    new RegistroCampo(1,    633,    80,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //058
                {++c,    new RegistroCampo(1,    713,     9,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //059
                {++c,    new RegistroCampo(1,    722,     8,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //060
                {++c,    new RegistroCampo(1,    730,    12,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //061
                {++c,    new RegistroCampo(1,    742,    80,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //062
                {++c,    new RegistroCampo(1,    822,     9,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //063
                {++c,    new RegistroCampo(1,    831,     8,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //064
                {++c,    new RegistroCampo(1,    839,    12,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //065
                {++c,    new RegistroCampo(1,    851,    80,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //066
                {++c,    new RegistroCampo(1,    931,     9,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //067
                {++c,    new RegistroCampo(1,    940,     8,  "Num",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //068
                {++c,    new RegistroCampo(1,    948,    12,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //069
                {++c,    new RegistroCampo(1,    960,    21,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //070
                {++c,    new RegistroCampo(1,    981,    13,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //071
                {++c,    new RegistroCampo(1,    994,    20,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //072
                {++c,    new RegistroCampo(1,   1014,   150,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )},  //073
                {++c,    new RegistroCampo(1,   1164,    12,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,        "</T39001000>"        )}   //074

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
