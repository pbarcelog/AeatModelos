/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2021 Irene Solutions SL
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
    
    Puede evitar el cumplimiento de lo establecido 
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
using AeatModelos.Configuracion;
using System;

namespace AeatModelos
{
    /// <summary>
    /// Representa un registro de modelo que tiene contenido de texto
    /// o constutiye una página del modelo a presentar mediante sistema TGVI.
    /// </summary>
    public class RegistroModPaginaTgvi : RegistroModPagina
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public RegistroModPaginaTgvi(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Presenta la declaración.
        /// <param name="test">Indica si la presentación se realiza en el entorno en pruebas de la AEAT.</param>
        /// <param name="certRef">Ruta de certificado para la presentación, en caso de que se utilice uno externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// </summary>
        /// <returns>Respuesta a la operación de presentación.</returns>
        public override Respuesta Presentar(bool test = false, string certRef = null, string certClave = null)
        {
            if (!_Confirmado)
                throw new InvalidOperationException(Errores.MostrarMensaje("RegistroMod.003"));

            int indiceUltimaPagina = RegistroCampos.Count;

            string registroTipo1 = null;
            string registroTipo2 = RegistroCampos[indiceUltimaPagina].AFichero();

            for (decimal p = 1; p < indiceUltimaPagina; p++)
                registroTipo1 += RegistroCampos[p].AFichero();


            VariablesEnvio.Clear();
            VariablesEnvio.Add("", registroTipo1);
            OrdenVariablesEnvio = new string[1] { "" };

            // 1. Inicialización
            var peticionInicializarEnvio = new PeticionTgvi(this, test, certRef, certClave, "InicializarEnvio");

            peticionInicializarEnvio.PreparaPeticion();

            if (string.IsNullOrWhiteSpace(this["ModeloDeclaracion"].Valor.ToString()))
                throw new InvalidOperationException("Debe indicar el número de modelo en la casilla 'ModeloDeclaracion' en la página princial");

            string numeroModelo = this["ModeloDeclaracion"].Valor.ToString();

            peticionInicializarEnvio.PeticionHttp.Headers.Add("MODELO", numeroModelo);
            peticionInicializarEnvio.PeticionHttp.Headers.Add("EJERCICIO", Ejercicio);
            peticionInicializarEnvio.PeticionHttp.Headers.Add("PERIODO", Periodo);
            peticionInicializarEnvio.PeticionHttp.Headers.Add("NDC", $"{this["NIF"].Valor}");
            peticionInicializarEnvio.PeticionHttp.Headers.Add("IDIOMA", "ES");
            peticionInicializarEnvio.PeticionHttp.Headers.Add("NUMBLOQUES", "1");
            peticionInicializarEnvio.PeticionHttp.Headers.Add("CODIFICACION", "UTF-8");

            var respuestaTgvi = peticionInicializarEnvio.Presentar() as RespuestaTgvi;

            if (respuestaTgvi.Erronea)
                return respuestaTgvi;

            string cookie = respuestaTgvi.Cookie;

            // 2. Envío datos

            if ((RegistroCampos[indiceUltimaPagina] as ConjuntoDeEmpaquetables).Empaquetables.Count > 40000)
                throw new NotImplementedException("No implementada la paginación.");

            VariablesEnvio[""] = registroTipo2;

            var peticionEnvio = new PeticionTgvi(this, test, certRef, certClave, "EnviarDatos");

            peticionEnvio.PreparaPeticion();

            peticionEnvio.PeticionHttp.Headers.Add("IDENVIO", respuestaTgvi.IdEnvio);
            peticionEnvio.PeticionHttp.Headers.Add("NUMBLOQUE", "1");
            peticionEnvio.PeticionHttp.Headers.Add("CODIFICACION", "UTF-8");
            peticionEnvio.PeticionHttp.Headers.Add("Set-Cookie", cookie);


            respuestaTgvi = peticionEnvio.Presentar() as RespuestaTgvi;

            if (respuestaTgvi.Erronea)
            {
                RespuestaError errorInicial = respuestaTgvi.Errores[0];

                // Obtenemos el fichero con los registros erróneos.

                var peticionErrores = new PeticionTgvi(this, test, certRef, certClave, "RecuperarErrores");

                peticionErrores.PreparaPeticion();

                peticionErrores.PeticionHttp.Headers.Add("IDENVIO", respuestaTgvi.IdEnvio);
                peticionErrores.PeticionHttp.Headers.Add("CODIFICACION", "UTF-8");
                peticionErrores.PeticionHttp.Headers.Add("Set-Cookie", cookie);

                respuestaTgvi = peticionErrores.Presentar() as RespuestaTgvi;

                respuestaTgvi.Errores.Add(errorInicial);

                return respuestaTgvi;
            }

            // 3. Presentación

            VariablesEnvio[""] = "";

            var peticionPresentacion = new PeticionTgvi(this, test, certRef, certClave, "PresentarEnvio");

            peticionPresentacion.PreparaPeticion();

            peticionPresentacion.PeticionHttp.Headers.Add("IDENVIO", respuestaTgvi.IdEnvio);
            peticionPresentacion.PeticionHttp.Headers.Add("FIRNIF", peticionPresentacion.CertificadoTitular.NIF);
            peticionPresentacion.PeticionHttp.Headers.Add("FIRNOMBRE", peticionPresentacion.CertificadoTitular.Nombre);
            peticionPresentacion.PeticionHttp.Headers.Add("FIR", "FirmaBasica");
            peticionEnvio.PeticionHttp.Headers.Add("Set-Cookie", cookie);


            respuestaTgvi = peticionPresentacion.Presentar() as RespuestaTgvi;

            if (respuestaTgvi.Erronea)
                return respuestaTgvi;

            string pdfUrlServer = Parametros.Actuales.Pruebas ? "www6.aeat.es" : (test ? "www6.aeat.es" : "www2.agenciatributaria.gob.es");
            string pdfUrl = $"https://{pdfUrlServer}/wlpl/inwinvoc/es.aeat.dit.adu.eeca.catalogo.VisualizaSc?COMPLETA=SI&ORIGEN=D&CSV={respuestaTgvi.CSV}";

            respuestaTgvi.DescargaPdfEnlace(pdfUrl);

            return respuestaTgvi;
        }

        #endregion
    }
}
