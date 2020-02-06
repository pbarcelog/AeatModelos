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
using System.Collections.Generic;

namespace AeatModelos
{

    /// <summary>
    /// Soporte para errores.
    /// </summary>
    public static class Errores
    {

        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Catálogo de mensajes de error: Contiene codificados en forma clave-valor los mensajes
        /// para los tipos de error controlados por la librería.
        /// </summary>
        public static Dictionary<string, string> Catalogo = new Dictionary<string, string>() {
            {"RegistroCampo.000",           "No existe el tipo de dato {0}." },
            {"RegistroCampo.001",           "La propiedad Pagina sólo puede ser un entero de 0 a 30. Valor inválido {0}." },
            {"RegistroCampo.002",           "La propiedad Posicion sólo puede ser un entero de 0 a 10000. Valor inválido {0}." },
            {"RegistroCampo.003",           "La propiedad Longitud sólo puede ser un entero de 1 a 2000. Valor inválido {0}." },
            {"ConjuntoDeEmpaquetables.000", "El {0} no está implementado en la clase base ConjuntoDeEmpaquetables." },
            {"Certificado.000",             "El modo de gestión de certificados {0} no es compatible con la plataforma {1}." },
            {"Certificado.001",             "No se ha encontrado un certificado con la huella digital {0} en el almacén de certificados del usuario ni en el de la máquina local." },
            {"Certificado.002",             "No se ha podido cargar el archivo de certificado {0}. Revise la ruta al archivo y la contraseña." },
            {"Certificado.003",             "El certificado establecido en la configuración dejó de ser válido después de {0}." },
            {"Enlaces.000",                 "El método estático BuscaEnlaceModelo de la clase Enlaces requiere un parámetro modelo no nulo." },
            {"Peticion.000",                "No se ha podido determinar el titular del certificado {0}." },
            {"Peticion.001",                "No se ha podido determinar el enlace al servicio  de presentación de la AEAT para el modelo {0}." },
            {"Respuesta.000",               "Error al descargar el documento pdf." },
            {"Conversor.000",               "El {0} no está implementado en la clase base Conversor." },
            {"ConversorNumero.000",         "No existe espacio suficiente para el signo negativo." },
            {"ConversorTexto.000",          "Ha intentado asignar el valor {0} con una longitud de {1} al registro  que sólo admite una longitud de {2}." },
            {"RegistroMod.000",             "No existe ningún tipo en el mapa para el índice {0}." },
            {"RegistroMod.001",             "El {0} no está implementado en la clase base RegistroMod." },
            {"RegistroMod.002",             "No se ha podido determinar el titular del certificado {0}."},
            {"RegistroMod.003",             "Antes de presentar, debe confirmar la declaración."}
        };

        #endregion

        #region Métodos Públicos Estáticos

        /// <summary>
        /// Muestra el mensaje de error para la clave de 
        /// error indicada con la información adicional pasada
        /// como params.
        /// </summary>
        /// <param name="claveError">Clave que identifica el error
        /// del que se quiere recuperar el mensaje.</param>
        /// <param name="infos">Parámetros de información adicional
        /// que se necesitan para componer el mensaje.</param>
        /// <returns>Mensje de error.</returns>
        public static string MostrarMensaje(string claveError, params string[] infos)
        {
            if (!Catalogo.ContainsKey(claveError))
                throw new ArgumentException($"No existe la clave de mensaje de error {claveError}");

            return string.Format(Catalogo[claveError], infos);
        }

        #endregion

    }
}
