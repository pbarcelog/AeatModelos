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
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace AeatModelos
{

    /// <summary>
    /// Modelo de un resgistro.
    /// </summary>
    public class RegistroMod : IEmpaquetable, IModelo
    {

        #region Variables Privadas Estáticas

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
            {"<T369", "AeatModelos.Mod303e19v10_10.Mod303e19v10_10" },
        };

        #endregion

        #region Variables Privadas de Instancia

        /// <summary>
        /// Indica si el usuario a confirmado la declaración.
        /// </summary>
        protected bool _Confirmado = false;

        /// <summary>
        /// Almacena el valor del fichero del modelo.
        /// </summary>
        string _Valor;

        #endregion

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public RegistroMod(string ejercicio, string periodo)
        {
            
            Ejercicio = ejercicio;
            Periodo = periodo;

            IniciaEnlaces();

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

        #endregion

        #region Indexadores

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

        #endregion

        #region Métodos Privados de Instancia

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
                else if (reg.Value.Descripcion.Trim() == "Modelo")
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
                var segmento = string.IsNullOrEmpty(variable) ? valor : $"{variable}={valorCodificado}";
                segmentos[segmentoIndice++] = segmento;
            }

            return string.Join("&", segmentos);

        }

        /// <summary>
        /// Inicia los enlaces de los servicios correspondientes al modelo.
        /// </summary>
        internal virtual void IniciaEnlaces() 
        {

            Enlaces = new GestorDeEnlaces(Comunicaciones.Enlaces.PftwPicwPresBasica,
                Comunicaciones.Enlaces.PftwPicwPresBasicaPruebas);

        }

        #endregion

        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Codificación utilizada por la AEAT.
        /// </summary>
        public Encoding Encoding = Encoding.GetEncoding("ISO-8859-1");


        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Código de modelo AEAT.
        /// </summary>
        public string Modelo { get; internal set; }

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
        /// Si la instancia actual contiene registros de
        /// detalle estos se muestran como ConjuntoDeEmpaquetables
        /// en esta propiedad. Si no el valor de la propiedad
        /// es null.
        /// </summary>
        public ConjuntoDeEmpaquetables Registros { get; protected set; }

        /// <summary>
        /// Enlaces de los servicios de presentación.
        /// </summary>
        public GestorDeEnlaces Enlaces { get; protected set; }

        #endregion

        #region Métodos Públicos Estáticos

        /// <summary>
        /// Crear un modelo para la generación de impuestos.
        /// </summary>
        /// <param name="clave">Nombre del modelo a obtener</param>
        /// <param name="ejercicio">Nombre del modelo a obtener</param>
        /// <param name="periodo">Nombre del modelo a obtener</param>
        /// <returns>Modelo tributario determinado por la clave.</returns>
        public static IModelo CrearModelo(string clave,
            string ejercicio, string periodo = "0A")
        {
            return CrearEmpaquetable(clave, ejercicio, periodo) as IModelo;
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

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Añade una página del índice específicado.
        /// </summary>
        /// <param name="indicePagina">Indice de la página a añadir.</param>
        /// <returns>Página añadida.</returns>
        public RegistroMod InsertaPagina(int indicePagina)
        {
            
            if (!PaginasMapa.ContainsKey(indicePagina))
                throw new ArgumentException(
                    Errores.MostrarMensaje("RegistroMod.000", $"{indicePagina}"));

            string typeName = PaginasMapa[indicePagina];

            Type tipoEmpaquetable = Type.GetType(typeName);
            RegistroMod pagina = Activator.CreateInstance(tipoEmpaquetable, Ejercicio, Periodo) as RegistroMod;

            Paginas.Empaquetables.Add(pagina);

            return pagina;

        }

        /// <summary>
        /// Recupera la página del índice específicado.
        /// </summary>
        /// <param name="indicePagina">Indice de la página a añadir.</param>
        /// <param name="indiceGrupo">Cuando existen varía páginas
        /// del mimo número de página en el modelo, aquí se indica
        /// el indice en base 0 de la página que se quiere recuperar 
        /// (si no se especifica se devuelve la primera coincidencia).</param>
        /// <param name="crear">Si es true y no se encuentra la página
        /// entre los empaquetables, la crea.</param>
        /// <param name="numeroPaginaHija">Indica si se tiene que resuperar una subpágina
        /// contenida en la página principal indicada por indice en base 1 de la subpágina</param>
        /// <returns>Página recuperada si existe, recién creada
        /// si no existe y crear=true o null si no existe e índiceGrupo no
        /// es igual a 0 o crear es false.</returns>
        public RegistroMod RecuperaPagina(int indicePagina, int indiceGrupo = 0, 
            bool crear = false, int numeroPaginaHija = 0)
        {

            RegistroMod paginaPrincipal = null;

            if (indicePagina == -1)
                paginaPrincipal = this;            

            if (paginaPrincipal == null && !PaginasMapa.ContainsKey(indicePagina))
                throw new ArgumentException(Errores.MostrarMensaje("RegistroMod.000", $"{indicePagina}"));

            if (paginaPrincipal == null)
            {

                int count = 0;

                string typeName = PaginasMapa[indicePagina];

                Type tipoObjetivo = Type.GetType(typeName);

                if (paginaPrincipal == null)
                    foreach (var pagina in Paginas.Empaquetables)
                        if (pagina.GetType().IsAssignableFrom(tipoObjetivo) && indiceGrupo == count++)
                            paginaPrincipal = pagina as RegistroMod;

                if (paginaPrincipal == null && crear) // Si la página no existe y se permite crear.
                    paginaPrincipal = InsertaPagina(indicePagina);

            }

            if (numeroPaginaHija == 0) // Si no busco una página hija, devuelvo la actual
                return paginaPrincipal;

            // Si busco una página hija

            if (paginaPrincipal?.Registros?.Empaquetables != null && paginaPrincipal?.Registros?.Empaquetables.Count < numeroPaginaHija -1)
                throw new ArgumentException(Errores.MostrarMensaje("ConjuntoDeEmpaquetables.001", $"{numeroPaginaHija-1}"));

            return paginaPrincipal?.Registros?.Empaquetables[numeroPaginaHija-1] as RegistroMod;

        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public virtual void Calcular()
        {
            throw new NotImplementedException(Errores.MostrarMensaje("RegistroMod.001",
                  "método Calcular() de la clase RegistroMod"));
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

            if(Paginas?.Empaquetables != null)
                Paginas.Empaquetables.Sort();

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
        /// <returns>Patrón para regex extracción páginas</returns>
        public string GenerarPatronRegexPagina()
        {
            return $"{GenerarPatronRegexInicioPagina()}[\\s\\S]+{GenerarPatronRegexFinalPagina()}";
        }

        /// <summary>
        /// Devuelve una cadena con la representación del titular del
        /// certificado que va a realizar la presentación.
        /// </summary>
        public string Presentador(string certRef = null, string certClave = null)
        {
            var certificado = Certificado.Cargar(certRef, certClave);

            var titular = Certificado.Titular(certificado);

            if (titular == null)
                throw new Exception(
                    Errores.MostrarMensaje("RegistroMod.002", $"{ certificado.Subject}"));

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
        /// <param name="test">Indica si la presentación se realiza en el entorno en pruebas de la AEAT.</param>
        /// <param name="certRef">Ruta de certificado para la presentación, en caso de que se utilice uno externo.</param>
        /// <param name="certClave">Contraseña del certificado.</param>
        /// </summary>
        /// <returns>Respuesta a la operación de presentación.</returns>
        public virtual Respuesta Presentar(bool test = false, string certRef = null, string certClave = null)
        {

            if (!_Confirmado)
                throw new InvalidOperationException(Errores.MostrarMensaje("RegistroMod.003"));

            return new Peticion(this, test, certRef, certClave).Presentar();

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

        /// <summary>
        /// Prueba la descarga con certificado sobre el enlace de entrada.
        /// </summary>
        /// <param name="enlace">Url del pdf a descargar.</param>
        /// <returns>Datos binarios de la respuesta.</returns>
        public static byte[] DescargaPdfMedianteEnlace(string enlace)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(enlace);
            httpWebRequest.Method = "GET";
            httpWebRequest.ClientCertificates.Add(Certificado.Cargar());

            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            byte[] result = null;

            using (var stream = httpWebResponse.GetResponseStream())
            using (BinaryReader lectorBinario = new BinaryReader(stream))
                result = lectorBinario.ReadBytes((int)httpWebResponse.ContentLength);

            return result;
        }

        /// <summary>
        /// Prueba la descarga del PDF de liquidación asociado al CSV.
        /// Esto es un 'hack - chapuzilla' para cuando la presentación en real tiene el servidor parado.
        /// Probamos a descargar el documento PDF desde otro repositorio de la AEAT (disponible dentro del
        /// apartado de colaboradores con el certificado de colaborador para un CSV presentado).
        /// </summary>
        /// <param name="csv">Código seguro de verificación asociado al documento PDF de liquidación.</param>
        /// <returns>Documento PDF de liquidación.</returns>
        public static byte[] DescargarPdfMedianteCSV(string csv)
        {
            string enlaceSegundoRepositorio = "https://www1.agenciatributaria.gob.es/wlpl/inwinvoc/" +
                "es.aeat.dit.adu.eeca.catalogo.vis.Visualiza?COMPLETA=SI&ORIGEN=C&CLAVE_CAT=&NIF=&ANAGRAMA=&CSV=" +
                csv +
                "&CLAVE_EE=&PAGE=&SEARCH=";

            return DescargaPdfMedianteEnlace(enlaceSegundoRepositorio);
        }

        #endregion

    }
}
