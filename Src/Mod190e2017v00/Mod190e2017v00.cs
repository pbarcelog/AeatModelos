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

using System;
using System.Collections.Generic;

namespace AeatModelos.Mod190e2017v00
{
    /// <summary>
    /// Tipo 1 modelo 190. Diseño de registro: DR190_2017.pdf.
    /// </summary>
    public class Mod190e2017v00 : RegistroModPagina
    {

        #region Construtores de Instancia

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
                {++c,    new RegistroCampo(0,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  1,           0          )}, // 01
                {++c,    new RegistroCampo(0,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  190,         0          )}, // 02
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
                {++c,    new RegistroCampo(0, 108,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,    null,     0           )}, // 09
                // DECLARACIÓN COMPLEMENTARIA O SUSTITUTIVA. "C ": DECLARACIÓN COMPLEMENTARIA. " S": DECLARACIÓN SUSTITUTIVA.
                {++c,    new RegistroCampo(0, 121,   2,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 10
                // NÚMERO IDENTIFICATIVO DE LA DECLARACIÓN ANTERIOR.
                {++c,    new RegistroCampo(0, 123,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,    null,     0           )}, // 11
                // NÚMERO TOTAL DE PERCEPCIONES.
                {++c,    new RegistroCampo(0, 136,   9,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "01",    null,     0           )}, // 12
                // IMPORTE TOTAL DE LAS PERCEPCIONES. SIGNO NEGATIVO: "N". EN OTRO CASO EL CAMPO SERÁ UN ESPACIO.
                {++c,    new RegistroCampo(0, 145,  1,   "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "02N",   null                  )}, // 13
                // IMPORTE TOTAL DE LAS PERCEPCIONES.
                {++c,    new RegistroCampo(0, 146,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "02",    null,     2           )}, // 14
                // IMPORTE TOTAL DE LAS RETENCIONES E INGRESOS A CUENTA.
                {++c,    new RegistroCampo(0, 161,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "03",    null,     2           )}, // 15
                // CORREO ELECTRÓNICO DE LA PERSONA CON QUIEN RELACIONARSE.
                {++c,    new RegistroCampo(0, 176,  50,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CorreoContacto"               )}, // 16
                // BLANCOS.
                {++c,    new RegistroCampo(0, 226, 262,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 17
                // SELLO ELECTRÓNICO.
                {++c,    new RegistroCampo(0, 488,   13, "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                           )}, // 18

                // No se incluye ninguna página por defecto. Éstas se van añadiendo conforme al número de perceptores.
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                } } }, // 19
            };

            Paginas = RegistroCampos[19] as ConjuntoDeEmpaquetables;
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

            Mod190e2017v00 modPagina1 = this;

            if (Convert.ToDecimal(modPagina1["02"]?.Valor) < 0)
                modPagina1["02N"].Valor = "N";

            for (int i = 0; i < Paginas.Empaquetables.Count; i++)
            {
                Mod190e2017v00p01 modPaginaPerceptor = Paginas.Empaquetables[i] as Mod190e2017v00p01;

                if (Convert.ToDecimal(modPaginaPerceptor["IMPORTE TOTAL DE LAS PERCEPCIONES."]?.Valor) < 0)
                    modPaginaPerceptor["IMPORTE TOTAL DE LAS PERCEPCIONES. SIGNO NEGATIVO."].Valor = "N";

                if (Convert.ToDecimal(modPaginaPerceptor["PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA"]?.Valor) < 0)
                    modPaginaPerceptor["PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA. SIGNO NEGATIVO"].Valor = "N";

                if (Convert.ToDecimal(modPaginaPerceptor["PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN"]?.Valor) < 0)
                    modPaginaPerceptor["PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN. SIGNO NEGATIVO"].Valor = "N";

                if (Convert.ToDecimal(modPaginaPerceptor["PERCEPCIONES DINERARIAS DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA (Dineraria) DERIVADA DE INCAPACIDAD LABORAL"]?.Valor) < 0)
                    modPaginaPerceptor["PERCEPCIONES DINERARIAS DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA (Dineraria) DERIVADA DE INCAPACIDAD LABORAL. SIGNO NEGATIVO"].Valor = "N";

                if (Convert.ToDecimal(modPaginaPerceptor["PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN DE LA PERCEPCIÓN EN ESPECIE DERIVADA DE INCAPACIDAD LABORAL"]?.Valor) < 0)
                    modPaginaPerceptor["PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN DE LA PERCEPCIÓN EN ESPECIE DERIVADA DE INCAPACIDAD LABORAL. SIGNO NEGATIVO"].Valor = "N";
            }

        }

        #endregion

    }
}
