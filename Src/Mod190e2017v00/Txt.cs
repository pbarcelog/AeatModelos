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
    /// Descripciones de campos.
    /// </summary>
    public class Txt
    {
        /// <summary>
        /// Diccionario con las descripciones de campo
        /// según clave (página.numcampo).
        /// </summary>
        public static Dictionary<string, string> Den = new Dictionary<string, string>() {
            {"000.001", "TIPO DE REGISTRO 1: REGISTRO DE DECLARANTE"},
            {"000.002", "MODELO DECLARACIÓN."},
            {"000.003", "EJERCICIO."},
            {"000.004", "NIF DEL DECLARANTE."},
            {"000.005", "APELLIDOS Y NOMBRE, DENOMINACIÓN O RAZÓN SOCIAL DEL DECLARANTE."},
            {"000.006", "TIPO DE SOPORTE."},
            {"000.007", "PERSONA CON QUIÉN RELACIONARSE. Campo 1: Teléfono"},
            {"000.008", "PERSONA CON QUIÉN RELACIONARSE. Campo 2: Primer apellido, espacio, segundo apellido, espacio, nombre, en este orden."},
            {"000.009", "NÚMERO IDENTIFICATIVO DE LA DECLARACIÓN."},
            {"000.010", "DECLARACIÓN COMPLEMENTARIA O SUSTITUTIVA."},
            {"000.011", "NÚMERO IDENTIFICATIVO DE LA DECLARACIÓN ANTERIOR."},
            {"000.012", "NÚMERO TOTAL DE PERCEPCIONES."},
            {"000.013", "IMPORTE TOTAL DE LAS PERCEPCIONES. SIGNO NEGATIVO."},
            {"000.014", "IMPORTE TOTAL DE LAS PERCEPCIONES."},
            {"000.015", "IMPORTE TOTAL DE LAS RETENCIONES E INGRESOS A CUENTA."},
            {"000.016", "CORREO ELECTRÓNICO DE LA PERSONA CON QUIEN RELACIONARSE."},
            {"000.017", "BLANCOS."},
            {"000.018", "SELLO ELECTRÓNICO."},
            {"000.019", "Contenido del fichero.  Aquí se debe incluir el contenido de las páginas correspondientes a la declaración según el formato descrito para cada página en este mismo documento."},
            {"001.001", "TIPO DE REGISTRO 2. REGISTRO DE PERCEPTOR"},
            {"001.002", "MODELO DECLARACIÓN."},
            {"001.003", "EJERCICIO."},
            {"001.004", "NIF DEL DECLARANTE."},
            {"001.005", "NIF DEL PERCEPTOR."},
            {"001.006", "NIF DEL REPRESENTANTE LEGAL."},
            {"001.007", "APELLIDOS Y NOMBRE O DENOMINACIÓN DEL PERCEPTOR."},
            {"001.008", "CÓDIGO PROVINCIA."},
            {"001.009", "CLAVE DE PERCEPCIÓN."},
            {"001.010", "SUBCLAVE DE PERCEPCIÓN."},
            {"001.011", "PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA. SIGNO NEGATIVO"},
            {"001.012", "PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA"},
            {"001.013", "PERCEPCIONES DINERARIAS NO DERIVADAS DE INCAPACIDAD LABORAL. RETENCIONES PRACTICADAS"},
            {"001.014", "PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN. SIGNO NEGATIVO"},
            {"001.015", "PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN"},
            {"001.016", "PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA EFECTUADOS"},
            {"001.017", "PERCEPCIONES EN ESPECIE NO DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA REPERCUTIDOS"},
            {"001.018", "EJERCICIO DEVENGO"},
            {"001.019", "RENTAS OBTENIDAS EN CEUOTA O MELILLA"},
            {"001.020", "DATOS ADICIONALES. AÑO DE NACIMIENTO."},
            {"001.021", "DATOS ADICIONALES. SITUACIÓN FAMILIAR."},
            {"001.022", "DATOS ADICIONALES. NIF DEL CÓNYUGE."},
            {"001.023", "DATOS ADICIONALES. DISCAPACIDAD."},
            {"001.024", "DATOS ADICIONALES. CONTRATO O RELACIÓN."},
            {"001.025", "-"},
            {"001.026", "DATOS ADICIONALES. MOVILIDAD GEOGRÁFICA."},
            {"001.027", "DATOS ADICIONALES. REDUCCIONES APLICABLES."},
            {"001.028", "DATOS ADICIONALES. GASTOS DEDUCIBLES."},
            {"001.029", "DATOS ADICIONALES. PENSIONES COMPENSATORIAS."},
            {"001.030", "DATOS ADICIONALES. ANUALIDADES POR ALIMENTOS."},
            {"001.031", "DATOS ADICIONALES. HIJOS Y OTROS DESCENDIENTES."},
            {"001.032", "DATOS ADICIONALES. HIJOS Y OTROS DESCENDIENTES CON DISCAPACIDAD."},
            {"001.033", "DATOS ADICIONALES. ASCENDIENTES."},
            {"001.034", "DATOS ADICIONALES. ASCENDIENTES CON DISCAPACIDAD."},
            {"001.035", "DATOS ADICIONALES. CÓMPUTO DE LOS 3 PRIMEROS HIJOS."},
            {"001.036", "DATOS ADICIONALES. COMUNICACIÓN PRÉSTAMOS VIVIENDA HABITUAL."},
            {"001.037", "PERCEPCIONES DINERARIAS DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA (Dineraria) DERIVADA DE INCAPACIDAD LABORAL. SIGNO NEGATIVO"},
            {"001.038", "PERCEPCIONES DINERARIAS DERIVADAS DE INCAPACIDAD LABORAL. PERCEPCIÓN ÍNTEGRA (Dineraria) DERIVADA DE INCAPACIDAD LABORAL"},
            {"001.039", "PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: RETENCIONES PRACTICADAS SOBRE PRESTACIONES DERIVADAS DE INCAPACIDAD LABORAL"},
            {"001.040", "PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN DE LA PERCEPCIÓN EN ESPECIE DERIVADA DE INCAPACIDAD LABORAL. SIGNO NEGATIVO"},
            {"001.041", "PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: VALORACIÓN DE LA PERCEPCIÓN EN ESPECIE DERIVADA DE INCAPACIDAD LABORAL"},
            {"001.042", "PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA EFECTUADOS POR PRESTACIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL"},
            {"001.043", "PERCEPCIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL: INGRESOS A CUENTA REPERCUTIDOS POR PRESTACIONES EN ESPECIE DERIVADAS DE INCAPACIDAD LABORAL"},
            {"001.044", "BLANCOS."}
        };

    }
}
