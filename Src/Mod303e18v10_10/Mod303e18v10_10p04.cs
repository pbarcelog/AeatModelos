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
    
    uede evitar el cumplimiento de lo establecido de lo establecido 
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

namespace AeatModelos.Mod303e18v10_10
{

    /// <summary>
    /// Página 4 modelo 303. Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod303e18v10_10p04 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_10p04(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P04";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                 {++c,     new RegistroCampo(4,    1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"] , "<T")},
                 {++c,     new RegistroCampo(4,    3,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,               303,    0   )},
                 {++c,     new RegistroCampo(4,    6,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,               4000,   0   )},
                 {++c,     new RegistroCampo(4,   11,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,">"                        )},
                 {++c,     new RegistroCampo(4,   12,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "PaginaComplementaria"          )},
                 {++c,     new RegistroCampo(4,   13,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "500"                           )},
                 {++c,     new RegistroCampo(4,   16,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "501"                           )},
                 {++c,     new RegistroCampo(4,   33,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "502"                           )},
                 // 'G', 'E' o blanco.
                 {++c,     new RegistroCampo(4,   50,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "503"                           )},
                 {++c,     new RegistroCampo(4,   51,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "504"                           )},
                 {++c,     new RegistroCampo(4,   56,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "505"                           )},
                 {++c,     new RegistroCampo(4,   59,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "507"                           )},
                 {++c,     new RegistroCampo(4,   76,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "507"                           )},
                 // 'G', 'E' o blanco."
                 {++c,     new RegistroCampo(4,   93,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "508"                           )},
                 {++c,     new RegistroCampo(4,   94,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "509"                           )},
                 {++c,     new RegistroCampo(4,   99,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "510"                           )},
                 {++c,     new RegistroCampo(4,  102,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "511"                           )},
                 {++c,     new RegistroCampo(4,  119,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "512"                           )},
                 {++c,     new RegistroCampo(4,  136,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "513"                           )},
                 {++c,     new RegistroCampo(4,  137,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "514"                           )},
                 {++c,     new RegistroCampo(4,  142,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "515"                           )},
                 {++c,     new RegistroCampo(4,  145,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "516"                           )},
                 {++c,     new RegistroCampo(4,  162,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "517"                           )},
                 {++c,     new RegistroCampo(4,  179,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "518"                           )},
                 {++c,     new RegistroCampo(4,  180,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "519"                           )},
                 {++c,     new RegistroCampo(4,  185,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "520"                           )},
                 {++c,     new RegistroCampo(4,  188,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "521"                           )},
                 {++c,     new RegistroCampo(4,  205,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "522"                           )},
                 {++c,     new RegistroCampo(4,  222,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "523"                           )},
                 {++c,     new RegistroCampo(4,  223,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "524"                           )},
                 {++c,     new RegistroCampo(4,  228,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "700"                           )},
                 {++c,     new RegistroCampo(4,  245,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "701"                           )},
                 {++c,     new RegistroCampo(4,  262,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "702"                           )},
                 {++c,     new RegistroCampo(4,  279,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "703"                           )},
                 {++c,     new RegistroCampo(4,  296,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "704"                           )},
                 {++c,     new RegistroCampo(4,  313,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "705"                           )},
                 {++c,     new RegistroCampo(4,  330,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "706"                           )},
                 {++c,     new RegistroCampo(4,  347,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "707"                           )},
                 {++c,     new RegistroCampo(4,  364,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "708"                           )},
                 {++c,     new RegistroCampo(4,  381,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "709"                           )},
                 {++c,     new RegistroCampo(4,  398,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "710"                           )},
                 {++c,     new RegistroCampo(4,  415,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "711"                           )},
                 {++c,     new RegistroCampo(4,  432,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "712"                           )},
                 {++c,     new RegistroCampo(4,  449,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "713"                           )},
                 {++c,     new RegistroCampo(4,  466,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "714"                           )},
                 {++c,     new RegistroCampo(4,  483,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "715"                           )},
                 {++c,     new RegistroCampo(4,  500,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "716"                           )},
                 {++c,     new RegistroCampo(4,  517,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "717"                           )},
                 {++c,     new RegistroCampo(4,  534,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "718"                           )},
                 {++c,     new RegistroCampo(4,  551,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "719"                           )},
                 {++c,     new RegistroCampo(4,  568,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "720"                           )},
                 {++c,     new RegistroCampo(4,  585,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "721"                           )},
                 {++c,     new RegistroCampo(4,  602,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "722"                           )},
                 {++c,     new RegistroCampo(4,  619,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "723"                           )},
                 {++c,     new RegistroCampo(4,  636,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "724"                           )},
                 {++c,     new RegistroCampo(4,  653,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "725"                           )},
                 {++c,     new RegistroCampo(4,  670,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "726"                           )},
                 {++c,     new RegistroCampo(4,  687,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "727"                           )},
                 {++c,     new RegistroCampo(4,  704,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "728"                           )},
                 {++c,     new RegistroCampo(4,  721,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "729"                           )},
                 {++c,     new RegistroCampo(4,  738,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "730"                           )},
                 {++c,     new RegistroCampo(4,  755,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "731"                           )},
                 {++c,     new RegistroCampo(4,  772,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "732"                           )},
                 {++c,     new RegistroCampo(4,  789,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "733"                           )},
                 {++c,     new RegistroCampo(4,  806,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "734"                           )},
                 {++c,     new RegistroCampo(4,  823,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  "735"                           )},
                 {++c,     new RegistroCampo(4,  840, 672,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                   )},
                 {++c,     new RegistroCampo(4, 1512, 12,   "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],  null,             "</T30304000>")}
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
