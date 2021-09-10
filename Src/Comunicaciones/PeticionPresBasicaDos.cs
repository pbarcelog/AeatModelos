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
using System.Text;

namespace AeatModelos.Comunicaciones
{

    /// <summary>
    /// Representa una petición a un servicios de declaraciones
    /// de la aeat para un modelo concreto incluido en el nuevo
    /// sistema de presentación a partir del 2022.
    /// </summary>
    public class PeticionPresBasicaDos : Peticion
    {

        #region Construtores de Instancia

        /// <summary>
        /// Copnstruye una instancia de la clase
        /// Peticion.
        /// </summary>
        /// <param name="modelo">Modelo para el que se ha construido la 
        /// petición.</param>
        /// <param name="test">Indica si la presentación se realiza en el entorno en pruebas de la AEAT.</param>
        /// <param name="certRef">Ruta de certificado para la presentación, en caso de que se utilice uno externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// <param name="encoding">Tipo de encoding para el envío del registro.</param>
        /// <param name="contentType">Tipo del contenido de la petición http.</param>
        public PeticionPresBasicaDos(RegistroMod modelo, bool test = false, string certRef = null,
            string certClave = null, Encoding encoding = null, string contentType = "application/json;charset=UTF-8") :
            base(modelo, test, certRef, certClave, encoding)
        {
            _ContentType = contentType;
        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// Establece los valores de las variables de envío necesarias para la
        /// firma básica.
        /// </summary>
        protected override void InicializaFirmaBasica()
        {

            if (Convert.ToInt32(Modelo.Ejercicio) > 2021)
            {
                Modelo.VariablesEnvio["MODELO"] = Modelo.Modelo;
                Modelo.VariablesEnvio["EJERCICIO"] = Modelo.Ejercicio;
                Modelo.VariablesEnvio["PERIODO"] = Modelo.Periodo;
            }

            Modelo.VariablesEnvio["FIRNIF"] = _CertificadoTitular.NIF;
            Modelo.VariablesEnvio["FIRNOMBRE"] = _CertificadoTitular.Nombre;
            Modelo.VariablesEnvio["F01"] = _TextoFichero;

        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Intenta presentar la declaración mediante el envío de la petición
        /// al servicio correspondiente de la AET, y devuelve la respuesta de 
        /// la misma.
        /// </summary>
        /// <returns>Respuesta a una petición de presentación</returns>
        public override Respuesta Presentar(bool test = false)
        {

            PreparaPeticion();
            EscribePeticion();

            _Respuesta = new RespuestaPresBasicaDos(this);

            return _Respuesta;
        }

        #endregion

    }
}
