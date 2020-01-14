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


using AeatModelos.Conversores;
using System;
using System.Reflection;

namespace AeatModelos
{

    /// <summary>
    /// Representa un registro de un diseño de registro
    /// de la AEAT para un modelo determina..
    /// </summary>
    public class RegistroCampo : IEmpaquetable
    {

        /// <summary>
        /// Convierte datos obtenido de un archivo al formato
        /// utilizable por la aplicación y datos generados por
        /// la aplicación a formato para el archivo.
        /// </summary>
        IConversor _Conversor;

        /// <summary>
        /// Valor del campo.
        /// </summary>
        object _Valor;

        /// <summary>
        /// Valor del campo procedente del fichero.
        /// </summary>
        string _ValorFichero;

        /// <summary>
        /// Pagína del Registro
        /// </summary>
        public int Pagina { get; private set; }

        /// <summary>
        /// Posición que ocupa el registro 
        /// </summary>
        public int Posicion { get; private set; }

        /// <summary>
        /// Longitud del campo.
        /// </summary>
        public int Longitud { get; private set; }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion { get; private set; }

        /// <summary>
        /// Clave unívoca del campo en la página. Se utiliza
        /// como clave el número de casilla en el modelo.
        /// </summary>
        public string Clave { get; private set; }

        /// <summary>
        /// Tipo de dato.
        /// </summary>
        public RegistroCampoTipo Tipo { get; private set; }

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                return _Valor;
            }
            set
            {
                _Valor = value;
                _Conversor.AFichero();
            }
        }

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public string ValorFichero
        {
            get
            {
                return _ValorFichero;
            }
            set
            {
                _ValorFichero = value;
                _Conversor.DeFichero();
            }
        }

        /// <summary>
        /// Número de decimales para campos numéricos. Valor por defecto 2.
        /// </summary>
        public int Decimales { get; private set; }

        /// <summary>
        /// Indica si el valor acepta números negativos.
        /// </summary>
        public bool Negativo { get; private set; }

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descripción del campo o clave si la tiene.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {
                if(Descripcion == descripcion)
                    return this;

                if(Clave != null && Clave == descripcion)
                    return this;

                return null;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="pagina">Pagina del modelo que representa el fichero 
        /// en la que se encuentra la instancia de registro de campo definida
        /// en el diseño de registro correspondiente de la AEAT.</param>
        /// <param name="posicion">Posición dónde empieza el registro
        /// de la instancia en la página del modelo.</param>
        /// <param name="longitud">Longitud del campo.</param>
        /// <param name="tipo">Cadena que representa el tipo de dato
        /// según la documentación del diseño de registro de la AEAT ('A',
        /// 'An', 'N'...)</param>
        /// <param name="descripcion">Descripción del campo en el diseño
        /// de registro de la AEAT.</param>
        /// <param name="clave">clave únivoca del campo en la página. Genralmente se utiliza como
        /// clave el número de casilla.</param>
        /// <param name="valor">Valor para el campo.</param>
        /// <param name="decimales">Número de decimales.</param>
        /// <param name="negativo">Indica si acepta número negativos.</param> 
        public RegistroCampo(int pagina, int posicion, int longitud, 
            string tipo, string descripcion, string clave = null, 
            object valor = null, int decimales = 2, bool negativo = false)
        {

            RegistroCampoTipo registroTipo;

            if (!Enum.TryParse(tipo, out registroTipo))
                throw new ArgumentException(
                    Errores.MostrarMensaje("Registro.Registro.000", tipo));

            Tipo = registroTipo;

            if(pagina < 0 || pagina > 30)
                throw new ArgumentException(
                    Errores.MostrarMensaje("Registro.Registro.001", $"{pagina}"));

            if (posicion < 0 || posicion > 10000)
                throw new ArgumentException(
                    Errores.MostrarMensaje("Registro.Registro.002", $"{posicion}"));

            if (longitud < 0 || longitud > 2000)
                throw new ArgumentException(
                    Errores.MostrarMensaje("Registro.Registro.003", $"{longitud}"));

            Pagina = pagina;
            Posicion = posicion;
            Longitud = longitud;
            Descripcion = descripcion;
            Clave = clave;
            Decimales = decimales;
            Negativo = negativo;

            string nombreTipoConversor = $"AeatModelos.Conversores.{Tipo}";
            Type tipoConversor = AeatModelosContexto.AeatModelos.GetType(nombreTipoConversor);

            _Conversor = Activator.CreateInstance(tipoConversor, this) as IConversor;


            Valor = valor;

        }


        /// <summary>
        /// Recupera la representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.
        /// </summary>
        /// <returns> Representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.</returns>
        public string AFichero()
        {
            return ValorFichero;
        }

        /// <summary>
        /// Compone un empaquetable a partir de su forma
        /// en texto de fichero.
        /// </summary>
        /// <param name="texto">Segmento de texto.</param>
        /// <returns>Objeto representado 
        /// por el segmento de texto</returns>
        public object DeFichero(string texto)
        {
            ValorFichero = texto;
            return Valor;
        }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{Descripcion}, {Valor}";
        }     

    }
}
