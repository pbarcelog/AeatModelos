/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2021 Irene Solutions SL
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

namespace AeatModelos.Mod347e20v00
{
    /// <summary>
    /// TIPO DE REGISTRO 2: REGISTRO DE INMUEBLE. - Modelo 347. Diseño de registro: 347_2020.pdf.
    /// </summary>
    public class Mod347e20v00p02 : RegistroModPagina
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 0A</param>
        public Mod347e20v00p02(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
            string p = "P02";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                             2, 0  )}, // 01
                {++c,    new RegistroCampo(1,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                           347, 0  )}, // 02
                {++c,    new RegistroCampo(1,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                     Ejercicio, 0  )}, // 03
                {++c,    new RegistroCampo(1,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDeclarante"                         )}, // 04
                {++c,    new RegistroCampo(1,  18,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFArrendatario"                       )}, //005
                {++c,    new RegistroCampo(1,  27,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFRepresentanteLegal"                 )}, //006
                // APELLIDOS Y NOMBRE O DENOMINACIÓN DEL PERCEPTOR. Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(1,  36,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreDenominacion"           )}, //007
                // TIPO DE HOJA. Constante ‘I’.
                {++c,    new RegistroCampo(1,  76,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,        "I"                        )}, //008
                //  ------ BLANCOS.
                {++c,    new RegistroCampo(1,  77,  22,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                             )}, //009
                // IMPORTE DE LA OPERACION.
                {++c,    new RegistroCampo(1,  99,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperacionN"                     )}, //010
                {++c,    new RegistroCampo(1, 100,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperacion",            null, 2  )}, //011
                // Situación inmueble.
                {++c,    new RegistroCampo(1, 115,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "SituaciónInmueble",           null, 0  )}, //012
                // Datos del inmueble.
                {++c,    new RegistroCampo(1, 116,  25,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ReferenciaCatastral"                   )}, //013
                {++c,    new RegistroCampo(1, 141,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoVia"                               )}, //014
                {++c,    new RegistroCampo(1, 146,  50,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NombreVia"                             )}, //015
                {++c,    new RegistroCampo(1, 196,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoNumeracion"                        )}, //016
                {++c,    new RegistroCampo(1, 199,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NumeroCasa"                            )}, //017
                {++c,    new RegistroCampo(1, 204,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CalificadorNumero"                     )}, //018
                {++c,    new RegistroCampo(1, 207,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Bloque"                                )}, //019
                {++c,    new RegistroCampo(1, 210,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Portal"                                )}, //020
                {++c,    new RegistroCampo(1, 213,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Escalera"                              )}, //021
                {++c,    new RegistroCampo(1, 216,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Planta"                                )}, //022
                {++c,    new RegistroCampo(1, 219,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Puerta"                                )}, //023
                {++c,    new RegistroCampo(1, 222,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "InfoAdicionalDomicilio"                )}, //024
                {++c,    new RegistroCampo(1, 262,  30,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Localidad"                             )}, //025
                {++c,    new RegistroCampo(1, 292,  30,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Municipio"                             )}, //026
                {++c,    new RegistroCampo(1, 322,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoMunicipio"                       )}, //027
                {++c,    new RegistroCampo(1, 327,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoProvincia"                       )}, //028
                {++c,    new RegistroCampo(1, 329,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoPostal"                          )}, //029
                // ---
                {++c,    new RegistroCampo(1, 334, 167,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                    )}, //030
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
