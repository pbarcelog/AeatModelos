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

using System;

namespace AeatModelos.Conversores
{

    /// <summary>
    /// Se encarga de hacer la conversión de los datos
    /// entrados desde fichero, y de los datos de salida
    /// para fichero.
    /// </summary>
    public class Conversor : IConversor
    {

        #region Variables Privadas Estáticas

        /// <summary>
        /// Campo subyacente.
        /// </summary>
        protected RegistroCampo _RegistroCampo;


        #endregion

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="registroCampo">Registro campo subyacente.</param>
        public Conversor(RegistroCampo registroCampo)
        {
            _RegistroCampo = registroCampo;
        }

        #endregion

        #region Indexadores

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descipción del campo.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {
                throw new NotImplementedException(Errores.MostrarMensaje("Conversor.000",
                  "indexador Conversor[string descripcion]"));
            }
        }

        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                return _RegistroCampo.Valor;
            }
            set
            {
                _RegistroCampo.Valor = value;
            }
        }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion
        {
            get
            {
                return _RegistroCampo.Descripcion;
            }
        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Recupera la representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.
        /// </summary>
        /// <returns> Representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.</returns>
        public virtual string AFichero()
        {
            throw new NotImplementedException(Errores.MostrarMensaje("Conversor.000",
                  "método AFichero(string texto) de la clase Conversor"));
        }

        /// <summary>
        /// Obtiene un datos formateado procedente de un fichero.
        /// </summary>
        /// <returns> Dato utilizable por la aplicación
        /// procedente de su representación en un fichero.</returns>
        public virtual object DeFichero()
        {
            throw new NotImplementedException(Errores.MostrarMensaje("Conversor.000",
                  "método DeFichero() de la clase Conversor"));
        }

        /// <summary>
        /// Compone un empaquetable a partir de su forma
        /// en texto de fichero.
        /// </summary>
        /// <param name="texto">Segmento de texto.</param>
        /// <returns>Objeto IEmpaquetable representado 
        /// por el segmento de texto</returns>
        public object DeFichero(string texto)
        {
            throw new NotImplementedException(Errores.MostrarMensaje("Conversor.000",
                  "método DeFichero(string texto) de la clase Conversor"));
        }

        /// <summary>
        /// Implementación del icomparable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return 0;
        }

        #endregion

    }
}
