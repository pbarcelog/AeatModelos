﻿/*
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
    
    uede evitar el cumplimiento de lo establecido de lo establecido 
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
using System.Text.RegularExpressions;

namespace AeatModelos.Conversores
{

    /// <summary>
    /// Se encarga de las funciones de conversión de valores
    /// apara un campo.
    /// </summary>
    public class ConversorNumero : Conversor
    {       

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="registroCampo">Registro campo subyacente.</param>
        public ConversorNumero(RegistroCampo registroCampo) : base(registroCampo)
        {
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
                        throw new Exception(Errores.MostrarMensaje("ConversorNumero.000"));
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

            if (_RegistroCampo.Valor != null && !_RegistroCampo.Valor.Equals(resultado))
                _RegistroCampo.Valor = resultado;

            return resultado;
        }

        #endregion

    }
}
