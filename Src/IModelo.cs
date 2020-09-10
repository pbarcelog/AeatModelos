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

using AeatModelos.Comunicaciones;

namespace AeatModelos
{

    /// <summary>
    /// Representa un  modelo de la Agencia Tributaria.
    /// </summary>
    public interface IModelo
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Si la instancia actual contiene más páginas
        /// estas se muestran como ConjuntoDeEmpaquetables
        /// en esta propiedad. Si no el valor de la propiedad
        /// es null.
        /// </summary>
        ConjuntoDeEmpaquetables Paginas { get; }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Añade una página del índice específicado.
        /// </summary>
        /// <param name="indicePagina">Indice de la página a añadir.</param>
        /// <returns>Página añadida.</returns>
        RegistroMod InsertaPagina(int indicePagina);

        /// <summary>
        /// Recupera la página del índice específicado.
        /// </summary>
        /// <param name="indicePagina">Indice de la página a añadir.</param>
        /// <param name="indiceGrupo">Cuando existen varía páginas
        /// del mimo número de página en el modelo, aquí se indica
        /// el indice en base 0 de la página que se quiere recuperar 
        /// (si no se especifica se devuelve la primera coincidencia).</param>
        /// <param name="crear">Si es true y no se encuentra la página
        /// entre los empaquetables, la crea.</param>
        /// <returns>Página recuperada si existe, recién creada
        /// si no existe y crear=true o null si no existe e índiceGrupo no
        /// es igual a 0 o crear es false.</returns>
        RegistroMod RecuperaPagina(int indicePagina, int indiceGrupo = 0, bool crear = false);

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        void Calcular();

        /// <summary>
        /// Recupera la representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.
        /// </summary>
        /// <returns> Representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.</returns>
        string AFichero();


        /// <summary>
        /// Devuelve una cadena con la representación del titular del
        /// certificado que va a realizar la presentación.
        /// </summary>
        string Declarante();

        /// <summary>
        /// Devuelve una cadena con la representación del titular del
        /// certificado que va a realizar la presentación.
        /// <param name="certRef">Referencia explícita a certificado externo.</param>
        /// <param name="certClave">Clave para el certificado referido.</param>
        /// </summary>
        string Presentador(string certRef = null, string certClave = null);

        /// <summary>
        /// Confirma la declaración según las especificaciones de la AEAT
        /// en cuanto a la firma básica. El usuario debe confirmar la declaración
        /// una vez ha revisado el fichero a enviar el presentador y el declarante.
        /// </summary>
        void Confirmar();

        /// <summary>
        /// Presenta la declaración.
        /// <param name="test">Si es true, realiza la presentación en
        /// modo de pruebas.</param>
        /// <param name="certRef">Referencia explícita a certificado externo.</param>
        /// <param name="certClave">Clave para el certificado referido.</param>
        /// </summary>
        /// <returns>Respuesta a la operación de presentación.</returns>
        Respuesta Presentar(bool test = false, string certRef = null, string certClave = null);

        #endregion

    }
}
