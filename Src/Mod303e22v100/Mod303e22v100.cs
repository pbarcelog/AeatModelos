/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2022 Irene Solutions SL
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

using System;
using System.Collections.Generic;

namespace AeatModelos.Mod303e22v100
{

    /// <summary>
    /// Página 0 modelo 303. Diseño de registro: DR303e22.xlsx.
    /// </summary>
    public class Mod303e22v100 : Mod303e21v103.Mod303e21v103
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e22v100(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod303e22v100.Mod303e22v100p01"},
                {2, "AeatModelos.Mod303e22v100.Mod303e22v100p02"},
                {3, "AeatModelos.Mod303e22v100.Mod303e22v100p03"},
                {4, "AeatModelos.Mod303e22v100.Mod303e22v100p04"},
                {5, "AeatModelos.Mod303e22v100.Mod303e22v100p05"}
            };

            RegistroCampos[14] = new ConjuntoDeEmpaquetables()
            {
                Empaquetables = new List<IEmpaquetable>() { new Mod303e22v100p01(Ejercicio, Periodo) }
            };

            Paginas = RegistroCampos[14] as ConjuntoDeEmpaquetables;

        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// En caso de que la declaración sea a devolver realiza las operaciones necesarias.
        /// </summary>
        protected override void PreparaDevolucion()
        {

            IPagina modPagina1 = RecuperaPagina(1, 0, false) as IPagina;
            IPagina modPagina3 = RecuperaPagina(3, 0, false) as IPagina;   

            if (modPagina3 == null)
                throw new ArgumentException($"Se ha seleccionado devolución ('D') como tipo de declaración y no se ha proporcionado IBAN");

            if ($"{modPagina3["IBAN"].Valor}".Trim() == "")
                throw new ArgumentException($"Se ha seleccionado devolución ('D') como tipo de declaración y no se ha proporcionado IBAN");

            modPagina3["DevolucionMarcaSEPA"].Valor = 1;

        }

        #endregion

    }
}
