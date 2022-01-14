/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2022 Irene Solutions SL
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

namespace AeatModelos.Mod303e22v100
{

    /// <summary>
    /// Página 3 modelo 303.  Diseño de registro: DR303e22.xlsx.
    /// </summary>
    public class Mod303e22v100p03 : Mod303e21v103.Mod303e21v103p03
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e22v100p03(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P03";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,    1,    2,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      "<T"        )}, //001
                {++c,    new RegistroCampo(1,    3,    3,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      303,    0   )}, //002
                {++c,    new RegistroCampo(1,    6,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      3000,   0   )}, //003
                {++c,    new RegistroCampo(1,   11,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                      ">"         )}, //004
                // Información adicional - Entregas intracomunitarias de bienes y servicios [59].
                {++c,    new RegistroCampo(1,   12,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "59",                      0,   2, true)}, //005
                // Información adicional - Exportaciones y operaciones asimiladas [60].
                {++c,    new RegistroCampo(1,   29,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "60",                      0,   2, true)}, //006
                // Operaciones no sujetas por reglas de localización (excepto las incluidas en la casilla 123) [120].
                {++c,    new RegistroCampo(1,   46,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "120",                      0,   2, true)}, //007
                // Operaciones sujetas con inversión del sujeto pasivo [122]
                {++c,    new RegistroCampo(1,   63,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "122",                      0,   2, true)}, //008
                // OSS. Operaciones no sujetas por reglas de localización acogidas a la OSS [123]
                {++c,    new RegistroCampo(1,   80,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "123",                      0,   2, true)}, //009
                // OSS. Operaciones sujetas y acogidas a la OSS [124]
                {++c,    new RegistroCampo(1,   97,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "124",                      0,   2, true)}, //010
                {++c,    new RegistroCampo(1,  114,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "62",                      0,   2, true)}, //011
                {++c,    new RegistroCampo(1,  131,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "63",                      0,   2, true)}, //012
                {++c,    new RegistroCampo(1,  148,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "74",                      0,   2, true)}, //013
                {++c,    new RegistroCampo(1,  165,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "75",                      0,   2, true)}, //014
                {++c,    new RegistroCampo(1,  192,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "76",                      0,   2, true)}, //015
                {++c,    new RegistroCampo(1,  199,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "64",                      0,   2, true)}, //016

                // Resultado - % Atribuible a la Administración del Estado [65].
                {++c,    new RegistroCampo(1,  216,    5,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "65",                      0,   2      )}, //017
                // Resultado - Atribuible a la Administración del Estado [66].
                {++c,    new RegistroCampo(1,  221,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "66",                      0,   2, true)}, //018
                // Resultado - IVA a la importación liquidado por la Aduana pendiente de ingreso  [77].
                {++c,    new RegistroCampo(1,  238,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "77",                      0,   2      )}, //019
                // Resultado - Cuotas a compensar pendientes de periodos anteriores [110].
                {++c,    new RegistroCampo(1,  255,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "110",                     0,   2      )}, //020
                // Cuotas a compensar de periodos anteriores aplicadas en este periodo [78].
                {++c,    new RegistroCampo(1,  272,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "78",                      0,   2      )}, //021
                // Cuotas a compensar de periodos previos pendientes para periodos posteriores ([110] - [78]) [87].
                {++c,    new RegistroCampo(1,  289,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "87",                      0,   2      )}, //022
                // Resultado - Exclusivamente para sujetos pasivos que tributan conjuntamente a la Administración del Estado y a las Diputaciones Forales 
                // Resultado de la regularización anual [68].
                {++c,    new RegistroCampo(1,  306,   17,  "Num",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "68",                      0,   2      )}, //023
                // Resultado - Resultado ( [66] + [77] - [78] + [68] ) [69].
                {++c,    new RegistroCampo(1,  323,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "69",                      0,   2, true)}, //024
                // Resultado - A deducir [70].
                {++c,    new RegistroCampo(1,  340,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "70",                      0,   2, true)}, //025
                // Resultado - Resultado de la liquidación ( [69] - [70] ) [71].
                {++c,    new RegistroCampo(1,  357,   17,  "N",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "71",                      0,   2, true)}, //026
                // X o blanco.
                {++c,    new RegistroCampo(1,  374,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Complementaria"                       )}, //027
                {++c,    new RegistroCampo(1,  375,   13,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "JustificanteAnterior"                 )}, //028
                // X o blanco.
                {++c,    new RegistroCampo(1,  388,    1,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "SinActividad"                         )}, //029
                {++c,    new RegistroCampo(1,  389,   11,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Swift-Bic"                            )}, //030
                {++c,    new RegistroCampo(1,  400,   34,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "IBAN"                                 )}, //031   
                // Reservado AEAT.
                {++c,    new RegistroCampo(1,  434,   17,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //032                
                {++c,    new RegistroCampo(1,  451,   70,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DevolucionNombreBanco"                )}, //033
                {++c,    new RegistroCampo(1,  521,   35,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DevolucionDireccionBanco"             )}, //034
                {++c,    new RegistroCampo(1,  556,   30,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DevolucionCiudad"                     )}, //035
                {++c,    new RegistroCampo(1,  586,    2,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DevolucionPais"                       )}, //036
                // "0" Vacía, "1" Cuenta España, "2" Unión Europea SEPA, "3" Resto Países
                {++c,    new RegistroCampo(1,  588,   1,  "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DevolucionMarcaSEPA",      0,   0     )}, //037

                {++c,    new RegistroCampo(1,  589,   600,  "An",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                   )}, //038
                {++c,    new RegistroCampo(1, 1189,   12,  "An",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      "</T30303000>"              )}, //039
            };
        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {

            base.Calcular();

        }

        #endregion

    }
}
