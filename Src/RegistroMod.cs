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


using AeatModelos.Comunicaciones;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace AeatModelos
{

    /// <summary>
    /// Modelo de un resgistro.
    /// </summary>
    public class RegistroMod : IEmpaquetable
    {

        /// <summary>
        /// Indica si el usuario a confirmado la declaración.
        /// </summary>
        bool _Confirmado = false;

        /// <summary>
        /// Almacena el valor del fichero del modelo.
        /// </summary>
        string _Valor;

        /// <summary>
        /// Mapa de texto inicial para la determinación del modelo en un archivo determinado.
        /// </summary>
        static Dictionary<string, string> _MagicTokens = new Dictionary<string, string>()
        {

            {"<T111", "AeatModelos.Mod111e16v18.Mod111e16v18" },
            {"<T115", "AeatModelos.Mod115e15v13.Mod115e15v13" },
            {"<T130", "AeatModelos.Mod130e15v11.Mod130e15v11" },
            {"<T131", "AeatModelos.Mod131e2019v1_00.Mod131e2019v1_00" },
            {"<T303", "AeatModelos.Mod303e19v10_10.Mod303e19v10_10" },
        };

        /// <summary>
        /// Codificación utilizada por la AEAT.
        /// </summary>
        public static Encoding Encoding = Encoding.GetEncoding("ISO-8859-1");

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                if (_Valor == null)
                    _Valor = AFichero();
               
                 return _Valor;
            }
            set
            {
                _Valor = $"{value}";
            }
        }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion
        {
            get
            {
                return $"{GetType()}";
            }          
        }

        /// <summary>
        /// Ejercicio de la autoliquidación.
        /// </summary>
        public string Ejercicio { get; private set; }

        /// <summary>
        /// Periodo de la autoliquidación.
        /// </summary>
        public string Periodo { get; protected set; }

        /// <summary>
        /// Diccionario de campos del modelo.
        /// </summary>
        public virtual Dictionary<decimal, IEmpaquetable> RegistroCampos { get; protected set; }

        /// <summary>
        /// Mapa con la equivalencia entre número de página y nombre
        /// del tipo empaquetable que la representa.
        /// </summary>
        public virtual Dictionary<int, string> PaginasMapa { get; protected set; }

        /// <summary>
        /// Variables para el envío de declaraciones.
        /// </summary>
        public virtual Dictionary<string, string> VariablesEnvio { get; protected set; }

        /// <summary>
        /// Matriz con los nombres de las variables de envío a utilizar en
        /// la petición al servicio de presentación en orden de aparación.
        /// </summary>
        public virtual string[] OrdenVariablesEnvio { get; protected set; }

        /// <summary>
        /// Si la instancia actual contiene más páginas
        /// estas se muestran como ConjuntoDeEmpaquetables
        /// en esta propiedad. Si no el valor de la propiedad
        /// es null.
        /// </summary>
        public ConjuntoDeEmpaquetables Paginas { get; protected set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public RegistroMod(string ejercicio, string periodo)
        {
            Ejercicio = ejercicio;
            Periodo = periodo;

            VariablesEnvio = new Dictionary<string, string>() {
                {"FIRNIF",          null },
                {"FIRNOMBRE",       null },
                {"FIR",             "FirmaBasica" },
                {"IDI",             "ES" },
                {"F01",             null },
                {"NRC",             null }
            };

            OrdenVariablesEnvio = new string[6] { "FIRNIF", "FIRNOMBRE", "FIR", "IDI", "F01", "NRC" };

        }

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descipción del campo o clave del campo.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {

                foreach (var parClaveValor in RegistroCampos)
                {
                    RegistroCampo campo = parClaveValor.Value as RegistroCampo;

                    if (campo != null && campo?.Descripcion == descripcion)                 
                        return campo;

                    if (campo != null && campo?.Clave != null && campo?.Clave == descripcion)
                        return campo;
                }
                   
                return null;
            }
        }

        /// <summary>
        /// Añade una página del índice específicado.
        /// </summary>
        /// <param name="indicePagina">Indice de la página a añadir.</param>
        /// <returns>Página añadida.</returns>
        public RegistroMod InsertaPagina(int indicePagina)
        {

            if (!PaginasMapa.ContainsKey(indicePagina))
                throw new ArgumentException($"No existe ningún tipo en el mapa para el índice {indicePagina}.");

            string typeName = PaginasMapa[indicePagina];

            Type tipoEmpaquetable = Type.GetType(typeName);
            RegistroMod pagina =  Activator.CreateInstance(tipoEmpaquetable, Ejercicio, Periodo) as RegistroMod;

            Paginas.Empaquetables.Add(pagina);

            return pagina;

        }

        /// <summary>
        /// Recupera la página del índice específicado.
        /// </summary>
        /// <param name="indicePagina">Indice de la página a añadir.</param>
        /// <returns>Página añadida.</returns>
        public RegistroMod RecuperaPagina(int indicePagina)
        {

            if (!PaginasMapa.ContainsKey(indicePagina))
                throw new ArgumentException($"No existe ningún tipo en el mapa para el índice {indicePagina}.");

            string typeName = PaginasMapa[indicePagina];

            Type tipoObjetivo = Type.GetType(typeName);

            foreach (var pagina in Paginas.Empaquetables)
                if (pagina.GetType().IsAssignableFrom(tipoObjetivo))
                    return pagina as RegistroMod;

            return null;

        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public virtual void Calcular()
        {
            throw new NotImplementedException("No implementado en clase base: " +
                "A implementar en la clase derivada!!!!!");
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

            Calcular();

            StringBuilder constructorTexto = new StringBuilder();

            foreach (KeyValuePair<decimal, IEmpaquetable> entrada in RegistroCampos)
                constructorTexto.Append(entrada.Value.AFichero());

            string resultado = constructorTexto.ToString();

            return $"{resultado}".Replace("\n", "");

        }

        /// <summary>
        /// Compone un empaquetable a partir de su forma
        /// en texto de fichero.
        /// </summary>
        /// <param name="texto">Segmento de texto.</param>
        /// <returns>Objeto representado 
        /// por el segmento de texto</returns>
        public virtual object DeFichero(string texto)
        {
            return CrearEmpaquetable(texto);
        }

        /// <summary>
        /// Genera una expresión para poder extraer el texto de cada página mediante regex.
        /// </summary>
        /// <returns>Patrón para regex inicio página</returns>
        private string GenerarPatronRegexInicioPagina()
        {

            RegistroCampo inicio = null;
            RegistroCampo modelo = null;
            RegistroCampo pagina = null;
            RegistroCampo final = null;

            foreach (var reg in RegistroCampos)
            {
                if (Regex.Match(reg.Value.Descripcion, @"\s*Inicio\s+del\s+identificador\s+de\s+modelo\s+y\s+p[^\d]{1}gina\s*").Success)
                    inicio = (reg.Value as RegistroCampo);
                else if (reg.Value.Descripcion.Trim()== "Modelo")
                    modelo = (reg.Value as RegistroCampo);
                else if (reg.Value.Descripcion.Trim() == "Página")
                    pagina = (reg.Value as RegistroCampo);
                else if (Regex.Match(reg.Value.Descripcion, @"\s*Fin\s+de\s+identificador\s+de\s+modelo\s*").Success)
                    final = (reg.Value as RegistroCampo);
            }

            string patronPagina = $"\\d{{{pagina.Longitud}}}";

            string patronInicio = $"{inicio.ValorFichero}{modelo.ValorFichero}{patronPagina}{final.ValorFichero}";

            return patronInicio;

        }

        /// <summary>
        /// Genera una expresión para poder extraer el texto de cada página mediante regex.
        /// </summary>
        /// <returns>Patrón para regex inicio página</returns>
        private string GenerarPatronRegexFinalPagina()
        {

            RegistroCampo final = null;

            foreach (var reg in RegistroCampos)
                if (Regex.Match(reg.Value.Descripcion, @"\s*Indicador\s+de\s+fin\s+de\s+registro\s*").Success)
                    final = (reg.Value as RegistroCampo);


            return $"{final.ValorFichero}";


        }

        /// <summary>
        /// Genera una expresión para poder extraer el texto de cada página mediante regex.
        /// </summary>
        /// <returns>Patrón para regex extracción páginas</returns>
        public string GenerarPatronRegexPagina()
        {
            return $"{GenerarPatronRegexInicioPagina()}[\\s\\S]+{GenerarPatronRegexFinalPagina()}";
        }


        /// <summary>
        /// Crear empaquetable para la generación de impuestos.
        /// </summary>
        /// <param name="clave">Nombre del empaquetable a obtener</param>
        /// <param name="ejercicio">Nombre del empaquetable a obtener</param>
        /// <param name="periodo">Nombre del empaquetable a obtener</param>
        /// <returns>Empaquetable.</returns>
        public static IEmpaquetable CrearEmpaquetable(string clave, 
            string ejercicio, string periodo = "0A")
        {
            Type tipoEmpaquetable = Type.GetType($"AeatModelos.{clave}.{clave}");
            return Activator.CreateInstance(tipoEmpaquetable, ejercicio, periodo) as IEmpaquetable;
        }

        /// <summary>
        /// Compone un empaquetable a partir de su forma
        /// en texto de fichero.
        /// </summary>
        /// <param name="texto">Segmento de texto.</param>
        /// <returns>Objeto representado 
        /// por el segmento de texto</returns>
        public static IEmpaquetable CrearEmpaquetable(string texto)
        {

            IEmpaquetable modelo = null;
            string ejercicio = null;
            string periodo = null;

            // Recorro los modelos a ver encuentro que tipo de archivo es
            foreach (KeyValuePair<string, string> magicToken in _MagicTokens)
            {
                if (texto.StartsWith(magicToken.Key))
                {
                    modelo = Activator.CreateInstance(Type.GetType(magicToken.Value), $"{DateTime.Now.Year}", "") as IEmpaquetable;
                    ejercicio = texto.Substring(magicToken.Key.Length + 1, 4);
                    periodo = texto.Substring(magicToken.Key.Length + 5, 2);
                }
            }
           

            // primero recupero el punto de inserción de las páginas
            var paginas = (modelo as RegistroMod).Paginas;

            if (paginas == null)
                return modelo;

            paginas.Empaquetables.Clear();

            foreach (var kvpPagina in (modelo as RegistroMod).PaginasMapa)
            {

                var pagina = Activator.CreateInstance(Type.GetType(kvpPagina.Value), ejercicio, periodo) as RegistroMod;
                var patron = (pagina as RegistroMod).GenerarPatronRegexPagina();

                foreach (Match match in Regex.Matches(texto, patron))
                {
                    var textoPagina = match.Value;

                    if (textoPagina != null)
                    {
                        // He encontrado una página, la creo
                        IEmpaquetable paginaModelo = Activator.CreateInstance(pagina.GetType(), $"{DateTime.Now.Year}", "") as IEmpaquetable;
                        var p = (paginaModelo as RegistroModPagina).DeFichero(textoPagina);
                        paginas.Empaquetables.Add(p as IEmpaquetable);
                        texto = texto.Replace(textoPagina, "");
                    }
                }
            }

            // Una vez cargadas las páginas cargo la página 0.
            modelo = (modelo as RegistroModPagina).DeFichero(texto) as IEmpaquetable;

            var mod = (modelo as RegistroModPagina);

            return modelo;

        }

        /// <summary>
        /// Devuelve una cadena con la representación del titular del
        /// certificado que va a realizar la presentación.
        /// </summary>
        public string Presentador() 
        {
            var certificado = Certificado.Cargar();

           var titular = Certificado.Titular(certificado);

            if (titular == null)
                throw new Exception($"No se ha podido determinar el titular del certificado {certificado.Subject}.");

            return $"{titular}";
        }

        /// <summary>
        /// Devuelve una cadena con la representación del titular del
        /// certificado que va a realizar la presentación.
        /// </summary>
        public virtual string Declarante()
        {

            string NIF = $"{Paginas.Empaquetables[0]["NIF"].Valor}";
            string apellidos = $"{Paginas.Empaquetables[0]["ApellidosRazonSocial"].Valor}";
            string nombre = $"{Paginas.Empaquetables[0]["Nombre"].Valor}";

            return $"{NIF}, {apellidos} {nombre}".Trim();
        }

        /// <summary>
        /// Confirma la declaración según las especificaciones de la AEAT
        /// en cuanto a la firma básica. El usuario debe confirmar la declaración
        /// una vez ha revisado el fichero a enviar el presentador y el declarante.
        /// </summary>
        public void Confirmar() 
        {            
            _Confirmado = true;
        }

        /// <summary>
        /// Presenta la declaración.
        /// </summary>
        /// <returns>Respuesta a la operación de presentación.</returns>
        public Respuesta Presentar() 
        {

            if (!_Confirmado)
                throw new InvalidOperationException("Antes de presentar, debe confirmar la declaración.");

            return new Peticion(this).Presentar();
        }

        /// <summary>
        /// Obtiene los datos de presentación para la petición de presentación
        /// de un modelo concreto al servicio de presentación de la AEAT.
        /// </summary>
        /// <returns>Datos de presentación para la petición de presentación
        /// de un modelo concreto al servicio de presentación de la AEAT.</returns>
        internal virtual string DatosPeticionPresentacion() 
        {

            string[] segmentos = new string[OrdenVariablesEnvio.Length];
            var segmentoIndice = 0;

            foreach (var variable in OrdenVariablesEnvio) 
            {
                var valor = VariablesEnvio[variable];
                var valorCodificado = string.IsNullOrEmpty(valor) ? "" : HttpUtility.UrlEncode(valor, Encoding);
                var segmento = $"{variable}={valorCodificado}";
                segmentos[segmentoIndice++] = segmento;
            }           

            return string.Join("&", segmentos);

        }

        /// <summary>
        /// Implementación de IComparable.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns>Resultado de la comparación.</returns>
        public virtual int CompareTo(object obj)
        {
            return 0;
        }
    }
}
