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

namespace AeatModelos.Mod130e15v11
{

    /// <summary>
    /// Página 0 modelo 130. Diseño de registro: DR130e15v11.xlsx.
    /// </summary>
    public class Mod130e15v11 : RegistroModPagina
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod130e15v11(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod130e15v11.Mod130e15v11p01"}
            };

            string p = "000";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<T"                    )},
                {++c,    new RegistroCampo(0,   3,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "130"                   )},
                {++c,    new RegistroCampo(0,   6,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0"                     )},
                {++c,    new RegistroCampo(0,   7,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Ejercicio               )},
                {++c,    new RegistroCampo(0,  11,   2,  "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Periodo                 )},
                {++c,    new RegistroCampo(0,  13,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0000>"                 )},
                {++c,    new RegistroCampo(0,  18,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<AUX>"                 )},
                {++c,    new RegistroCampo(0,  23,  70,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 70)     )},
                {++c,    new RegistroCampo(0,  93,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  AeatModelosContexto.VersionDelPrograma)},
                {++c,    new RegistroCampo(0,  97,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 4)      )},
                {++c,    new RegistroCampo(0, 101,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  AeatModelosContexto.NIFEmpresaDesarrollo)},
                {++c,    new RegistroCampo(0, 110, 213,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 213)    )},
                {++c,    new RegistroCampo(0, 323,   6,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "</AUX>"                )},
                
                // En principio sólo se incluye la página 1.
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                            new Mod130e15v11p01(Ejercicio, Periodo)
                } } },

                {++c,    new RegistroCampo(0,   0,  18,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  $"</T1300{Ejercicio}{Periodo}0000>")},
                {++c,    new RegistroCampo(0,   0,   0,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   '\n'                    )},
            };

            Paginas = RegistroCampos[14] as ConjuntoDeEmpaquetables;

        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
            Mod130e15v11p01 modPagina1 = Paginas.Empaquetables[0] as Mod130e15v11p01;

            decimal rendimientoAeEds = Convert.ToDecimal(modPagina1["01"]?.Valor) - 
                Convert.ToDecimal(modPagina1["02"]?.Valor);

            if (rendimientoAeEds != 0)
                if (Convert.ToDecimal(modPagina1["03"]?.Valor) == 0)
                    modPagina1["03"].Valor = rendimientoAeEds;

            if (rendimientoAeEds > 0)
            {           

                if (Convert.ToDecimal(modPagina1["04"]?.Valor) == 0)
                    modPagina1["04"].Valor = Math.Round(rendimientoAeEds * 0.2m, 2);

            }

            if (Convert.ToDecimal(modPagina1["07"]?.Valor) == 0)
                modPagina1["07"].Valor = Convert.ToDecimal(modPagina1["04"]?.Valor) -
                    Convert.ToDecimal(modPagina1["05"]?.Valor) -
                    Convert.ToDecimal(modPagina1["06"]?.Valor);


            decimal rendimientoAagfp = Convert.ToDecimal(modPagina1["08"]?.Valor) * 0.02m;

            if (rendimientoAagfp != 0)
            {

                if(Convert.ToDecimal(modPagina1["09"]?.Valor) == 0)
                    modPagina1["09"].Valor = rendimientoAagfp;

                if (Convert.ToDecimal(modPagina1["11"]?.Valor) == 0)
                    modPagina1["11"].Valor = Convert.ToDecimal(modPagina1["09"]?.Valor) -
                    Convert.ToDecimal(modPagina1["10"]?.Valor);
            }

            decimal pagosPreviosTrim = Convert.ToDecimal(modPagina1["07"]?.Valor) +
                    Convert.ToDecimal(modPagina1["11"]?.Valor);

            modPagina1["12"].Valor = pagosPreviosTrim > 0 ? pagosPreviosTrim : 0;


            if(Convert.ToDecimal(modPagina1["14"]?.Valor) == 0)
                modPagina1["14"].Valor = Convert.ToDecimal(modPagina1["12"]?.Valor) -
                    Convert.ToDecimal(modPagina1["13"]?.Valor);

            if (Convert.ToDecimal(modPagina1["17"]?.Valor) == 0)
                modPagina1["17"].Valor = Convert.ToDecimal(modPagina1["14"]?.Valor) -
                    Convert.ToDecimal(modPagina1["15"]?.Valor) -
                    Convert.ToDecimal(modPagina1["16"]?.Valor);

            decimal resultadoAutoliquidacion = Convert.ToDecimal(modPagina1["17"]?.Valor) -
                    Convert.ToDecimal(modPagina1["18"]?.Valor);

            if (Convert.ToDecimal(modPagina1["19"]?.Valor) == 0 && resultadoAutoliquidacion > 0)
                modPagina1["19"].Valor =  Convert.ToDecimal(modPagina1["17"]?.Valor) -
                    Convert.ToDecimal(modPagina1["18"]?.Valor);

        }


    }
}
