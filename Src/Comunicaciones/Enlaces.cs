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

using AeatModelos.Configuracion;
using System;
using System.Collections.Generic;

namespace AeatModelos.Comunicaciones
{

    /// <summary>
    /// Enlaces con los servicios de la agencia tributaria.
    /// </summary>
    public class Enlaces
    {

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasica = "https://www1.agenciatributaria.gob.es/wlpl/PFTW-PICW/PresBasica";

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasicaPruebas = "https://www7.aeat.es/wlpl/PFTW-PICW/PresBasica";

        /// <summary>
        /// Diccionario de enlaces por modelos referenciados por
        /// la clave del modelo correspondiente.
        /// </summary>
        public static Dictionary<string, string> Modelos = new Dictionary<string, string>() {
            { "Mod303e19v10_10",        PftwPicwPresBasica },
            { "Mod130e15v11",           PftwPicwPresBasica },
        };

        /// <summary>
        /// Diccionario de enlaces por modelos referenciados por
        /// la clave del modelo correspondiente para el entorno de
        /// pruebas.
        /// </summary>
        public static Dictionary<string, string> ModelosPruebas = new Dictionary<string, string>() {
            { "Mod303e19v10_10",        PftwPicwPresBasicaPruebas },
            { "Mod130e15v11",           PftwPicwPresBasicaPruebas },
        };

        /// <summary>
        /// Devuelve el enlace al servicio online de la aeat para
        /// el modelo facilitado como parámetro
        /// </summary>
        /// <param name="modelo">Instancia del modelo a consultar.</param>
        /// <returns>Enlace encontrado o nulo si no hay éxito.</returns>
        public static string BuscaEnlaceModelo(RegistroMod modelo) {

            if(modelo == null)
                throw new ArgumentNullException($"El método estático BuscaEnlaceModelo de la " +
                    $"clase Enlaces requiere un parámetro modelo no nulo.");

            return BuscaEnlaceModelo(modelo.GetType());
        }

        /// <summary>
        /// Devuelve el enlace al servicio online de la aeat para
        /// el modelo facilitado como parámetro
        /// </summary>
        /// <param name="tipoModelo">Tipo del modelo a consultar.</param>
        /// <returns>Enlace encontrado o nulo si no hay éxito.</returns>
        public static string BuscaEnlaceModelo(Type tipoModelo)
        {

            string enlace = null;

            var name = tipoModelo.Name;
            var modelos = (Parametros.Actuales.Pruebas) ? ModelosPruebas : Modelos;

            if (Modelos.ContainsKey(name))
                return modelos[name];

            return enlace;
        }

    }
}
