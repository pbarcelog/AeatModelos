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

namespace AeatModelos.Mod369e21v10u
{

    /// <summary>
    /// Página T36909 Un modelo 369. Diseño de registro: DR369e21.xlsx. 
    /// Reservado.
    /// Régimen de la Unión
    /// </summary>
    public class Mod369e21v10u06 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod369e21v10u06(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "369";

            string p = "U06";   // clave página (Prefijo 'U': Régimen de la Unión)
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,     new RegistroCampo(2,    1,    2,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  "<T"                    )}, // 01
                {++c,     new RegistroCampo(2,    3,    3,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null, Convert.ToInt32(Modelo),     0           )}, // 02
                {++c,     new RegistroCampo(2,    6,    2,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Pagina",               9,      0              )}, // 03
                {++c,     new RegistroCampo(2,    8,    1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null,                  ">"                     )}, // 04
                {++c,     new RegistroCampo(2,    9,    1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Complementaria"                               )}, // 05
                {++c,     new RegistroCampo(2,   10, 5785,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null, new string(' ', 17)                      )}, // 06
                {++c,     new RegistroCampo(2, 5795,    9,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], null, $"</T{Modelo}09>"                        )}  // 07
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
