/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2020 Irene Solutions SL
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

namespace AeatModelos.Mod190e2017v00
{
    /// <summary>
    /// Tipo 1 modelo 190. Diseño de registro: DR190_2017.pdf.
    /// </summary>
    public class Mod190e2017v00 : RegistroModPagina
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod190e2017v00(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod190e2017v00.Mod190e2017v00p01"}
            };

            string p = "000";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "1"                     )}, // 01
                {++c,    new RegistroCampo(0,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "190"                   )}, // 02
                {++c,    new RegistroCampo(0,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Ejercicio               )}, // 03
                {++c,    new RegistroCampo(0,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIF"                          )}, // 04
                // Primer apellido, espacio, segundo apellido, espacio, nombre, necesariamente en este orden.
                {++c,    new RegistroCampo(0,  18,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreRazonSocial"   )}, // 05
                // TIPO DE SOPORTE. ‘T’: Transmisión telemática.
                {++c,    new RegistroCampo(0,  58,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "T"                     )}, // 06
                // PERSONA CON QUIÉN RELACIONARSE. Campo 1: Teléfono
                {++c,    new RegistroCampo(0,  59,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 07
                // PERSONA CON QUIÉN RELACIONARSE. Campo 2: Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(0,  68,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 08
                // NÚMERO IDENTIFICATIVO DE LA DECLARACIÓN.
                {++c,    new RegistroCampo(0, 108,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 09
                // DECLARACIÓN COMPLEMENTARIA O SUSTITUTIVA. "C ": DECLARACIÓN COMPLEMENTARIA. " S": DECLARACIÓN SUSTITUTIVA.
                {++c,    new RegistroCampo(0, 121,   2,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 10
                // NÚMERO IDENTIFICATIVO DE LA DECLARACIÓN ANTERIOR.
                {++c,    new RegistroCampo(0, 123,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 11
                // NÚMERO TOTAL DE PERCEPCIONES.
                {++c,    new RegistroCampo(0, 136,   9,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 12
                // IMPORTE TOTAL DE LAS PERCEPCIONES.
                {++c,    new RegistroCampo(0, 145,  16,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,    null,     2,      true)}, // 13
                // IMPORTE TOTAL DE LAS RETENCIONES E INGRESOS A CUENTA.
                {++c,    new RegistroCampo(0, 161,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,    null,     2           )}, // 14
                // CORREO ELECTRÓNICO DE LA PERSONA CON QUIEN RELACIONARSE.
                {++c,    new RegistroCampo(0, 176,  50,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 15
                // BLANCOS.
                {++c,    new RegistroCampo(0, 226, 262,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 16
                // SELLO ELECTRÓNICO.
                {++c,    new RegistroCampo(0, 488,   13, "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 17

                // En principio sólo se incluye la página 1.
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                            new Mod190e2017v00p01(Ejercicio, Periodo)
                } } }, // 18
            };

            Paginas = RegistroCampos[17] as ConjuntoDeEmpaquetables;
        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
        }
    }
}
