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
namespace AeatModelos
{
    /// <summary>
    /// Representa un registro de modelo que tiene contenido de texto
    /// o constutiye una página del modelo
    /// </summary>
    public class RegistroModPagina : RegistroMod, IPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public RegistroModPagina(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
        }

        #endregion       

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Compone un empaquetable a partir de su forma
        /// en texto de fichero.
        /// </summary>
        /// <param name="texto">Segmento de texto.</param>
        /// <returns>Objeto representado 
        /// por el segmento de texto</returns>
        public override object DeFichero(string texto)
        {
            foreach (var regKvp in RegistroCampos)
            {
                var reg = (regKvp.Value as RegistroCampo);
                if (reg != null && reg.Posicion != 0)
                {
                    int start = reg.Posicion - 1; // de base 1 a base 0

                    if (texto.Length > start + reg.Longitud)
                    {
                        var token = texto.Substring(start, reg.Longitud);
                        reg.ValorFichero = token;
                        if (reg.Descripcion == "Periodo")
                            Periodo = reg.ValorFichero;
                    }
                }
            }

            return this;
        }

        /// <summary>
        /// Comparación entre 2 objetos de página.
        /// </summary>
        /// <param name="obj">Página a comparar.</param>
        /// <returns>Resultado de la comparación.</returns>
        public override int CompareTo(object obj)
        {
            RegistroModPagina onePage = (RegistroModPagina)obj;

            // Obtenemos del modelo la parte en la que pone "p01", 
            // ya que el año puede hacer que un "2018p03" vaya antes que un "2019p01". 
            string thisName = GetType().Name.Substring(GetType().Name.Length - 3);
            string objName = obj.GetType().Name.Substring(obj.GetType().Name.Length - 3);

            return thisName.CompareTo(objName);
        }

        #endregion

    }
}
