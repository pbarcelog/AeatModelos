using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeatModelos.Conversores
{

    /// <summary>
    /// Se encarga de las funciones de conversión de valores
    /// apara un campo.
    /// </summary>
    public class ConversorTexto : Conversor
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="registroCampo">Registro campo subyacente.</param>
        public ConversorTexto(RegistroCampo registroCampo) : base(registroCampo)
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

            string resultado = $"{_RegistroCampo.Valor}";
            int largoPendiente = _RegistroCampo.Longitud - resultado.Length;
            string relleno = null;

            if (largoPendiente > 0)
                relleno = new string(' ', largoPendiente);

            resultado = $"{resultado}{relleno}";

            if(_RegistroCampo.ValorFichero != resultado)
                _RegistroCampo.ValorFichero = resultado;

            if (resultado.Length > _RegistroCampo.Longitud)
                resultado = resultado.Substring(resultado.Length - 
                    _RegistroCampo.Longitud, _RegistroCampo.Longitud);

            return resultado;

        }

        /// <summary>
        /// Obtiene un datos formateado procedente de un fichero.
        /// </summary>
        /// <returns> Dato utilizable por la aplicación
        /// procedente de su representación en un fichero.</returns>
        public override object DeFichero()
        {
            string resultado = $"{_RegistroCampo.ValorFichero}";
            resultado = resultado.TrimStart();

            if (_RegistroCampo.Valor!= null && !_RegistroCampo.Valor.Equals(resultado))
                _RegistroCampo.Valor = resultado;
          
            return resultado;
        }

    }
}
