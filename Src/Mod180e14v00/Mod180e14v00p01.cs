/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2020 Irene Solutions SL
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

using System.Collections.Generic;

namespace AeatModelos.Mod180e14v00
{
    /// <summary>
    /// TIPO DE REGISTRO 2: REGISTRO DE PERCEPTOR. Modelo 180. Diseño de registro: 180.pdf.
    /// </summary>
    public class Mod180e14v00p01 : RegistroModPagina
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod180e14v00p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                             2, 0  )}, // 01
                {++c,    new RegistroCampo(1,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                           180, 0  )}, // 02
                {++c,    new RegistroCampo(1,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                     Ejercicio, 0  )}, // 03
                {++c,    new RegistroCampo(1,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDeclarante"                         )}, // 04
                {++c,    new RegistroCampo(1,  18,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFPerceptor"                          )}, //005
                {++c,    new RegistroCampo(1,  27,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFRepresentanteLegal"                 )}, //006
                // APELLIDOS Y NOMBRE O DENOMINACIÓN DEL PERCEPTOR. Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(1,  36,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreDenominacion"           )}, //007
                // CÓDIGO PROVINCIA.
                {++c,    new RegistroCampo(1,  76,   2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Provincia",                   null, 0  )}, //008
                // Modalidad de renta o rendimiento: "1": renta o rendimineto dinerario; "2": renta o rendimiento en especie.
                {++c,    new RegistroCampo(1,  78,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Modalidad",                   null, 0  )}, //009
                // Retenciones e ingresos a cuenta.
                {++c,    new RegistroCampo(1,  79,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "BaseRetencionesIngresosCtaN"           )}, //010
                {++c,    new RegistroCampo(1,  80,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "BaseRetencionesIngresosCta",  null, 2  )}, //011
                {++c,    new RegistroCampo(1,  93,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "PorcentajeRetencion",         null, 2  )}, //012
                {++c,    new RegistroCampo(1,  97,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "RetencionesIngresosCta",      null, 2  )}, //013
                // Ejercicio devengo.
                {++c,    new RegistroCampo(1, 110,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "EjercicioDevengo",            null, 0  )}, //014
                // Situación inmueble.
                {++c,    new RegistroCampo(1, 114,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "SituaciónInmueble",           null, 0  )}, //015
                // Datos del inmueble.
                {++c,    new RegistroCampo(1, 115,  20,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ReferenciaCatastral"                   )}, //016
                {++c,    new RegistroCampo(1, 135,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoVia"                               )}, //017
                {++c,    new RegistroCampo(1, 140,  50,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NombreVia"                             )}, //018
                {++c,    new RegistroCampo(1, 190,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoNumeracion"                        )}, //019
                {++c,    new RegistroCampo(1, 193,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NumeroCasa"                            )}, //020
                {++c,    new RegistroCampo(1, 198,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CalificadorNumero"                     )}, //021
                {++c,    new RegistroCampo(1, 201,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Bloque"                                )}, //022
                {++c,    new RegistroCampo(1, 204,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Portal"                                )}, //023
                {++c,    new RegistroCampo(1, 207,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Escalera"                              )}, //024
                {++c,    new RegistroCampo(1, 210,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Planta"                                )}, //025
                {++c,    new RegistroCampo(1, 213,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Puerta"                                )}, //026
                {++c,    new RegistroCampo(1, 216,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "InfoAdicionalDomicilio"                )}, //027
                {++c,    new RegistroCampo(1, 256,  30,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Localidad"                             )}, //028
                {++c,    new RegistroCampo(1, 286,  30,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Municipio"                             )}, //029
                {++c,    new RegistroCampo(1, 316,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoMunicipio"                       )}, //030
                {++c,    new RegistroCampo(1, 321,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoProvincia"                       )}, //031
                {++c,    new RegistroCampo(1, 323,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoPostal"                          )}, //032
                // ---
                {++c,    new RegistroCampo(1, 328, 173,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                                    )}, //033
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
