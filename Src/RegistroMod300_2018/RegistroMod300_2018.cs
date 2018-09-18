/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2018 Irene Solutions SL
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

namespace AeatModelos.RegistroMod300_2018
{

    /// <summary>
    /// Página 0 modelo 303. Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class RegistroMod300_2018 : RegistroMod
    { 

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public RegistroMod300_2018(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "000";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<T"                    )},
                {++c,    new RegistroCampo(0,   3,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "303"                   )},
                {++c,    new RegistroCampo(0,   6,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0"                     )},
                {++c,    new RegistroCampo(0,   7,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Ejercicio               )},
                {++c,    new RegistroCampo(0,  11,   2,  "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Periodo                 )},
                {++c,    new RegistroCampo(0,  13,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0000>"                 )},
                {++c,    new RegistroCampo(0,  18,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<AUX>"                 )},
                {++c,    new RegistroCampo(0,  23,  70,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 70)     )},
                {++c,    new RegistroCampo(0,  93,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Configuracion.VersionDelPrograma)},
                {++c,    new RegistroCampo(0,  97,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 4)      )},
                {++c,    new RegistroCampo(0, 101,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Configuracion.NIFEmpresaDesarrollo)},
                {++c,    new RegistroCampo(0, 110, 213,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 213)    )},
                {++c,    new RegistroCampo(0, 323,   6,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "</AUX>"                )},
                
                // En principio sólo se incluye la página 1.
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                            new RegistroMod300_2018p01(Ejercicio, Periodo)
                } } },

                {++c,    new RegistroCampo(0,   0,  18,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  $"</T3030{Ejercicio}{Periodo}0000>")},
                {++c,    new RegistroCampo(0,   0,   0,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   '\n'                    )},
            };

            Paginas = RegistroCampos[14] as ConjuntoDeEmpaquetables;

        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {

            RegistroMod300_2018p01 modPagina1 = Paginas.Empaquetables[0] as RegistroMod300_2018p01;
            RegistroMod300_2018p02 modPagina2 = null;

            if (Paginas.Empaquetables.Count > 1)
                modPagina2 = Paginas.Empaquetables[1] as RegistroMod300_2018p02;

            RegistroMod300_2018p03 modPagina3 = null;
         
            for (int p = Paginas.Empaquetables.Count - 1; p > -1; p--)
                modPagina3 = Paginas.Empaquetables[Paginas.Empaquetables.Count - 1] as RegistroMod300_2018p03;

            if (modPagina3 == null)
            {
                modPagina3 = new RegistroMod300_2018p03(Ejercicio, Periodo);
                Paginas.Empaquetables.Add(modPagina3);
            }


            decimal suma = 0;
            string[] clavesASumar = null;

            // Total cuota devengada ( [03] + [06] + [09] + [11] + [13] + [15] + [18] + [21] + [24] + [26])

            clavesASumar = new string[] { "03", "06", "09", "11", "13", "15", "18", "21", "24", "26" };               

            foreach (var clave in clavesASumar)
                suma += Convert.ToDecimal(modPagina1[clave]?.Valor);

            modPagina1["27"].Valor = suma;

            // Total a deducir ( [29] + [31] + [33] + [35] + [37] + [39] + [41] + [42] + [43] + [44] )

            suma = 0;
            clavesASumar = new string[] { "29", "31", "33", "35", "37", "39", "41", "42", "43", "44" };

            foreach (var clave in clavesASumar)
                suma += Convert.ToDecimal(modPagina1[clave]?.Valor);

            modPagina1["45"].Valor = suma;

            // Resultado régimen general ( [27] - [45] )

            modPagina1["46"].Valor = Convert.ToDecimal(modPagina1["27"].Valor) - suma;

            // Suma de resultados ( [46] + [58] + [76] )
            modPagina3["64"].Valor = Convert.ToDecimal(modPagina1["46"].Valor) + 
                ((modPagina2==null)?0:Convert.ToDecimal(modPagina2["58"].Valor)) + 
                Convert.ToDecimal(modPagina3["76"].Valor);

            // Atribuible a la Administracion del Estado
            modPagina3["65"].Valor = 100;

            // Atribuible a la Administración del Estado
            modPagina3["66"].Valor = Math.Round(Convert.ToDecimal(modPagina3["65"].Valor) / 100 *
                Convert.ToDecimal(modPagina3["64"].Valor), 2);

            // Resultado ( [66] + [77] - [67] + [68] )
            modPagina3["69"].Valor = Convert.ToDecimal(modPagina3["66"].Valor) +
            Convert.ToDecimal(modPagina3["77"].Valor) -
            Convert.ToDecimal(modPagina3["67"].Valor) +
            Convert.ToDecimal(modPagina3["68"].Valor);

           modPagina3["71"].Valor = Convert.ToDecimal(modPagina3["69"].Valor) -
           Convert.ToDecimal(modPagina3["70"].Valor);


        }


    }
}
