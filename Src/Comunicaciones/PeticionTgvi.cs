using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AeatModelos.Comunicaciones
{

    /// <summary>
    /// Representa una petición a un servicios de declaraciones
    /// de la aeat para un modelo concreto incluido en el sistema TGVI.
    /// </summary>

    public class PeticionTgvi : Peticion
    {

        /// <summary>
        /// Acción a realizar en el sistema TGVI.
        /// </summary>
        string _Accion;

        /// <summary>
        /// Copnstruye una instancia de la clase
        /// Peticion.
        /// </summary>
        /// <param name="modelo">Modelo para el que se ha construido la 
        /// petición.</param>
        /// <param name="test">Indica si la presentación se realiza en el entorno en pruebas de la AEAT.</param>
        /// <param name="certRef">Ruta de certificado para la presentación, en caso de que se utilice uno externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// <param name="action">Acción a realizar en el sistema TGVI: 
        /// <para>'InicializarEnvio'</para>
        /// <para>'EnviarDatos'</para> 
        /// <para>'PresentarEnvio'</para>
        /// </param>
        public PeticionTgvi(RegistroMod modelo, bool test = false, string certRef = null, string certClave = null, string action = "InicializarEnvio") : base(modelo, test, certRef, certClave)
        {
            _Accion = action;
            _ContentType = "text/plain";
        }

        /// <summary>
        /// Recupera la url donde se encuentra el servicio de la aeat requerido
        /// por la petición y su modelo.
        /// </summary>
        /// <param name="test">True para pruebas y false para produccíón.</param>
        /// <returns>Url del servicio de la aeat correspondiente al modelo de la petición.</returns>
        protected override string GeneraEnlace(bool test)
        {
            return $"{base.GeneraEnlace(test)}{_Accion}";
        }

        /// <summary>
        /// Establece los valores de las variables de envío necesarias para la
        /// firma básica.
        /// </summary>
        protected override void InicializaFirmaBasica()
        {
        }

        /// <summary>
        /// cción a realizar en el sistema TGVI.
        /// </summary>
        public string Accion 
        {
            get 
            {
                return _Accion;
            }
        }


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

            _Respuesta = new RespuestaTgvi(this);

            return _Respuesta;
        }

    }
}
