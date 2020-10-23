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
    
    Puede evitar el cumplimiento de lo establecido de lo establecido 
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

namespace AeatModelos.Mod390e2019v100
{

    /// <summary>
    /// Página 0 modelo 390. Diseño de registro: dr390e2019v100.xlsx.
    /// </summary>
    public class Mod390e2019v100 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2019</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100(string ejercicio, string periodo = "0A") : base(ejercicio, periodo)
        {

            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod390e2019v100.Mod390e2019v100p01"},
                {2, "AeatModelos.Mod390e2019v100.Mod390e2019v100p02"},
                {3, "AeatModelos.Mod390e2019v100.Mod390e2019v100p03"},
                {4, "AeatModelos.Mod390e2019v100.Mod390e2019v100p04"},
                {5, "AeatModelos.Mod390e2019v100.Mod390e2019v100p05"},
                {6, "AeatModelos.Mod390e2019v100.Mod390e2019v100p06"},
                {7, "AeatModelos.Mod390e2019v100.Mod390e2019v100p07"},
                {8, "AeatModelos.Mod390e2019v100.Mod390e2019v100p08"}
            };

            string p = "000";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   1,   2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<T"                              )}, //001
                {++c,    new RegistroCampo(0,   3,   3,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "390"                             )}, //002
                {++c,    new RegistroCampo(0,   6,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0"                               )}, //003
                {++c,    new RegistroCampo(0,   7,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Ejercicio                        )}, //004
                {++c,    new RegistroCampo(0,  11,   2,  "An ",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   Periodo                          )}, //005
                {++c,    new RegistroCampo(0,  13,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "0000>"                           )}, //006
                {++c,    new RegistroCampo(0,  18,   5,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "<AUX>"                           )}, //007
                {++c,    new RegistroCampo(0,  23,  70,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 70)               )}, //008
                {++c,    new RegistroCampo(0,  93,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  AeatModelosContexto.VersionDelPrograma  )}, //009
                {++c,    new RegistroCampo(0,  97,   4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 4)                )}, //010
                {++c,    new RegistroCampo(0, 101,   9,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  AeatModelosContexto.NIFEmpresaDesarrollo)}, //011
                {++c,    new RegistroCampo(0, 110, 213,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  new string(' ', 213)              )}, //012
                {++c,    new RegistroCampo(0, 323,   6,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  "</AUX>"                          )}, //013
                
                // En principio sólo se incluye la página 1.
                {++c,    new ConjuntoDeEmpaquetables(){ Empaquetables = new List<IEmpaquetable>(){
                            new Mod390e2019v100p01(Ejercicio, Periodo)
                } } },

                {++c,    new RegistroCampo(0,   0,  18,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,  $"</T3900{Ejercicio}{Periodo}0000>")}, //014
                {++c,    new RegistroCampo(0,   0,   1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,   '\n'                    )}, //015
            };

            Paginas = RegistroCampos[14] as ConjuntoDeEmpaquetables;

            // Cambia el orden de las variables en la presentación telemática.
            OrdenVariablesEnvio = new string[5] { "FIRNIF", "FIRNOMBRE", "IDI", "F01", "FIR" };

        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {

            Mod390e2019v100p01 modPagina1 = Paginas.Empaquetables[0] as Mod390e2019v100p01;
            Mod390e2019v100p02 modPagina2 = null;

            Paginas.Empaquetables.Sort(); // Ordenamos las páginas para evitar problemas indeseados.

            if (Paginas.Empaquetables.Count > 1)
                modPagina2 = Paginas.Empaquetables[1] as Mod390e2019v100p02;

            if (modPagina2 == null)
            {
                modPagina2 = new Mod390e2019v100p02(Ejercicio, Periodo);
                Paginas.Empaquetables.Add(modPagina2);
            }

            // Suma bases devengado

            decimal sumaBasesDevengado = 0;
            string[] basesDevengadoASumar = new string[]
            {
                "01", "03", "05", "500", "502", "504", "643", "645", "647", "07", "09", "11",
                "13", "21", "23", "25", "545", "547", "551", "27", "29", "649", "31"
            };

            foreach (var clave in basesDevengadoASumar)
            {
                sumaBasesDevengado += Convert.ToDecimal(modPagina2[clave]?.Valor);
            }

            if (Convert.ToDecimal(modPagina2["33"]?.Valor) == 0)
                modPagina2["33"].Valor = sumaBasesDevengado;


            // Suma cuotas devengado

            decimal sumaCuotasDevengado = 0;
            string[] cuotasDevengadoASumar = new string[]
            {
                "02", "04", "06", "501", "503", "505", "644", "646", "648", "08", "10", "12",
                "14", "22", "24", "26", "546", "548", "552", "28", "30", "650", "32"
            };

            foreach (var clave in cuotasDevengadoASumar)
            {
                sumaCuotasDevengado += Convert.ToDecimal(modPagina2[clave]?.Valor);
            }

            if (Convert.ToDecimal(modPagina2["34"]?.Valor) == 0)
                modPagina2["34"].Valor = sumaCuotasDevengado;


            // Total cuotas IVA y recargo de equivalencia ( [34] + [36] + [600] + [602] + [42] + [44] + [46] )

            decimal sumaTotalesDevengado = 0;
            string[] totalesDevengadoASumar = new string[]
            {
                "34", "36", "600", "602", "42", "44", "46"
            };

            foreach (var clave in totalesDevengadoASumar)
            {
                sumaTotalesDevengado += Convert.ToDecimal(modPagina2[clave]?.Valor);
            }

            if (Convert.ToDecimal(modPagina2["47"]?.Valor) == 0)
                modPagina2["47"].Valor = sumaTotalesDevengado;


            Mod390e2019v100p03 modPagina3 = null;
            Mod390e2019v100p04 modPagina4 = null;

            for (int p = Paginas.Empaquetables.Count - 1; p > -1; p--)
            {
                if (modPagina3 == null)
                    modPagina3 = Paginas.Empaquetables[p] as Mod390e2019v100p03;

                if (modPagina4 == null)
                    modPagina4 = Paginas.Empaquetables[p] as Mod390e2019v100p04;
            }


            if (modPagina3 == null)
            {
                modPagina3 = new Mod390e2019v100p03(Ejercicio, Periodo);
                Paginas.Empaquetables.Add(modPagina3);
            }

            if (modPagina4 == null)
            {
                modPagina4 = new Mod390e2019v100p04(Ejercicio, Periodo);
                Paginas.Empaquetables.Add(modPagina4);
            }


            // Total bases imponibles y cuotas deducibles en operaciones interiores de bienes y servicios corrientes

            decimal sumaOperacionesBienesCorrientesBases = 0;
            string[] basesOperacionesBienesCorrientesASumar = new string[]
            {
                "190", "603", "605"
            };

            foreach (var clave in basesOperacionesBienesCorrientesASumar)
            {
                sumaOperacionesBienesCorrientesBases += Convert.ToDecimal(modPagina3[clave]?.Valor);
            }

            modPagina3["48"].Valor = sumaOperacionesBienesCorrientesBases;

            decimal sumaOperacionesBienesCorrientesCuotas = 0;
            string[] cuotasOperacionesBienesCorrientesASumar = new string[]
            {
                "191", "604", "606"
            };

            foreach (var clave in cuotasOperacionesBienesCorrientesASumar)
            {
                sumaOperacionesBienesCorrientesCuotas += Convert.ToDecimal(modPagina3[clave]?.Valor);
            }

            if (Convert.ToDecimal(modPagina3["49"]?.Valor) == 0)
                modPagina3["49"].Valor = sumaOperacionesBienesCorrientesCuotas;


            // Total bases imponibles y cuotas deducibles en operaciones interiores de bienes de inversión

            decimal sumaOperacionesBienesInversionBases = 0;
            string[] basesOperacionesBienesInversionASumar = new string[]
            {
                "196", "611", "613"
            };

            foreach (var clave in basesOperacionesBienesInversionASumar)
            {
                sumaOperacionesBienesInversionBases += Convert.ToDecimal(modPagina3[clave]?.Valor);
            }

            modPagina3["50"].Valor = sumaOperacionesBienesInversionBases;

            decimal sumaOperacionesBienesInversionCuotas = 0;
            string[] cuotasOperacionesBienesInversionASumar = new string[]
            {
                "197", "612", "614"
            };

            foreach (var clave in cuotasOperacionesBienesInversionASumar)
            {
                sumaOperacionesBienesInversionCuotas += Convert.ToDecimal(modPagina3[clave]?.Valor);
            }

            if (Convert.ToDecimal(modPagina3["51"]?.Valor) == 0)
                modPagina3["51"].Valor = sumaOperacionesBienesInversionCuotas;


            // Suma de deducciones ( [49] + [513] + [51] + [521] + [53] + [55] + [57] + [59] + [598] + [61] + [661] + [62] + [652] + [63] + [522] )

            decimal sumaDeducciones = 0;
            string[] deduccionesASumar = new string[]
            {
                "49", "513", "51", "521", "53", "55", "57", "59", "598", "61", "661", "62",
                "652", "63", "522"
            };

            foreach (var clave in deduccionesASumar)
            {
                if (modPagina2[clave] != null)
                    sumaDeducciones += Convert.ToDecimal(modPagina2[clave]?.Valor);

                else if (modPagina3[clave] != null)
                    sumaDeducciones += Convert.ToDecimal(modPagina3[clave]?.Valor);

                else if (modPagina4[clave] != null)
                    sumaDeducciones += Convert.ToDecimal(modPagina4[clave]?.Valor);
            }

            if (Convert.ToDecimal(modPagina4["64"]?.Valor) == 0)
                modPagina4["64"].Valor = sumaDeducciones;


            //Resultado régimen general ( [47] - [64] )

            if (Convert.ToDecimal(modPagina2["47"].Valor) != 0)
                modPagina4["65"].Valor = Convert.ToDecimal(modPagina2["47"]?.Valor) - Convert.ToDecimal(modPagina4["64"]?.Valor);



            Mod390e2019v100p06 modPagina6 = null;

            for (int p = Paginas.Empaquetables.Count - 1; p > -1; p--)
            {
                if (modPagina6 == null)
                    modPagina6 = Paginas.Empaquetables[p] as Mod390e2019v100p06;
            }


            if (modPagina6 == null)
            {
                modPagina6 = new Mod390e2019v100p06(Ejercicio, Periodo);
                Paginas.Empaquetables.Add(modPagina6);
            }

            // Suma de resultados ( [65] + [83] + [658] )

            var n65 = Convert.ToDecimal(modPagina4["65"]?.Valor);

            var n83 = Convert.ToDecimal(0);

            Mod390e2019v100p05 modPagina5 = null;

            for (int p = Paginas.Empaquetables.Count - 1; p > -1; p--)
                if (modPagina5 == null)
                    modPagina5 = Paginas.Empaquetables[p] as Mod390e2019v100p05;

            if (modPagina5 != null)
                n83 = Convert.ToDecimal(modPagina5["83"]?.Valor);

            var n658 = Convert.ToDecimal(modPagina6["7.658"]?.Valor);

            if (Convert.ToDecimal(modPagina6["7.84"]?.Valor) == 0)
                modPagina6["7.84"].Valor = n65 + n83 + n658;

            // Resultado de la liquidación ( [84] + [659] - [85] )

            var n84 = Convert.ToDecimal(modPagina6["7.84"]?.Valor);
            var n659 = Convert.ToDecimal(modPagina6["7.659"]?.Valor);
            var n85 = Convert.ToDecimal(modPagina6["85"]?.Valor);

            if (Convert.ToDecimal(modPagina6["86"]?.Valor) == 0)
                modPagina6["86"].Valor = n84 + n659 - n85;

            // Total volumen de operaciones (Art. 121 Ley IVA) (99 + 653 + 103 + 104 + 105 + 110 + 112 + 100 + 101 + 102 +
            // 227 + 228 - 106 - 107) 

            decimal sumaVolumenOperaciones = 0;
            string[] volumenOperacionesASumar = new string[]
            {
                "99", "653", "103", "104", "105", "110", "112", "100", "101", "102", "227", "228"
            };
            string[] volumenOperacionesARestar = new string[]
            {
                "106", "107"
            };

            foreach (var clave in volumenOperacionesASumar)
            {
                sumaVolumenOperaciones += Convert.ToDecimal(modPagina6[clave]?.Valor);
            }

            foreach (var clave in volumenOperacionesARestar)
            {
                sumaVolumenOperaciones -= Convert.ToDecimal(modPagina6[clave]?.Valor);
            }

            if (Convert.ToDecimal(modPagina6["108"]?.Valor) == 0)
                modPagina6["108"].Valor = sumaVolumenOperaciones;

            Paginas.Empaquetables.Sort();
        }

        #endregion

    }
}
