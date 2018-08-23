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


using System;
using System.Collections.Generic;

namespace AeatModelos
{

    /// <summary>
    /// Soporte para errores.
    /// </summary>
    public class Errores
    {

        /// <summary>
        /// Catálogo de mensajes de error.
        /// </summary>
        public static Dictionary<string, string> Catalogo = new Dictionary<string, string>() {
            {"Registro.Registro.000", "No existe el tipo de dato {0}." },
            {"Registro.Registro.001", "La propiedad Pagina sólo puede ser un entero de 0 a 30. Valor inválido {0}." },
            {"Registro.Registro.002", "La propiedad Posicion sólo puede ser un entero de 0 a 10000. Valor inválido {0}." },
            {"Registro.Registro.003", "La propiedad Longitud sólo puede ser un entero de 1 a 2000. Valor inválido {0}." },
        };

        /// <summary>
        /// Muestra el mensaje de error para la clave de 
        /// error indicada con la información adicional pasada
        /// como params.-
        /// </summary>
        /// <returns>Mensje de error.</returns>
        public static string MostrarMensaje(string claveError, params string[] infos)
        {
            if (!Catalogo.ContainsKey(claveError))
                throw new ArgumentException($"No existe la clave de mensaje de error {claveError}");

            return string.Format(Catalogo[claveError], infos);
        }

    }
}
