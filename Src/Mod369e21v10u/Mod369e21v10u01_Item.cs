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
    /// Página T36904 Un modelo 369 T36904 Un.  Diseño de registro: DR369e21.xlsx.
    /// Prestaciones de servicios.
    /// Régimen de la Unión
    /// </summary>
    public class Mod369e21v10u01_Item : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod369e21v10u01_Item(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "369";

            string p = "V01";   // clave página (Prefijo 'V': Item de Régimen de la Unión)
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,     new RegistroCampo(2,    1,   2,    "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "CodigoPais"                                )}, // 01
                {++c,     new RegistroCampo(2,    3,   5,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "TipoIva"                                   )}, // 02
                
                // ["R","S"] Los valores de "Prestaciones de servicios. Tipo IVA" serán S:Estándar, R:Reducido
                {++c,     new RegistroCampo(2,    8,   1,    "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "ClaseTipo",                  "S"           )}, // 03
                {++c,     new RegistroCampo(2,    9,  17,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "BaseImponible"                             )}, // 04
                {++c,     new RegistroCampo(2,   26,  17,    "Num ", Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "Cuota"                                     )}  // 05
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
