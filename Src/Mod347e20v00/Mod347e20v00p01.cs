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

using System.Collections.Generic;

namespace AeatModelos.Mod347e20v00
{
    /// <summary>
    /// TIPO DE REGISTRO 2: REGISTRO DE DECLARADO. Modelo 347.  Diseño de registro: 347_2020.pdf.
    /// </summary>
    public class Mod347e20v00p01 : RegistroModPagina
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 0A</param>
        public Mod347e20v00p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  2,      0               )}, // 01
                {++c,    new RegistroCampo(1,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  347,      0             )}, // 02
                {++c,    new RegistroCampo(1,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Ejercicio,      0       )}, // 03
                {++c,    new RegistroCampo(1,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDeclarante"                )}, // 04
                {++c,    new RegistroCampo(1,  18,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDeclarado"                 )}, //005
                {++c,    new RegistroCampo(1,  27,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFRepresentanteLegalMenor"   )}, //006
                // APELLIDOS Y NOMBRE O DENOMINACIÓN DEL PERCEPTOR. Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(1,  36,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreDenominacion"  )}, //007
                // TIPO DE HOJA. Constante ‘D’.
                {++c,    new RegistroCampo(1,  76,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "D"                     )}, //008
                // CÓDIGO PROVINCIA. (En caso de no residentes sin establecimiento permanente en España, consignar un "99").
                {++c,    new RegistroCampo(1,  77,   2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoProvincia",  null,   0  )}, //009
                // CÓDIGO PAÍS. (Sólo en caso de no residentes sin establecimiento permanente en España).
                {++c,    new RegistroCampo(1,  79,   2,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "CodigoPais"                   )}, //010
                // ------ BLANCOS.
                {++c,    new RegistroCampo(1,  81,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                    )}, //011
                // CLAVE OPERACIÓN.
                {++c,    new RegistroCampo(1,  82,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ClaveOperacion"               )}, //012
                // IMPORTE ANUAL DE LAS OPERACIONES.
                {++c,    new RegistroCampo(1,  83,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteAnualN"                )}, //013
                {++c,    new RegistroCampo(1,  84,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteAnual",     null,   2  )}, //014
                // OPERACIÓN SEGURO. (Sólo Entidades Aseguradoras, pondrán una "X").
                {++c,    new RegistroCampo(1,  99,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "OperacionSeguro"              )}, //015
                // ARRENDAMIENTO LOCAL NEGOCIO. (Sólo arrendadores y arrendatarios de Locales de Negocio, pondrán una "X").
                {++c,    new RegistroCampo(1, 100,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ArrendamientoLocalNegocio"    )}, //016
                // IMPORTE PERCIBIDO EN METÁLICO. (Superior a 6.000 euros).
                {++c,    new RegistroCampo(1, 101,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteEnMetalico"            )}, //017
                // IMPORTE ANUAL PERCIBIDO POR TRANSMISIONES DE INMUEBLES SUJETAS A IVA.
                {++c,    new RegistroCampo(1, 116,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteAnualTransmisionInmueblesN")}, //018
                {++c,    new RegistroCampo(1, 117,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteAnualTransmisionInmuebles",null,2)}, //019
                // EJERCICIO declarado operaciones del cobro en metálico por importe superior a 6.000 euros.
                {++c,    new RegistroCampo(1, 132,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "EjercicioImporteMetalico",null,0)}, //020
                // IMPORTE DE LAS OPERACIONES PRIMER TRIMESTRE.
                {++c,    new RegistroCampo(1, 136,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperaciones1TN"        )}, //021
                {++c,    new RegistroCampo(1, 137,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperaciones1T", null, 2)}, //022
                // IMPORTE PERCIBIDO POR TRANSMISIONES DE INMUEBLES SUJETAS A IVA PRIMER TRIMESTRE.
                {++c,    new RegistroCampo(1, 152,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteTransmisionInmueblesSujIVA1TN")}, //023
                {++c,    new RegistroCampo(1, 153,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteTransmisionInmueblesSujIVA1T",null,2)}, //024
                // IMPORTE DE LAS OPERACIONES SEGUNDO TRIMESTRE.
                {++c,    new RegistroCampo(1, 168,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperaciones2TN"        )}, //025
                {++c,    new RegistroCampo(1, 169,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperaciones2T", null, 2)}, //026
                // IMPORTE PERCIBIDO POR TRANSMISIONES DE INMUEBLES SUJETAS A IVA SEGUNDO TRIMESTRE.
                {++c,    new RegistroCampo(1, 184,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteTransmisionInmueblesSujIVA2TN")}, //027
                {++c,    new RegistroCampo(1, 185,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteTransmisionInmueblesSujIVA2T",null,2)}, //028
                // IMPORTE DE LAS OPERACIONES TERCER TRIMESTRE.
                {++c,    new RegistroCampo(1, 200,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperaciones3TN"        )}, //029
                {++c,    new RegistroCampo(1, 201,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperaciones3T", null, 2)}, //030
                // IMPORTE PERCIBIDO POR TRANSMISIONES DE INMUEBLES SUJETAS A IVA TERCER TRIMESTRE.
                {++c,    new RegistroCampo(1, 216,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteTransmisionInmueblesSujIVA3TN")}, //031
                {++c,    new RegistroCampo(1, 217,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteTransmisionInmueblesSujIVA3T",null,2)}, //032
                // IMPORTE DE LAS OPERACIONES CUARTO TRIMESTRE.
                {++c,    new RegistroCampo(1, 232,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperaciones4TN"        )}, //033
                {++c,    new RegistroCampo(1, 233,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteOperaciones4T", null, 2)}, //034
                // IMPORTE PERCIBIDO POR TRANSMISIONES DE INMUEBLES SUJETAS A IVA CUARTO TRIMESTRE.
                {++c,    new RegistroCampo(1, 248,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteTransmisionInmueblesSujIVA4TN")}, //035
                {++c,    new RegistroCampo(1, 249,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteTransmisionInmueblesSujIVA4T",null,2)}, //036
                // NIF OPERADOR COMUNITARIO. Este campo es incompatible (excluyente) con el campo NIF del declarado.
                {++c,    new RegistroCampo(1, 264,  17,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFOperadorComunitario"       )}, //037
                // OPERACIONES RÉGIMEN ESPECIAL CRITERIO DE CAJA IVA. Se pondrá una ‘X’ o espacio.
                {++c,    new RegistroCampo(1, 281,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "OperacionesEnCriterioCaja"    )}, //038
                // OPERACIÓN CON INVERSIÓN DEL SUJETO PASIVO. (Sólo el destinatario de la operación). Se pondrá una ‘X’ o espacio.
                {++c,    new RegistroCampo(1, 282,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "OperacionesEnInversSujPasivo" )}, //039
                // OPERACIÓN CON BIENES VINCULADOS O DESTINADOS A VINCULARSE AL RÉGIMEN DE DEPÓSITO DISTINTO DEL ADUANERO. Se pondrá una ‘X’ o espacio.
                {++c,    new RegistroCampo(1, 283,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "OperacionesVinculRegAduanero" )}, //040
                // IMPORTE ANUAL DE LAS OPERACIONES DEVENGADAS CONFORME AL CRITERIO DE CAJA DEL IVA.
                {++c,    new RegistroCampo(1, 284,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteAnualRegCriterioCajaN" )}, //041
                {++c,    new RegistroCampo(1, 285,  15,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ImporteAnualRegCriterioCaja",null,2)}, //042
                // ------ BLANCOS.
                {++c,    new RegistroCampo(1, 300, 201,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                    )}, //043
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
