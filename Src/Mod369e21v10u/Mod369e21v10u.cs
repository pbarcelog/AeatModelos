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

using System.Collections.Generic;

namespace AeatModelos.Mod369e21v10u
{

    /// <summary>
    /// Modelo 369 Régimen de la Unión. 
    /// Página 0 modelo 369. Diseño de registro: DR369e21.xlsx.
    /// </summary>
    public class Mod369e21v10u : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod369e21v10u(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "369";

            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod369e21v10u.Mod369e21v10u01"},
                {2, "AeatModelos.Mod369e21v10u.Mod369e21v10u02"},
                {3, "AeatModelos.Mod369e21v10u.Mod369e21v10u03"},
                {4, "AeatModelos.Mod369e21v10u.Mod369e21v10u04"},
                {5, "AeatModelos.Mod369e21v10u.Mod369e21v10u05"},
                {6, "AeatModelos.Mod369e21v10u.Mod369e21v10u06"}
            };

            string p = "000";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                // T3690 Estruc. gral: DR369e21.xlsx
                {++c,    new RegistroCampo(0,   1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<T"                                      )}, // 01
                {++c,    new RegistroCampo(0,   3,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Modelo                                    )}, // 02
                {++c,    new RegistroCampo(0,   6,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0"                                       )}, // 03
                {++c,    new RegistroCampo(0,   7,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Ejercicio                                )}, // 04
                {++c,    new RegistroCampo(0,  11,   2,  "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Periodo                                  )}, // 05
                {++c,    new RegistroCampo(0,  13,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0000>"                                   )}, // 06
                {++c,    new RegistroCampo(0,  18,  92,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 92)                       )}, // 07
                {++c,    new RegistroCampo(0, 110,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIF"                                            )}, // 08
                {++c,    new RegistroCampo(0, 119, 210,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 210)                      )}, // 09

                // T36900 Info Adicional: DR369e21.xlsx
                {++c,    new RegistroCampo(1,   1,   2, "An",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"                      )}, // 10
                {++c,    new RegistroCampo(1,   3,   3, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  369,    0                 )}, // 11
                {++c,    new RegistroCampo(1,   6,   2, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                    0,    0                 )}, // 12
                {++c,    new RegistroCampo(1,   8,   1, "An ",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"                       )}, // 13
                {++c,    new RegistroCampo(1,   9,  93, "An",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   new string(' ', 93)                      )}, // 14
                {++c,    new RegistroCampo(1, 102,   9, "An",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,            $"</T{Modelo}00>"               )}, // 15

                
                // Posibles páginas presentación:
                // T36900 - común siempre se envía
                // Exterior: T36901 a T36903
                // Union: T36904 a T36909
                // Importación: T36910 a T36912
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                    new Mod369e21v10u01(Ejercicio, Periodo)
                } }                                                                                                                                             },  // 16

                // T36909: DR369e21.xlsx
                {++c,    new RegistroCampo(1,   1,   2, "An",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"                      )}, // 17
                {++c,    new RegistroCampo(1,   3,   3, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  369,    0                 )}, // 18
                {++c,    new RegistroCampo(1,   6,   2, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                    9,    0                 )}, // 19
                {++c,    new RegistroCampo(1,   8,   1, "An ",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"                       )}, // 20
                {++c,    new RegistroCampo(1,   9,  5785, "An",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   new string(' ', 5785)                  )}, // 21
                {++c,    new RegistroCampo(1,   6,   1, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null, 0, 0                                       )}, // 22
                {++c,    new RegistroCampo(1, 5795,   9, "An",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,            $"</T{Modelo}09>"              )}, // 23
                {++c,    new RegistroCampo(0,   0,  18,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  $"</T{Modelo}0{Ejercicio}{Periodo}0000>"  )}, // 24
                 

            };

            Paginas = RegistroCampos[16] as ConjuntoDeEmpaquetables;

        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {          
        }

        /// <summary>
        /// Devuelve una cadena con la representación del titular del
        /// certificado que va a realizar la presentación.
        /// </summary>
        public override string Declarante()
        {

            string NIF = $"{Paginas.Empaquetables[0]["DeclaranteNIF"].Valor}";
            string apellidosNombreRazonSocial = $"{Paginas.Empaquetables[0]["DeclaranteApellidosNombreRazonSocial"].Valor}";

            return $"{NIF}, {apellidosNombreRazonSocial}".Trim();

        }

        #endregion

    }
}
