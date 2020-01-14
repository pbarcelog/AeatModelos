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


using System;
using System.Collections.Generic;

namespace AeatModelos.Mod303e18v10_40
{

    /// <summary>
    /// Página 0 modelo 303. Diseño de registro: DR303e18v10_40.xlsx.
    /// Los únicos cambios respecto a la versión anterior están en la
    /// página 3 en lo que se refiere a la Nota 1.
    /// </summary>
    public class Mod303e18v10_40 : Mod303e18v10_20.Mod303e18v10_20
    { 

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_40(string ejercicio, string periodo) : base(ejercicio, periodo)
        {       

            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod303e18v10_40.Mod303e18v10_40p01"},
                {2, "AeatModelos.Mod303e18v10_40.Mod303e18v10_40p02"},
                {3, "AeatModelos.Mod303e18v10_40.Mod303e18v10_40p03"},
                {4, "AeatModelos.Mod303e18v10_40.Mod303e18v10_40p04"}
            };

            RegistroCampos[14] = new ConjuntoDeEmpaquetables()
            {
                Empaquetables = new List<IEmpaquetable>() {
                    new Mod303e18v10_40p01(Ejercicio, Periodo) }
            };

            Paginas = RegistroCampos[14] as ConjuntoDeEmpaquetables;

        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
            base.Calcular();
        }


    }
}
