/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2018 Irene Solutions SL
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

namespace AeatModelos.Mod303e18v10_10
{

    /// <summary>
    /// Página 1 modelo 303.  Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod303e18v10_10p01 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_10p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   2, "An",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"        )},
                {++c,    new RegistroCampo(1,   3,   3, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  303,    0   )},
                {++c,    new RegistroCampo(1,   6,   5, "Num ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  1000,   0   )},
                {++c,    new RegistroCampo(1,  11,   1, "An ",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"         )},
                {++c,    new RegistroCampo(1,  12,   1, "A",     Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                )},

                // PI :El tipo de declaración puede ser: C (solicitud de compensación) 
                // D (devolución) G (cuenta corriente tributaria-ingreso) I (ingreso) 
                // N (sin actividad/resultado cero) V (cuenta corriente tributaria -devolución)
                // U (domiciliacion del ingreso en CCC)
                {++c,    new RegistroCampo(1,  13,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoDeclaracion" ,     "I"         )},
                {++c,    new RegistroCampo(1,  14,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIF"                               )},
                {++c,    new RegistroCampo(1,  23,  60,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosRazonSocial"              )},
                {++c,    new RegistroCampo(1,  83,  20,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Nombre"                            )},
                {++c,    new RegistroCampo(1, 103,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Ejercicio" ,           Ejercicio, 0)},
                {++c,    new RegistroCampo(1, 107,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Periodo", Periodo                   )},
                //'1' SI, '2' NO.
                {++c,    new RegistroCampo(1, 109,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "RegDevolMensual" ,     2,      0   )},
                // '1' SI (sólo RS),  '2' NO (RG + RS),'3' NO (sólo RG).
                {++c,    new RegistroCampo(1, 110,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ExclusivoRS" ,         3,      0   )},
                {++c,    new RegistroCampo(1, 111,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "LiqConjunta" ,         2,      0   )},
                {++c,    new RegistroCampo(1, 112,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ConcursoAcreedores" ,  2,      0   )},
                {++c,    new RegistroCampo(1, 113,   8,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "FechaConcurso", "00000000"         )},
                {++c,    new RegistroCampo(1, 121,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "AutoConcurso"                      )},
                {++c,    new RegistroCampo(1, 122,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ECC" ,                 2,      0   )},
                {++c,    new RegistroCampo(1, 123,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "DestinatarioECC" ,     2,      0   )},
                {++c,    new RegistroCampo(1, 124,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "OpcionProrrataEspecial" , 2,   0   )},
                {++c,    new RegistroCampo(1, 125,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "RevocacionProrrataEspecial" , 2, 0 )},
                {++c,    new RegistroCampo(1, 126,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "01" ,                  0           )},
                {++c,    new RegistroCampo(1, 143,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "02" ,                  4           )},
                {++c,    new RegistroCampo(1, 148,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "03" ,                  0           )},
                {++c,    new RegistroCampo(1, 165,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "04" ,                  0           )},
                {++c,    new RegistroCampo(1, 182,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "05" ,                  10          )},
                {++c,    new RegistroCampo(1, 187,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "06" ,                  0           )},
                {++c,    new RegistroCampo(1, 204,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "07" ,                  0           )},
                {++c,    new RegistroCampo(1, 221,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "08" ,                  21          )},
                {++c,    new RegistroCampo(1, 226,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "09" ,                  0           )},
                {++c,    new RegistroCampo(1, 243,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "10" ,                  0           )},
                {++c,    new RegistroCampo(1, 260,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "11" ,                  0           )},
                {++c,    new RegistroCampo(1, 277,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "12" ,                  0           )},
                {++c,    new RegistroCampo(1, 294,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "13" ,                  0           )},
                {++c,    new RegistroCampo(1, 311,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "14" ,                  0           )},
                {++c,    new RegistroCampo(1, 328,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "15" ,                  0           )},
                {++c,    new RegistroCampo(1, 345,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "16" ,                  0           )},
                {++c,    new RegistroCampo(1, 362,  5,   "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "17" ,                  5.2         )},
                {++c,    new RegistroCampo(1, 367,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "18" ,                  0           )},
                {++c,    new RegistroCampo(1, 384,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "19" ,                  0           )},
                {++c,    new RegistroCampo(1, 401,  5,   "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "20" ,                  1.4         )},
                {++c,    new RegistroCampo(1, 406,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "21" ,                  0           )},
                {++c,    new RegistroCampo(1, 423,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "22" ,                  0           )},
                {++c,    new RegistroCampo(1, 440,   5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "23" ,                  0           )},
                {++c,    new RegistroCampo(1, 445,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "24" ,                  0           )},
                {++c,    new RegistroCampo(1, 462,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "25" ,                  0           )},
                {++c,    new RegistroCampo(1, 479,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "26" ,                  0           )},
                {++c,    new RegistroCampo(1, 496,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "27" ,                  0           )},
                {++c,    new RegistroCampo(1, 513,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "28" ,                  0           )},
                {++c,    new RegistroCampo(1, 530,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "29" ,                  0           )},
                {++c,    new RegistroCampo(1, 547,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "30" ,                  0           )},
                {++c,    new RegistroCampo(1, 564,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "31" ,                  0           )},
                {++c,    new RegistroCampo(1, 581,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "32" ,                  0           )},
                {++c,    new RegistroCampo(1, 598,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "33" ,                  0           )},
                {++c,    new RegistroCampo(1, 615,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "34" ,                  0           )},
                {++c,    new RegistroCampo(1, 632,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "35" ,                  0           )},
                {++c,    new RegistroCampo(1, 649,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "36" ,                  0           )},
                {++c,    new RegistroCampo(1, 666,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "37" ,                  0           )},
                {++c,    new RegistroCampo(1, 683,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "38" ,                  0           )},
                {++c,    new RegistroCampo(1, 700,  17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "39" ,                  0           )},
                {++c,    new RegistroCampo(1, 717,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "40" ,                  0           )},
                {++c,    new RegistroCampo(1, 734,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "41" ,                  0           )},
                {++c,    new RegistroCampo(1, 751,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "42" ,                  0           )},
                {++c,    new RegistroCampo(1, 768,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "43" ,                  0           )},
                {++c,    new RegistroCampo(1, 785,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "44" ,                  0           )},
                {++c,    new RegistroCampo(1, 802,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "45" ,                  0           )},
                {++c,    new RegistroCampo(1, 819,  17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "46" ,                  0           )},
                {++c,    new RegistroCampo(1, 836,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                )},
                {++c,    new RegistroCampo(1, 837,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  2,      0   )},
                {++c,    new RegistroCampo(1, 838,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  2,      0   )},
                {++c,    new RegistroCampo(1, 839, 579,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                )},
                {++c,    new RegistroCampo(1, 1418, 13,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                )},
                {++c,    new RegistroCampo(1, 1431, 12,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,      "</T30301000>"          )}
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
