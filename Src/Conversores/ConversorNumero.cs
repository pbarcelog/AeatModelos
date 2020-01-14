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

using System;
using System.Text.RegularExpressions;

namespace AeatModelos.Conversores
{

    /// <summary>
    /// Se encarga de las funciones de conversión de valores
    /// apara un campo.
    /// </summary>
    public class ConversorNumero : Conversor
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="registroCampo">Registro campo subyacente.</param>
        public ConversorNumero(RegistroCampo registroCampo) : base(registroCampo)
        {
        }

        /// <summary>
        /// Recupera la representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.
        /// </summary>
        /// <returns> Representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.</returns>
        public override string AFichero()
        {
            string resultado = null;

            if (_RegistroCampo.Valor == null)
            {
                resultado = new string('0', _RegistroCampo.Longitud);
            }
            else
            {

                decimal numero = Convert.ToDecimal(_RegistroCampo.Valor);

                string cadenaFormato = $"#,##0" +
                    $"{((_RegistroCampo.Decimales == 0) ? "" : ".")}" +
                    $"{new string('0', _RegistroCampo.Decimales)}";

                resultado = numero.ToString(cadenaFormato);

                resultado = Regex.Replace(resultado, @"\D", "");

                int largoPendiente = _RegistroCampo.Longitud - resultado.Length;
                string relleno = null;

                if (_RegistroCampo.Negativo && numero < 0)
                    largoPendiente = largoPendiente - 1;

                if (largoPendiente > 0) 
                    relleno = new string('0', largoPendiente);

                if (_RegistroCampo.Negativo && numero < 0)
                    if (largoPendiente == -1)
                        throw new Exception($"No existe espacio suficiente para el signo negativo");
                    else
                        relleno = $"N{relleno}";

                resultado = $"{relleno}{resultado}";
            }

            if (resultado.Length > _RegistroCampo.Longitud)
                resultado = resultado.Substring(resultado.Length -
                    _RegistroCampo.Longitud, _RegistroCampo.Longitud);

            if (_RegistroCampo.ValorFichero != resultado)
                _RegistroCampo.ValorFichero = resultado;

            return resultado;

        }

        /// <summary>
        /// Obtiene un datos formateado procedente de un fichero.
        /// </summary>
        /// <returns> Dato utilizable por la aplicación
        /// procedente de su representación en un fichero.</returns>
        public override object DeFichero()
        {

            var valorFichero = _RegistroCampo.ValorFichero;
            int mult = 1;

            if (valorFichero.StartsWith("N"))
            {
                valorFichero = valorFichero.Replace("N", "");
                mult = -1;
            }                

            decimal.TryParse(valorFichero, out decimal resultado);

            double divisor = Math.Pow(10, _RegistroCampo.Decimales);

            resultado = mult * resultado / (decimal)divisor;

            if(_RegistroCampo.Valor != null && !_RegistroCampo.Valor.Equals(resultado))
                _RegistroCampo.Valor = resultado;

            return resultado;
        }

    }
}
