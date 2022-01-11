/*
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
    /// Página 4 modelo 303.  Diseño de registro: DR303e21v103.xlsx.
    /// Añade campos reservados para la AEAT, modifica casilla 93 de intracomunitarias exentas a bienes y servicios y
    /// modifica casillas a complimentar como complementaria respecto a la versión anterior.
    /// </summary>
    public class Mod303e21v103p04 : RegistroModPagina
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e21v103p04(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
            string p = "P04";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,    1,    2,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      "<T"        )}, //001
                {++c,    new RegistroCampo(1,    3,    3,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      303,    0   )}, //002
                {++c,    new RegistroCampo(1,    6,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      4000,   0   )}, //003
                {++c,    new RegistroCampo(1,   11,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      ">"         )}, //004
                {++c,    new RegistroCampo(1,   12,    1,  "A",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //005
                {++c,    new RegistroCampo(1,   13,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "PrincipalClaveB",          0,     0   )}, //006
                {++c,    new RegistroCampo(1,   14,    4,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "PrincipalEpigrafeIAE"                 )}, //007
                {++c,    new RegistroCampo(1,   18,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras01ClaveB"                        )}, //008
                {++c,    new RegistroCampo(1,   19,    4,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras01EpigrafeIAE"                   )}, //009
                {++c,    new RegistroCampo(1,   23,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras02ClaveB"                        )}, //010
                {++c,    new RegistroCampo(1,   24,    4,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras02EpigrafeIAE"                   )}, //011
                {++c,    new RegistroCampo(1,   28,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras03ClaveB"                        )}, //012
                {++c,    new RegistroCampo(1,   29,    4,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras03EpigrafeIAE"                   )}, //013
                {++c,    new RegistroCampo(1,   33,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras04ClaveB"                        )}, //014
                {++c,    new RegistroCampo(1,   34,    4,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras04EpigrafeIAE"                   )}, //015
                {++c,    new RegistroCampo(1,   38,    1,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras05ClaveB"                        )}, //016
                {++c,    new RegistroCampo(1,   39,    4,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Otras05EpigrafeIAE"                   )}, //017
                // Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA:
                // D - Marque si ha efectuado operaciones por las que tenga obligación de presentar la declaración anual de operaciones con terceras personas.
                // X o blanco.
                {++c,    new RegistroCampo(1,   43,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "OperacionesTercerasPersonas"          )}, //018
                // Información de la tributación por razón de territorio: Álava [89].
                {++c,    new RegistroCampo(1,   44,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "89",                      0,   2      )}, //019
                // Información de la tributación por razón de territorio: Guipuzcoa [90].
                {++c,    new RegistroCampo(1,   49,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "90",                      0,   2      )}, //020
                // Información de la tributación por razón de territorio: Vizcaya [91].
                {++c,    new RegistroCampo(1,   54,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "91",                      0,   2      )}, //021
                // Información de la tributación por razón de territorio: Navarra [92].
                {++c,    new RegistroCampo(1,   59,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "92",                      0,   2      )}, //022
                // Información de la tributación por razón de territorio: Territorio común [107].
                {++c,    new RegistroCampo(1,   64,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "107",                     0,   2      )}, //023

                // *** INICIO: Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA *** 
                // *** Operaciones realizadas en el ejercicio - ***
                // Operaciones en régimen general [80].
                {++c,    new RegistroCampo(1,   69,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "80",                      0,   2, true)}, //024
                // Operaciones en régimen especial del criterio de caja conforme art. 75 LIVA [81].
                {++c,    new RegistroCampo(1,   86,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "81",                      0,   2, true)}, //025
                // Entregas intracomunitarias de bienes y servicios [93].
                {++c,    new RegistroCampo(1,  103,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "93",                      0,   2, true)}, //026
                // Exportaciones y otras operaciones exentas con derecho a deducción [94].
                {++c,    new RegistroCampo(1,  120,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "94",                      0,   2, true)}, //027
                // Operaciones exentas sin derecho a deducción [83].
                {++c,    new RegistroCampo(1,  137,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "83",                      0,   2, true)}, //028
                // Operaciones no sujetas por reglas de localización o con inversión del sujeto pasivo [84].
                {++c,    new RegistroCampo(1,  154,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "84",                      0,   2, true)}, //029
                // Entregas de bienes objeto de instalación o montaje en otros Estados miembros [85].
                {++c,    new RegistroCampo(1,  171,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "85",                      0,   2, true)}, //030
                // Reservado AEAT.
                {++c,    new RegistroCampo(1,  188,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //031
                {++c,    new RegistroCampo(1,  205,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //032
                {++c,    new RegistroCampo(1,  222,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //033
                // Operaciones en régimen simplificado [86].
                {++c,    new RegistroCampo(1,  239,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "86",                      0,   2, true)}, //034
                // Operaciones en régimen especial de la agricultura, ganadería y pesca [95].
                {++c,    new RegistroCampo(1,  256,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "95",                      0,   2, true)}, //035
                // Operaciones realizadas por sujetos pasivos acogidos al régimen especial del recargo de equivalencia [96].
                {++c,    new RegistroCampo(1,  273,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "96",                      0,   2, true)}, //036
                // Operaciones en Régimen especial de bienes usados, objetos de arte, antigüedades y objetos de colección [97].
                {++c,    new RegistroCampo(1,  290,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "97",                      0,   2, true)}, //037
                // Operaciones en régimen especial de Agencias de Viajes [98].
                {++c,    new RegistroCampo(1,  307,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "98",                      0,   2, true)}, //038
                // Entregas de bienes inmuebles no habituales, operaciones financieras y relativas al oro de inversión no habituales [79].
                {++c,    new RegistroCampo(1,  324,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "79",                      0,   2, true)}, //039
                // Entregas de bienes de inversión [99].
                {++c,    new RegistroCampo(1,  341,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "99",                      0,   2, true)}, //040
                // Total volumen de operaciones ([80]+[81]+[93]+[94]+[83]+[84]+[85]+[86]+[95]+[96]+[97]+[98]-[79]-[99]) [88].
                {++c,    new RegistroCampo(1,  358,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "88",                      0,   2, true)}, //041
                // *** FINAL: Información adicional - Exclusivamente a cumplimentar en el último periodo exonerados de la Declaración-resumen anual del IVA *** 
                // *** Operaciones realizadas en el ejercicio - ***

                // Reservado AEAT.
                {++c,    new RegistroCampo(1,  375,  600,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //042
                {++c,    new RegistroCampo(1,  975,   12,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      "</T30304000>"              )}, //043
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
