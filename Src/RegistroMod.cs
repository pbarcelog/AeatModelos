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
using System.Text;

namespace AeatModelos
{

    /// <summary>
    /// Modelo de un resgistro.
    /// </summary>
    public class RegistroMod : IEmpaquetable
    {

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                throw new NotImplementedException("Pendiente!!!!!");
            }
            set
            {
                throw new NotImplementedException("Pendiente!!!!!");
            }
        }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion
        {
            get
            {
                throw new NotImplementedException("Pendiente!!!!!");
            }          
        }

        /// <summary>
        /// Ejercicio de la autoliquidación.
        /// </summary>
        public string Ejercicio { get; private set; }

        /// <summary>
        /// Periodo de la autoliquidación.
        /// </summary>
        public string Periodo { get; private set; }

        /// <summary>
        /// Diccionario de campos del modelo.
        /// </summary>
        public Dictionary<decimal, IEmpaquetable> RegistroCampos { get; protected set; }

        /// <summary>
        /// Si la instancia actual contiene más páginas
        /// estas se muestran como ConjuntoDeEmpaquetables
        /// en esta propiedad. Si no el valor de la propiedad
        /// es null.
        /// </summary>
        public ConjuntoDeEmpaquetables Paginas { get; protected set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public RegistroMod(string ejercicio, string periodo)
        {
            Ejercicio = ejercicio;
            Periodo = periodo;
        }

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descipción del campo o clave del campo.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {

                foreach (var parClaveValor in RegistroCampos)
                {
                    RegistroCampo campo = parClaveValor.Value as RegistroCampo;

                    if (campo != null && campo?.Descripcion == descripcion)                 
                        return campo;

                    if (campo != null && campo?.Clave != null && campo?.Clave == descripcion)
                        return campo;
                }
                   
                return null;
            }
        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public virtual void Calcular()
        {
            throw new NotImplementedException("No implementado en clase base: " +
                "A implementar en la clase derivada!!!!!");
        }

        /// <summary>
        /// Recupera la representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.
        /// </summary>
        /// <returns> Representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.</returns>
        public string AFichero()
        {

            Calcular();

            StringBuilder constructorTexto = new StringBuilder();

            foreach (KeyValuePair<decimal, IEmpaquetable> entrada in RegistroCampos)
                constructorTexto.Append(entrada.Value.AFichero());

            string resultado = constructorTexto.ToString();

            return resultado;

        }

        /// <summary>
        /// Crear empaquetable para la generación de impuestos.
        /// </summary>
        /// <param name="clave">Nombre del empaquetable a obtener</param>
        /// <param name="ejercicio">Nombre del empaquetable a obtener</param>
        /// <param name="periodo">Nombre del empaquetable a obtener</param>
        /// <returns>Empaquetable.</returns>
        public static IEmpaquetable CrearEmpaquetable(string clave, 
            string ejercicio, string periodo)
        {
            Type tipoEmpaquetable = Type.GetType($"AeatModelos.{clave}.{clave}");
            return Activator.CreateInstance(tipoEmpaquetable, ejercicio, periodo) as IEmpaquetable;
        }

    }
}
