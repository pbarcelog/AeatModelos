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
    /// Descripciones de campos.
    /// </summary>
    public class Txt
    {
        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Diccionario con las descripciones de campo
        /// según clave (página.numcampo).
        /// </summary>
        public static Dictionary<string, string> Den = new Dictionary<string, string>()
        {
            {"000.001", "Tipo de registro"},
            {"000.002", "Modelo de la declaración"},
            {"000.003", "Ejercicio"},
            {"000.004", "NIF del declarante"},
            {"000.005", "Apellidos y Nombre/Razón social"},
            {"000.006", "Tipo de soporte"},
            {"000.007", "Persona con quien relacionarse - Teléfono"},
            {"000.008", "Persona con quien relacionarse - Apellidos y Nombre"},
            {"000.009", "Número identificativo de la declaración"},
            {"000.010", "Declaración complementaria o sustitutiva - Declaración complementaria"},
            {"000.011", "Declaración complementaria o sustitutiva - Declaración sustitutiva"},
            {"000.012", "Número identificativo de la declaración anterior"},
            {"000.013", "Número total de personas y entidades"},
            {"000.014", "Importe total anual de las operaciones - Signo negativo"},
            {"000.015", "Importe total anual de las operaciones"},
            {"000.016", "Número total de inmuebles"},
            {"000.017", "Importe total de las operaciones de arrendamiento de locales de negocio - Signo negativo"},
            {"000.018", "Importe total de las operaciones de arrendamiento de locales de negocio"},
            {"000.019", "Blancos ---------"},
            {"000.020", "NIF del representante legal menor"},
            {"000.021", "Blancos ---------"},
            {"000.022", "Sello electrónico"},

            {"P01.001", "Tipo de registro"},
            {"P01.002", "Modelo de la declaración"},
            {"P01.003", "Ejercicio"},
            {"P01.004", "NIF del declarante"},
            {"P01.005", "NIF del declarado"},
            {"P01.006", "NIF del representante legal"},
            {"P01.007", "Apellidos y Nombre/Razón social/Denominación del declarado"},
            {"P01.008", "Tipo de hoja"},
            {"P01.009", "Código de provincia"},
            {"P01.010", "Código país"},
            {"P01.011", "Blancos ---------"},
            {"P01.012", "Clave operación"},
            {"P01.013", "Importe anual de las operaciones - Signo negativo"},
            {"P01.014", "Importe anual de las operaciones"},
            {"P01.015", "Operación seguro"},
            {"P01.016", "Arrendamiento local negocio"},
            {"P01.017", "Importe percibido en metálico"},
            {"P01.018", "Importe anual percibido por transmisiones de inmuebles sujetas a IVA - Signo negativo"},
            {"P01.019", "Importe anual percibido por transmisiones de inmuebles sujetas a IVA"},
            {"P01.020", "Ejercicio"},
            {"P01.021", "Improte de las operaciones 1º trimestre - Signo negativo"},
            {"P01.022", "Improte de las operaciones 1º trimestre"},
            {"P01.023", "Importe percibido por transmisiones de inmuebles sujetas a IVA 1º trimestre - Signo negativo"},
            {"P01.024", "Importe percibido por transmisiones de inmuebles sujetas a IVA 1º trimestre"},
            {"P01.025", "Improte de las operaciones 2º trimestre - Signo negativo"},
            {"P01.026", "Improte de las operaciones 2º trimestre"},
            {"P01.027", "Importe percibido por transmisiones de inmuebles sujetas a IVA 2º trimestre - Signo negativo"},
            {"P01.028", "Importe percibido por transmisiones de inmuebles sujetas a IVA 2º trimestre"},
            {"P01.029", "Improte de las operaciones 3º trimestre - Signo negativo"},
            {"P01.030", "Improte de las operaciones 3º trimestre"},
            {"P01.031", "Importe percibido por transmisiones de inmuebles sujetas a IVA 3º trimestre - Signo negativo"},
            {"P01.032", "Importe percibido por transmisiones de inmuebles sujetas a IVA 3º trimestre"},
            {"P01.033", "Improte de las operaciones 4º trimestre - Signo negativo"},
            {"P01.034", "Improte de las operaciones 4º trimestre"},
            {"P01.035", "Importe percibido por transmisiones de inmuebles sujetas a IVA 4º trimestre - Signo negativo"},
            {"P01.036", "Importe percibido por transmisiones de inmuebles sujetas a IVA 4º trimestre"},
            {"P01.037", "NIF operador intracomunitario"},
            {"P01.038", "Operaciones régimen especial criterio de caja IVA"},
            {"P01.039", "Operación con inversión del sujeto pasivo"},
            {"P01.040", "Operación con bienes vinculados o destinados a vincularse al régimen de depósito distinto del aduanero"},
            {"P01.041", "Importe anual de las operaciones devengadas conforme al criterio de caja del IVA - Signo negativo"},
            {"P01.042", "Importe anual de las operaciones devengadas conforme al criterio de caja del IVA"},
            {"P01.043", "Blancos ---------"},

            {"P02.001", "Tipo de registro"},
            {"P02.002", "Modelo de la declaración"},
            {"P02.003", "Ejercicio"},
            {"P02.004", "NIF del declarante"},
            {"P02.005", "NIF del arrendatario"},
            {"P02.006", "NIF del representante legal"},
            {"P02.007", "Apellidos y Nombre/Razón social/Denominación del contribuyente"},
            {"P02.008", "Tipo de hoja"},
            {"P02.009", "Blancos ---------"},
            {"P02.010", "Importe de la operación - Signo negativo"},
            {"P02.011", "Importe de la operación"},
            {"P02.012", "Situación del inmueble"},
            {"P02.013", "Referencia catastral"},
            {"P02.014", "Dirección del inmueble - Tipo de vía"},
            {"P02.015", "Dirección del inmueble - Nombre vía pública"},
            {"P02.016", "Dirección del inmueble - Tipo de numeración"},
            {"P02.017", "Dirección del inmueble - Número de casa"},
            {"P02.018", "Dirección del inmueble - Calificador del número"},
            {"P02.019", "Dirección del inmueble - Bloque"},
            {"P02.020", "Dirección del inmueble - Portal"},
            {"P02.021", "Dirección del inmueble - Escalera"},
            {"P02.022", "Dirección del inmueble - Planta o piso"},
            {"P02.023", "Dirección del inmueble - Puerta"},
            {"P02.024", "Dirección del inmueble - Complemento"},
            {"P02.025", "Dirección del inmueble - Localidad o población"},
            {"P02.026", "Dirección del inmueble - Municipio"},
            {"P02.027", "Dirección del inmueble - Código de municipio"},
            {"P02.028", "Dirección del inmueble - Código de provincia"},
            {"P02.029", "Dirección del inmueble - Código postal"},
            {"P02.030", "Blancos ---------"},
        };

        #endregion
    }
}
