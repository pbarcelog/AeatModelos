﻿/*
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


using System;
using System.Collections.Generic;

namespace AeatModelos.Mod349e20v00
{
    /// <summary>
    /// Tipo de registro 2: REGISTRO DE OPERADOR INTRACOMUNITARIO - Modelo 349. Diseño de registro: DR349_2020.pdf.
    /// </summary>
    public class Mod349e20v00p01 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod349e20v00p01(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "349";

            string p = "P01";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(1,   1,   1,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  2,      0                         )}, // 01
                {++c,    new RegistroCampo(1,   2,   3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null, Convert.ToInt32(Modelo),   0       )}, // 02
                {++c,    new RegistroCampo(1,   5,   4,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Ejercicio,      0                 )}, // 03
                {++c,    new RegistroCampo(1,   9,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDeclarante"                          )}, // 04
                // --- BLANCOS.
                {++c,    new RegistroCampo(1,  18,  58,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                              )}, // 05
                {++c,    new RegistroCampo(1,  76,  17,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFOperadorIntracomunitario"            )}, // 06
                // APELLIDOS Y NOMBRE O DENOMINACIÓN DEL PERCEPTOR. Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden.
                {++c,    new RegistroCampo(1,  93,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreDenominacion"            )}, // 07
                // CLAVE DE OPERACIÓN.
                {++c,    new RegistroCampo(1, 133,   1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ClaveOperacion"                         )}, // 08
                // BASE IMPONIBLE O IMPORTE.
                {++c,    new RegistroCampo(1, 134,  13,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "BaseImponibleImporte", null, 2          )}, // 09
                // --- BLANCOS.
                {++c,    new RegistroCampo(1, 147,  32,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                              )}, // 10
                // NIF EMPRESARIO O PROFESIONAL DESTINATARIO FINAL SUSTITUTO. Solo para claves de operación "C".
                {++c,    new RegistroCampo(1, 179,  17,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "NIFDestinatarioSustituto"               )}, // 11
                // APELLIDOS Y NOMBRE O RAZÓN SOCIAL DEL SUJETO PASIVO SUSTITUTO. Solo para claves de operación "C".
                {++c,    new RegistroCampo(1, 196,  40,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "ApellidosNombreDenominacionSustituto"   )}, // 12
                // --- BLANCOS.
                {++c,    new RegistroCampo(1, 236, 265,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"]                                              )}  // 13
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
