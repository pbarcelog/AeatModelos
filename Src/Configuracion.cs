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
    
    Puede evitar el cumplimiento de lo establecido de lo establecido 
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

using System.Reflection;

namespace AeatModelos
{

    /// <summary>
    /// Datos generales de AeatModelos.
    /// </summary>
    public class AeatModelosContexto
    {

        #region Variables Privadas Estáticas
        #endregion

        #region Variables Privadas de Instancia
        #endregion

        #region Propiedades Privadas Estáticas
        #endregion

        #region Propiedades Privadas de Instacia
        #endregion

        #region Construtores Estáticos
        #endregion

        #region Construtores de Instancia
        #endregion

        #region Indexadores
        #endregion

        #region Métodos Privados Estáticos
        #endregion

        #region Métodos Privados de Instancia
        #endregion

        #region Propiedades Públicas Estáticas
        #endregion

        #region Propiedades Públicas de Instancia
        #endregion

        #region Métodos Públicos Estáticos
        #endregion

        #region Métodos Públicos de Instancia
        #endregion

        /// <summary>
        /// NIF de Irene Solutions SL. Empresa que
        /// ha desarrollado la librería.
        /// </summary>
        public const string NIFEmpresaDesarrollo = "B12959755";

        /// <summary>
        /// Ensamblado de AeatModelos.
        /// </summary>
        public static Assembly AeatModelos = Assembly.GetExecutingAssembly();

        /// <summary>
        /// Versión de la biblioteca.
        /// </summary>
        public static string AeatModelosVersion = $"{AeatModelos.GetName().Version}".Replace(".", "");

        /// <summary>
        /// Versión de la biblioteca transformada para incluir
        /// en los ficheros.
        /// </summary>
        public static string VersionDelPrograma = 
            $"{(AeatModelosVersion.Length > 4 ? AeatModelosVersion.Substring(AeatModelosVersion.Length - 4, 4) : AeatModelosVersion)}";

        

    }
}
