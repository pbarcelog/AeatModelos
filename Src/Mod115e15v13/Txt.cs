/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2018 Irene Solutions SL
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

namespace AeatModelos.Mod115e15v13
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
            {"000.001", "Constante."},
            {"000.002", "Modelo"},
            {"000.003", "Constante"},
            {"000.004", "Ejercicio de devengo (EEEE)"},
            {"000.005", "Período. (PP)"},
            {"000.006", "Constante"},
            {"000.007", "Constante"},
            {"000.008", "Reservado para la Administración. Rellenar con blancos"},
            {"000.009", "Versión del Programa (Nota 1)"},
            {"000.010", "Reservado para la Administración. Rellenar con blancos"},
            {"000.011", "NIF Empresa Desarrollo (Nota 1)"},
            {"000.012", "Reservado para la Administración. Rellenar con blancos"},
            {"000.013", "Constante"},
            {"000.015", "Constante. </T+ modelo+discriminante+Ejercicio+periodo+Tipo+>"},
            {"000.016", "Fin de Registro. Constante CRLF( Hexadecimal 0D0A, Decimal 1310)"},
            {"P01.001", "Inicio del identificador de modelo y página"},
            {"P01.002", "Modelo"},
            {"P01.003", "Página"},
            {"P01.004", "Fin de identificador de modelo"},
            {"P01.005", "Indicador de página complementaria"},
            {"P01.006", "Tipo de declaración"},
            {"P01.007", "Identificación. Sujeto pasivo. NIF"},
            {"P01.008", "Identificación. Sujeto pasivo. Denominación o Apellidos"},
            {"P01.009", "Identificación. Sujeto pasivo. Nombre"},
            {"P01.010", "Identificación. Ejercicio"},
            {"P01.011", "Identificación. Periodo"},
            {"P01.012", "Retenciones e ingresos a cuenta. Número perceptores [01]"},
            {"P01.013", "Retenciones e ingresos a cuenta. Base retenciones e ingresos a cuenta [02]"},
            {"P01.014", "Retenciones e ingresos a cuenta. Retenciones e ingresos a cuenta [03]"},
            {"P01.015", "Retenciones e ingresos a cuenta. Resultado anteriores declaraciones [04]"},
            {"P01.016", "Retenciones e ingresos a cuenta. Resultado a ingresar [03] - [04]"},
            {"P01.017", "Declaración complementaria"},
            {"P01.018", "Número de justificante de la declaración anterior"},
            {"P01.019", "Domiciliación - IBAN"},
            {"P01.020", "Reservado para la Administración"},
            {"P01.021", "Reservado para el sello electrónico de la AEAT"},
            {"P01.022", "Indicador de fin de registro"}
        };

    }
}
