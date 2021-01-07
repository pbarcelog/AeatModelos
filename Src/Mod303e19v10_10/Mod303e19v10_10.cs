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

using System.Collections.Generic;

namespace AeatModelos.Mod303e19v10_10
{

    /// <summary>
    /// Página 0 modelo 303. Diseño de registro: DR303e19v10_10.xlsx.
    /// Lo único que cambia respecto a la versión anterior es la supresión
    /// del salto de línea al final de esta página en la que anteriormente era
    /// la posición número 16.
    /// </summary>
    public class Mod303e19v10_10 : Mod303e18v10_20.Mod303e18v10_20
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e19v10_10(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod303e19v10_10.Mod303e19v10_10p01"},
                {2, "AeatModelos.Mod303e19v10_10.Mod303e19v10_10p02"},
                {3, "AeatModelos.Mod303e19v10_10.Mod303e19v10_10p03"},
                {4, "AeatModelos.Mod303e19v10_10.Mod303e19v10_10p04"}
            };


            RegistroCampos[14] = new ConjuntoDeEmpaquetables()
            {
                Empaquetables = new List<IEmpaquetable>() {
                    new Mod303e19v10_10p01(Ejercicio, Periodo) }
            };

            Paginas = RegistroCampos[14] as ConjuntoDeEmpaquetables;

            RegistroCampos.Remove(16);

            // Cambia el orden de las variables en la presentación telemática.
            OrdenVariablesEnvio = new string[6] { "FIRNIF", "FIRNOMBRE", "NRC", "IDI", "F01", "FIR" };

        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
            base.Calcular();

            RegistroModPagina modPagina1 = Paginas.Empaquetables[0] as RegistroModPagina;

            // Último perido no válido valor 0 (establecemos por defecto el valor 2, no exonerado de 390)
            if ($"{modPagina1["Periodo"].Valor}" == "4T" || $"{modPagina1["Periodo"].Valor}" == "12")
                modPagina1["Exonerado390"].Valor = 2; // (1=SI, 2=NO)

        }

        #endregion

    }
}
