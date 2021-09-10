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

namespace AeatModelos.Mod193e2019v00
{
    /// <summary>
    /// Tipo de registro 2: Registro de perceptor - Modelo 190. Diseño de registro: DR193_2017.pdf.
    /// </summary>
    public class Mod193e2019v00p01 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod193e2019v00p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "193";

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  2,      0               )}, // 01
                {++c,    new RegistroCampo(1,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  193,      0             )}, // 02
                {++c,    new RegistroCampo(1,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Ejercicio,      0       )}, // 03
                {++c,    new RegistroCampo(1,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDeclarante"                )}, // 04
                {++c,    new RegistroCampo(1,  18,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFPerceptor"                 )}, //005
                {++c,    new RegistroCampo(1,  27,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFRepresentanteLegal"        )}, //006
                // APELLIDOS Y NOMBRE O DENOMINACIÓN DEL PERCEPTOR. Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(1,  36,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreDenominacion"  )}, //007
                // PAGO A UN MEDIADOR. Sólo para claves de percepción “A”, “B” o “D”.
                {++c,    new RegistroCampo(1,  76,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "PagoAMediador"                )}, //008
                // CÓDIGO PROVINCIA.
                {++c,    new RegistroCampo(1,  77,   2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoProvincia",   null, 0   )}, //009
                // CLAVE CÓDIGO. Solo para claves de percepción “A”, “B” o “D”.
                {++c,    new RegistroCampo(1,  79,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ClaveCodigo",   null, 0       )}, //010
                // CÓDIGO EMISOR. Solo para claves de percepción “A”, “B” o “D”.
                {++c,    new RegistroCampo(1,  80,  12,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoEmisor"                 )}, //011
                // CLAVE DE PERCEPCIÓN.
                {++c,    new RegistroCampo(1,  92,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ClavePercepcion"              )}, //012
                // NATURALEZA.
                {++c,    new RegistroCampo(1,  93,   2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Naturaleza",   null, 0        )}, //013
                // PAGO. Solo para claves de percepción “A”, “B” o “D”.
                {++c,    new RegistroCampo(1,  95,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Pago",         null, 0        )}, //014
                // TIPO CÓDIGO. Solo para claves de percepción “A”, “B” o “D”.
                {++c,    new RegistroCampo(1,  96,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoCodigo"                   )}, //015
                // CÓDIGO CUENTA VALORES / NÚMERO OPERACIÓN PRÉSTAMO. Solo para claves de percepción “A”, “B” o “D”.
                {++c,    new RegistroCampo(1,  97,  20,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoCuenta"                 )}, //016
                // PENDIENTE. Solo para claves de percepción “A”, “B” o “D”.
                {++c,    new RegistroCampo(1, 117,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Pendiente"                    )}, //017
                // EJERCICIO DEVENGO. Solo para claves de percepción “A”, “B” o “D”.
                {++c,    new RegistroCampo(1, 118,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "EjercicioDevengo",   null, 0  )}, //018
                // TIPO DE PERCEPCIÓN.
                {++c,    new RegistroCampo(1, 122,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "TipoPercepcion",  null,  0    )}, //019
                // IMPORTE DE PERCEPCIONES /REMUNERACIÓN AL PRESTAMISTA.
                {++c,    new RegistroCampo(1, 123,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImportePercepciones", null, 2 )}, //020
                // --- BLANCOS.
                {++c,    new RegistroCampo(1, 136,   3,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                    )}, //021
                // IMPORTE REDUCCIONES.
                {++c,    new RegistroCampo(1, 139,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteReducciones",  null, 2 )}, //022
                // BASE RETENCIONES E INGRESOS A CUENTA.
                {++c,    new RegistroCampo(1, 152,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],"BaseRetencionesIngresosCta",null,2)}, //023
                // % RETENCIÓN.
                {++c,    new RegistroCampo(1, 165,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "PorcentajeRetencion",  null, 2)}, //024
                // RETENCIONES E INGRESOS A CUENTA.
                {++c,    new RegistroCampo(1, 169,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"], "RetencionesIngresosCta",  null, 2)}, //025
                // PENALIZACIONES.
                {++c,    new RegistroCampo(1, 182,  11,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Penalizaciones",       null, 2)}, //026
                // --- BLANCOS.
                {++c,    new RegistroCampo(1, 193,  15,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                    )}, //027
                // NATURALEZA DEL DECLARANTE.
                {++c,    new RegistroCampo(1, 208,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NaturalezaDeclarante"         )}, //028
                // FECHA DE INICIO DEL PRÉSTAMO.
                {++c,    new RegistroCampo(1, 209,   8,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "FechaInicioPrestamo",  null, 0)}, //029
                // FECHA DE VENCIMIENTO DEL PRÉSTAMO.
                {++c,    new RegistroCampo(1, 217,   8,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],"FechaVencimientoPrestamo", null, 0)}, //030
                // COMPENSACIONES.
                {++c,    new RegistroCampo(1, 225,  12,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Compensaciones",       null, 2)}, //031
                // GARANTÍAS.
                {++c,    new RegistroCampo(1, 237,  12,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "Garantias",            null, 2)}, //032
                // --- BLANCOS.
                {++c,    new RegistroCampo(1, 249, 252,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                    )}, //033
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
