using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
