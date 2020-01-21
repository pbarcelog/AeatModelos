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

namespace AeatModelos
{
    /// <summary>
    /// Representa un registro de modelo que tiene contenido de texto
    /// o constutiye una página del modelo
    /// </summary>
    public class RegistroModPagina : RegistroMod
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public RegistroModPagina(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
        }

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
                if (reg !=null && reg.Posicion != 0)
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

            string thisName = this.GetType().Name;
            string objName = obj.GetType().Name;

            return thisName.CompareTo(objName);
        }
    }
}
