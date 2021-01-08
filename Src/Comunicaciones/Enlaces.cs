/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2020 Irene Solutions SL
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

        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasica = "https://www1.agenciatributaria.gob.es/wlpl/PFTW-PICW/PresBasica";

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasicaTgvi = "https://www1.agenciatributaria.gob.es/wlpl/OVPT-NTGV/";


        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasicaPruebas = "https://www7.aeat.es/wlpl/PFTW-PICW/PresBasica";

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasicaPruebasTgvi = "https://www7.aeat.es/wlpl/OVPT-NTGV/";


        /// <summary>
        /// Diccionario de enlaces por modelos referenciados por
        /// la clave del modelo correspondiente.
        /// </summary>
        public static Dictionary<string, string> Modelos = new Dictionary<string, string>() {
            { "Mod303e19v10_10",        PftwPicwPresBasica },
            { "Mod130e15v11",           PftwPicwPresBasica },
            { "Mod390e2019v100",        PftwPicwPresBasica },
            { "Mod123e15v13",           PftwPicwPresBasica },
            { "Mod115e15v13",           PftwPicwPresBasica },
            { "Mod111e16v18",           PftwPicwPresBasica },
            { "Mod180e14v00",           PftwPicwPresBasicaTgvi },
            { "Mod190e2017v00",         PftwPicwPresBasicaTgvi },
        };

        /// <summary>
        /// Diccionario de enlaces por modelos referenciados por
        /// la clave del modelo correspondiente para el entorno de
        /// pruebas.
        /// </summary>
        public static Dictionary<string, string> ModelosPruebas = new Dictionary<string, string>() {
            { "Mod303e19v10_10",        PftwPicwPresBasicaPruebas },
            { "Mod130e15v11",           PftwPicwPresBasicaPruebas },
            { "Mod390e2019v100",        PftwPicwPresBasicaPruebas },
            { "Mod123e15v13",           PftwPicwPresBasicaPruebas },
            { "Mod115e15v13",           PftwPicwPresBasicaPruebas },
            { "Mod111e16v18",           PftwPicwPresBasicaPruebas },
            { "Mod180e14v00",           PftwPicwPresBasicaPruebasTgvi },
            { "Mod190e2017v00",         PftwPicwPresBasicaPruebasTgvi },
        };

        #endregion

        #region Métodos Públicos Estáticos

        /// <summary>
        /// Devuelve el enlace al servicio online de la aeat para
        /// el modelo facilitado como parámetro
        /// </summary>
        /// <param name="modelo">Instancia del modelo a consultar.</param>
        /// <param name="test">Testigo para indicar si el enlace devuelto debe ser para el modo "Test".</param>
        /// <returns>Enlace encontrado o nulo si no hay éxito.</returns>
        public static string BuscaEnlaceModelo(RegistroMod modelo, bool test = false)
        {

            if (modelo == null)
                throw new ArgumentNullException(Errores.MostrarMensaje("Enlaces.000"));

            return BuscaEnlaceModelo(modelo.GetType(), test);
        }

        /// <summary>
        /// Devuelve el enlace al servicio online de la aeat para
        /// el modelo facilitado como parámetro
        /// </summary>
        /// <param name="tipoModelo">Tipo del modelo a consultar.</param>
        /// <param name="test">Testigo para indicar si el enlace devuelto debe ser para el modo "Test".</param>
        /// <returns>Enlace encontrado o nulo si no hay éxito.</returns>
        public static string BuscaEnlaceModelo(Type tipoModelo, bool test = false)
        {

            string enlace = null;

            var name = tipoModelo.Name;
            var modelos = (test) ? ModelosPruebas : (test ? ModelosPruebas : Modelos);

            if (modelos.ContainsKey(name))
                return modelos[name];

            return enlace;
        }

        #endregion

    }
}
