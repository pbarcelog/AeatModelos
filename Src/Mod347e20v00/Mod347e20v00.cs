/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2021 Irene Solutions SL
    Autores: Manuel Diago García, Juan Bautista García Traver.

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

namespace AeatModelos.Mod347e20v00
{
    /// <summary>
    /// TIPO DE REGISTRO 1: REGISTRO DE DECLARANTE. Modelo 347.  Diseño de registro: 347_2020.pdf.
    /// </summary>
    public class Mod347e20v00 : RegistroModPaginaTgvi
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 0A</param>
        public Mod347e20v00(string ejercicio, string periodo = "0A") : base(ejercicio, periodo)
        {
            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod347e20v00.Mod347e20v00p01"},
                {2, "AeatModelos.Mod347e20v00.Mod347e20v00p02"}
            };

            string p = "000";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  1,           0          )}, // 01
                {++c,    new RegistroCampo(0,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ModeloDeclaracion", 347, 0    )}, // 02
                {++c,    new RegistroCampo(0,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Ejercicio,   0          )}, // 03
                {++c,    new RegistroCampo(0,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIF"                          )}, // 04
                // Primer apellido, espacio, segundo apellido, espacio, nombre, necesariamente en este orden.
                {++c,    new RegistroCampo(0,  18,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreRazonSocial"   )}, // 05
                // TIPO DE SOPORTE. ‘T’: Transmisión telemática.
                {++c,    new RegistroCampo(0,  58,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "T"                     )}, // 06
                // PERSONA CON QUIÉN RELACIONARSE. Campo 1: Teléfono
                {++c,    new RegistroCampo(0,  59,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ContactoTelefono"             )}, // 07
                // PERSONA CON QUIÉN RELACIONARSE. Campo 2: Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(0,  68,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ContactoApellidosNombre"      )}, // 08
                // NÚMERO IDENTIFICATIVO DE LA DECLARACIÓN.
                {++c,    new RegistroCampo(0, 108,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NumeroIdentificativoDeclaracion", 3470000000001,     0  )}, // 09
                // DECLARACIÓN COMPLEMENTARIA O SUSTITUTIVA. "C": DECLARACIÓN COMPLEMENTARIA o blanco.
                {++c,    new RegistroCampo(0, 121,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Complementaria"               )}, // 10
                // DECLARACIÓN COMPLEMENTARIA O SUSTITUTIVA. "S": DECLARACIÓN SUSTITUTIVA o blanco.
                {++c,    new RegistroCampo(0, 122,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Sustitutiva"                  )}, // 11
                // NÚMERO IDENTIFICATIVO DE LA DECLARACIÓN ANTERIOR.
                {++c,    new RegistroCampo(0, 123,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "JustificanteAnterior", null, 0)}, // 12
                // NÚMERO TOTAL DE PERCEPTORES.
                {++c,    new RegistroCampo(0, 136,   9,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "01",    null,     0           )}, // 13
                // IMPORTE TOTAL ANUAL DE LAS OPERACIONES.
                {++c,    new RegistroCampo(0, 145,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "02N",   null                  )}, // 14
                {++c,    new RegistroCampo(0, 146,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "02",    null,     2           )}, // 15
                // NÚMERO TOTAL DE INMUEBLES.
                {++c,    new RegistroCampo(0, 161,   9,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "03",    null,     2           )}, // 16
                // IMPORTE TOTAL DE LAS OPERACIONES DE ARRENDAMIENTO DE LOCALES DE NEGOCIO.
                {++c,    new RegistroCampo(0, 170,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "04N",  null                   )}, // 17
                {++c,    new RegistroCampo(0, 171,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "04",   null,      2           )}, // 18
                // ------ BLANCOS.
                {++c,    new RegistroCampo(0, 186, 205,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 19
                // NIF DEL REPRESENTANTE LEGAL. (Si el declarante es menor de 14 años).
                {++c,    new RegistroCampo(0, 391,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFRepresentanteLegalMenor"   )}, // 20
                // ------ BLANCOS.
                {++c,    new RegistroCampo(0, 400,  88,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 21
                // SELLO ELECTRONICO.
                {++c,    new RegistroCampo(0, 488,  13,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 22

                // No se incluye ninguna página por defecto. Éstas se van añadiendo conforme al número de perceptores.
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                } } }, // 23
            };

            Paginas = RegistroCampos[23] as ConjuntoDeEmpaquetables;
        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
            // *************************** !Importante ********************************
            // Comprobamos para unos campos numéricos concretos si a éstos les debe
            // preceder una "N", con tal de señalar que se trata de un número negativo.
            // (Se trata de un modelo con diseño viejo y no admite los tipos N)
            // ************************************************************************

            Mod347e20v00 modPagina1 = this;

            if (Convert.ToDecimal(modPagina1["02"]?.Valor) < 0)
                modPagina1["02N"].Valor = "N";

            if (Convert.ToDecimal(modPagina1["04"]?.Valor) < 0)
                modPagina1["04N"].Valor = "N";

            for (int i = 0; i < Paginas.Empaquetables.Count; i++)
            {
                Mod347e20v00p01 modPaginaPerceptor = Paginas.Empaquetables[i] as Mod347e20v00p01;

                if (Convert.ToDecimal(modPaginaPerceptor["ImporteAnual"]?.Valor) < 0)
                    modPaginaPerceptor["ImporteAnualN"].Valor = "N";

                if (Convert.ToDecimal(modPaginaPerceptor["ImporteAnualTransmisionInmuebles"]?.Valor) < 0)
                    modPaginaPerceptor["ImporteAnualTransmisionInmueblesN"].Valor = "N";
            }
        }

        /// <summary>
        /// Devuelve una cadena con la representación del titular del
        /// certificado que va a realizar la presentación.
        /// </summary>
        public override string Declarante()
        {
            string NIF = $"{this["NIF"].Valor}";
            string apellidosNombreRazonSocial = $"{this["ApellidosNombreRazonSocial"].Valor}";

            return $"{NIF}, {apellidosNombreRazonSocial}".Trim();
        }

        #endregion
    }
}
