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

using System;
using System.Collections.Generic;

namespace AeatModelos.Mod303e18v10_20
{

    /// <summary>
    /// Página 0 modelo 303. Diseño de registro: DR303e18v10_10.xlsx.
    /// </summary>
    public class Mod303e18v10_20 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e18v10_20(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            Modelo = "303";

            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod303e18v10_20.Mod303e18v10_20p01"},
                {2, "AeatModelos.Mod303e18v10_20.Mod303e18v10_20p02"},
                {3, "AeatModelos.Mod303e18v10_20.Mod303e18v10_20p03"},
                {4, "AeatModelos.Mod303e18v10_20.Mod303e18v10_20p04"}
            };

            string p = "000";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<T"                                          )}, // 01
                {++c,    new RegistroCampo(0,   3,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  Modelo                                        )}, // 02
                {++c,    new RegistroCampo(0,   6,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0"                                           )}, // 03
                {++c,    new RegistroCampo(0,   7,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Ejercicio                                    )}, // 04
                {++c,    new RegistroCampo(0,  11,   2,  "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Periodo                                      )}, // 05
                {++c,    new RegistroCampo(0,  13,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0000>"                                       )}, // 06
                {++c,    new RegistroCampo(0,  18,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<AUX>"                                       )}, // 07
                {++c,    new RegistroCampo(0,  23,  70,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 70)                           )}, // 08
                {++c,    new RegistroCampo(0,  93,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  AeatModelosContexto.VersionDelPrograma        )}, // 09
                {++c,    new RegistroCampo(0,  97,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 4)                            )}, // 10
                {++c,    new RegistroCampo(0, 101,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  AeatModelosContexto.NIFEmpresaDesarrollo      )}, // 11
                {++c,    new RegistroCampo(0, 110, 213,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 213)                          )}, // 12
                {++c,    new RegistroCampo(0, 323,   6,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "</AUX>"                                      )}, // 13
                
                // En principio sólo se incluye la página 1.
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                            new Mod303e18v10_20p01(Ejercicio, Periodo)
                } }                                                                                                                                                  }, // 14

                {++c,    new RegistroCampo(0,   0,  18,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  $"</T{Modelo}0{Ejercicio}{Periodo}0000>"      )}, // 15
                {++c,    new RegistroCampo(0,   0,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   '\n'                                         )}  // 16
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

            Mod303e18v10_20p01 modPagina1 = Paginas.Empaquetables[0] as Mod303e18v10_20p01;
            Mod303e18v10_20p02 modPagina2 = null;

            if (Paginas.Empaquetables.Count > 1)
                modPagina2 = Paginas.Empaquetables[1] as Mod303e18v10_20p02;

            Mod303e18v10_20p03 modPagina3 = null;

            for (int p = Paginas.Empaquetables.Count - 1; p > -1; p--)
                if (modPagina3 == null)
                    modPagina3 = Paginas.Empaquetables[p] as Mod303e18v10_20p03;

            if (modPagina3 == null)
            {
                modPagina3 = new Mod303e18v10_20p03(Ejercicio, Periodo);
                Paginas.Empaquetables.Add(modPagina3);
            }


            decimal suma = 0;
            string[] clavesASumar = null;

            // Me aseguro de informar los tipos necesarios

            int[] clavesCuota = new int[] { 3, 6, 9, 18, 21 };
            decimal[] tipos = new decimal[] { 4m, 10m, 21m, 5.2m, 1.4m };

            for (int k = 0; k < clavesCuota.Length; k++)
            {

                string claveCuota = $"{clavesCuota[k]}".PadLeft(2, '0');
                string claveTipo = $"{clavesCuota[k] - 1}".PadLeft(2, '0');

                if (Convert.ToDecimal(modPagina1[claveCuota]?.Valor) != 0 &&
                    Convert.ToDecimal(modPagina1[claveTipo]?.Valor) == 0)
                    modPagina1[claveTipo].Valor = tipos[k];

            }

            // Total cuota devengada ( [03] + [06] + [09] + [11] + [13] + [15] + [18] + [21] + [24] + [26])

            clavesASumar = new string[] { "03", "06", "09", "11", "13", "15", "18", "21", "24", "26" };

            foreach (var clave in clavesASumar)
                suma += Convert.ToDecimal(modPagina1[clave]?.Valor);

            if (Convert.ToDecimal(modPagina1["27"]?.Valor) == 0)
                modPagina1["27"].Valor = suma;

            // Total a deducir ( [29] + [31] + [33] + [35] + [37] + [39] + [41] + [42] + [43] + [44] )

            suma = 0;
            clavesASumar = new string[] { "29", "31", "33", "35", "37", "39", "41", "42", "43", "44" };

            foreach (var clave in clavesASumar)
                suma += Convert.ToDecimal(modPagina1[clave]?.Valor);

            if (Convert.ToDecimal(modPagina1["45"]?.Valor) == 0)
                modPagina1["45"].Valor = suma;

            // Resultado régimen general ( [27] - [45] )

            if (Convert.ToDecimal(modPagina1["46"]?.Valor) == 0)
                modPagina1["46"].Valor = Convert.ToDecimal(modPagina1["27"].Valor) - suma;

            // Suma de resultados ( [46] + [58] + [76] )
            if (Convert.ToDecimal(modPagina3["64"]?.Valor) == 0)
                modPagina3["64"].Valor = Convert.ToDecimal(modPagina1["46"].Valor) +
                ((modPagina2 == null) ? 0 : Convert.ToDecimal(modPagina2["58"].Valor)) +
                Convert.ToDecimal(modPagina3["76"].Valor);

            // Atribuible a la Administracion del Estado
            if (Convert.ToDecimal(modPagina3["65"]?.Valor) == 0)
                modPagina3["65"].Valor = 100;

            // Atribuible a la Administración del Estado
            if (Convert.ToDecimal(modPagina3["66"]?.Valor) == 0)
                modPagina3["66"].Valor = Math.Round(Convert.ToDecimal(modPagina3["65"].Valor) / 100 *
                Convert.ToDecimal(modPagina3["64"].Valor), 2);

            // Resultado ( [66] + [77] - [67] + [68] )

            decimal resultado = Convert.ToDecimal(modPagina3["66"].Valor) +
            Convert.ToDecimal(modPagina3["77"].Valor) -
            Convert.ToDecimal(modPagina3["67"].Valor) +
            Convert.ToDecimal(modPagina3["68"].Valor);


            if (Convert.ToDecimal(modPagina3["69"]?.Valor) == 0)
                modPagina3["69"].Valor = resultado;


            if (Convert.ToDecimal(modPagina3["71"]?.Valor) == 0)
                modPagina3["71"].Valor = Convert.ToDecimal(modPagina3["69"].Valor) -
            Convert.ToDecimal(modPagina3["70"].Valor);

            Paginas.Empaquetables.Sort(); // Ordenamos las páginas para evitar problemas indeseados.
        }

        #endregion

    }
}
