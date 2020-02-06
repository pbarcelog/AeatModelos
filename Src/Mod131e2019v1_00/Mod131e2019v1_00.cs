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
    
    uede evitar el cumplimiento de lo establecido de lo establecido 
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

namespace AeatModelos.Mod131e2019v1_00
{

    /// <summary>
    /// Página 0 modelo 131. Diseño de registro: DR131e2019_v1.00.xlsx.
    /// </summary>
    public class Mod131e2019v1_00 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod131e2019v1_00(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod131e2019v1_00.Mod131e2019v1_00p01"}
            };

            string p = "000";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<T"                    )},
                {++c,    new RegistroCampo(0,   3,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "131"                   )},
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
                            new Mod131e2019v1_00p01(Ejercicio, Periodo)
                } } },

                {++c,    new RegistroCampo(0,   0,  18,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  $"</T1310{Ejercicio}{Periodo}0000>")},
                {++c,    new RegistroCampo(0,   0,   0,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   '\n'                    )},
            };

            Paginas = RegistroCampos[14] as ConjuntoDeEmpaquetables;

        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
            Mod131e2019v1_00p01 modPagina1 = Paginas.Empaquetables[0] as Mod131e2019v1_00p01;

            decimal rendimientoAeEO = Convert.ToDecimal(modPagina1["RendimientoNeto1"]?.Valor)
               + Convert.ToDecimal(modPagina1["RendimientoNeto2"]?.Valor)
               + Convert.ToDecimal(modPagina1["RendimientoNeto3"]?.Valor)
               + Convert.ToDecimal(modPagina1["RendimientoNeto4"]?.Valor)
               + Convert.ToDecimal(modPagina1["RendimientoNeto5"]?.Valor);

            if (rendimientoAeEO != 0)
                if (Convert.ToDecimal(modPagina1["01"]?.Valor) == 0)
                    modPagina1["01"].Valor = rendimientoAeEO;

            decimal pagoAeEO = Convert.ToDecimal(modPagina1["ResultadoAplicacionPorcentaje1"]?.Valor)
            + Convert.ToDecimal(modPagina1["ResultadoAplicacionPorcentaje2"]?.Valor)
            + Convert.ToDecimal(modPagina1["ResultadoAplicacionPorcentaje3"]?.Valor)
            + Convert.ToDecimal(modPagina1["ResultadoAplicacionPorcentaje4"]?.Valor)
            + Convert.ToDecimal(modPagina1["ResultadoAplicacionPorcentaje5"]?.Valor);

            if (pagoAeEO != 0)
                if (Convert.ToDecimal(modPagina1["02"]?.Valor) == 0)
                    modPagina1["02"].Valor = pagoAeEO;

            if (pagoAeEO != 0)
                if (Convert.ToDecimal(modPagina1["07"]?.Valor) == 0)
                    modPagina1["07"].Valor = pagoAeEO;

            if (pagoAeEO != 0)
                if (Convert.ToDecimal(modPagina1["10"]?.Valor) == 0)
                    modPagina1["10"].Valor = pagoAeEO;

            if (pagoAeEO != 0)
                if (Convert.ToDecimal(modPagina1["13"]?.Valor) == 0)
                    modPagina1["13"].Valor = pagoAeEO;

            if (pagoAeEO != 0)
                if (Convert.ToDecimal(modPagina1["15"]?.Valor) == 0)
                    modPagina1["15"].Valor = pagoAeEO;

        }

        #endregion

    }
}
