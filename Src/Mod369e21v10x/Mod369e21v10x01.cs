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

namespace AeatModelos.Mod369e21v10x
{

    /// <summary>
    /// Página T36901 Ext modelo 369. Diseño de registro: DR369e21.xlsx. T36901 Ext
    /// Prestaciones de servicios.
    /// Régimen exterior de la Unión
    /// </summary>
    public class Mod369e21v10x01 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod369e21v10x01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "369";

            string p = "X01";   // clave página (Prefijo 'X': Régimen exterior de la Unión)
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,     new RegistroCampo(2,    1,   2,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  "<T"                     )}, // 01
                {++c,     new RegistroCampo(2,    3,   3,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,Convert.ToInt32(Modelo),     0             )}, // 02
                {++c,     new RegistroCampo(2,    6,   2,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Pagina",               1,      0               )}, // 03
                {++c,     new RegistroCampo(2,    8,   1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  ">"                      )}, // 04
                {++c,     new RegistroCampo(2,    9,   5,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Regimen",          "VOES"                      )}, // 05
                {++c,     new RegistroCampo(2,   14,   1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Categoria",           "D"                      )}, // 06

                // ["O", "S", "I", "N", "T"]
                // Los valores de ""Tipo de pago"" serán: 
                //  I: Ingreso total,
                //  S: Ingreso parcial,
                //  O: Sin ingreso,
                //  N: Negativa/Pago cero,
                //  T: A Ingresar por transferencia"
                {++c,     new RegistroCampo(2,   15,   1,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "TipoPago" ,           "I"                      )}, // 07
                {++c,     new RegistroCampo(2,   16,  22,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "NRC"                                           )}, // 08
                {++c,     new RegistroCampo(2,   38,  17,    "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Importe pagado",       0                       )}, // 09

                // [blanco | constante "C"]
                {++c,     new RegistroCampo(2,   55,   1,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Complementaria"                                )}, // 10
                {++c,     new RegistroCampo(2,   56,   2,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "DeclarantePais"                                )}, // 11
                {++c,     new RegistroCampo(2,   58,  15,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "DeclaranteNIF"                                 )}, // 12
                {++c,     new RegistroCampo(2,   73,  15,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "DeclaranteNEUOSS"                              )}, // 13
                {++c,     new RegistroCampo(2,   88, 125,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "DeclaranteApellidosNombreRazonSocial."         )}, // 14
                {++c,     new RegistroCampo(2,  213,   4,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Ejercicio"                                     )}, // 15
                {++c,     new RegistroCampo(2,  217,   1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "TipoPeriodo",        "T"                       )}, // 16
                {++c,     new RegistroCampo(2,  218,   2,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Periodo"                                       )}, // 17
                {++c,     new RegistroCampo(2,  220,   1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "SinActividad" ,        0                       )}, // 18

                // 3. Prestaciones de servicios.
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 01
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 02
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 03
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 04
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 05
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 06
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 07
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 08
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 09
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 10
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 11
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 12
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 13
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 14
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 15
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 16
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 17
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 18
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 19
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 20
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 21
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 22
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 23
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 24
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 25
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 26
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 27
                            new Mod369e21v10x01_Item(Ejercicio, Periodo), // 28
                } }                                                                                                                                         },  // 19
                {++c,     new RegistroCampo(2, 1397, 17,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null, new string(' ', 17)                    )}, // 20
                {++c,     new RegistroCampo(2, 1414,  9,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null, $"</T{Modelo}01>"                      )}  // 21
            };

            Registros = RegistroCampos[19] as ConjuntoDeEmpaquetables;

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
