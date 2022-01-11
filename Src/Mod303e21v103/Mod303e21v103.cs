/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2021 Irene Solutions SL
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

namespace AeatModelos.Mod303e21v103
{
    /// <summary>
    /// Página 0 modelo 303. Diseño de registro: DR303e21v103.xlsx.
    /// </summary>
    public class Mod303e21v103 : Mod303e19v10_10.Mod303e19v10_10
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod303e21v103(string ejercicio, string periodo) : base(ejercicio, periodo)
        {
            PaginasMapa = new Dictionary<int, string>()
            {
                {1, "AeatModelos.Mod303e21v103.Mod303e21v103p01"},
                {2, "AeatModelos.Mod303e21v103.Mod303e21v103p02"},
                {3, "AeatModelos.Mod303e21v103.Mod303e21v103p03"},
                {4, "AeatModelos.Mod303e21v103.Mod303e21v103p04"},
                {5, "AeatModelos.Mod303e21v103.Mod303e21v103p05"}
            };

            RegistroCampos[14] = new ConjuntoDeEmpaquetables()
            {
                Empaquetables = new List<IEmpaquetable>() { new Mod303e21v103p01(Ejercicio, Periodo) }
            };

            Paginas = RegistroCampos[14] as ConjuntoDeEmpaquetables;
        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// 
        /// </summary>
        /// <param name="casillasBase"></param>
        /// <param name="casillaResultado"></param>
        /// <param name="modPagina"></param>
        private void AcumulaCasillas(string[] casillasBase, string casillaResultado, RegistroModPagina modPagina)
        {
            decimal suma = 0;

            foreach (var clave in casillasBase)
                suma += Convert.ToDecimal(modPagina[clave]?.Valor);

            if (Convert.ToDecimal(modPagina[casillaResultado]?.Valor) == 0)
                modPagina[casillaResultado].Valor = suma;
        }

        #endregion

        #region Métodos Públicos de Instancia


        /// <summary>
        /// Devuelve una cadena con la representación del titular del
        /// certificado que va a realizar la presentación.
        /// </summary>
        public override string Declarante()
        {
            string NIF = $"{Paginas.Empaquetables[0]["NIF"].Valor}";
            string apellidosNombreRazonSocial = $"{Paginas.Empaquetables[0]["ApellidosNombreRazonSocial"].Valor}";

            return $"{NIF}, {apellidosNombreRazonSocial}".Trim();
        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
            Mod303e21v103p01 modPagina1 = Paginas.Empaquetables[0] as Mod303e21v103p01;

            // Último perido no válido valor 0 (establecemos por defecto el valor 2, no exonerado de 390)
            if ($"{modPagina1["Periodo"].Valor}" == "4T" || $"{modPagina1["Periodo"].Valor}" == "12")
                if ($"{modPagina1["Exonerado390"].Valor}" == "0")
                    modPagina1["Exonerado390"].Valor = 2; // (1=SI, 2=NO)

            Mod303e21v103p02 modPagina2 = null;

            if (Paginas.Empaquetables.Count > 1)
                modPagina2 = Paginas.Empaquetables[1] as Mod303e21v103p02;

            if (modPagina2 == null)
            {
                modPagina2 = new Mod303e21v103p02(Ejercicio, Periodo);
                Paginas.Empaquetables.Add(modPagina2);
            }

            Mod303e21v103p03 modPagina3 = null;

            for (int p = Paginas.Empaquetables.Count - 1; p > -1; p--)
                if (modPagina3 == null)
                    modPagina3 = Paginas.Empaquetables[p] as Mod303e21v103p03;

            if (modPagina3 == null)
            {
                modPagina3 = new Mod303e21v103p03(Ejercicio, Periodo);
                Paginas.Empaquetables.Add(modPagina3);
            }


            // Me aseguro de informar los tipos necesarios.

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


            string[] clavesASumar = null;

            // Total cuota devengada ( [03] + [06] + [09] + [11] + [13] + [15] + [18] + [21] + [24] + [26] )

            clavesASumar = new string[] { "03", "06", "09", "11", "13", "15", "18", "21", "24", "26" };

            AcumulaCasillas(clavesASumar, "27", modPagina1);


            // Total a deducir ( [29] + [31] + [33] + [35] + [37] + [39] + [41] + [42] + [43] + [44] )

            clavesASumar = new string[] { "29", "31", "33", "35", "37", "39", "41", "42", "43", "44" };

            AcumulaCasillas(clavesASumar, "45", modPagina1);


            // Resultado régimen general ( [27] - [45] )
            if (Convert.ToDecimal(modPagina1["46"]?.Valor) == 0)
                modPagina1["46"].Valor = Convert.ToDecimal(modPagina1["27"].Valor) - Convert.ToDecimal(modPagina1["45"].Valor);


            // Suma de resultados ( [46] + [58] + [76] )
            if (Convert.ToDecimal(modPagina3["64"]?.Valor) == 0)
                modPagina3["64"].Valor = Convert.ToDecimal(modPagina1["46"].Valor) + ((modPagina2 == null) ? 0 : Convert.ToDecimal(modPagina2["58"].Valor)) +
                Convert.ToDecimal(modPagina3["76"].Valor);

            // Atribuible a la Administracion del Estado
            if (Convert.ToDecimal(modPagina3["65"]?.Valor) == 0)
                modPagina3["65"].Valor = 100;

            // Atribuible a la Administración del Estado
            if (Convert.ToDecimal(modPagina3["66"]?.Valor) == 0)
                modPagina3["66"].Valor = Math.Round(Convert.ToDecimal(modPagina3["65"].Valor) / 100 *
                Convert.ToDecimal(modPagina3["64"].Valor), 2);

            // Comprobamos si existen cuotas a compensar de periodos anteriores.
            decimal cuotasACompensar = Convert.ToDecimal(modPagina3["110"].Valor);

            if (cuotasACompensar > 0) // Existen cuotas a compensar de periodos anteriores, por lo que calculamos que importe se aplicará en este periodo.
            {
                decimal resultadoPeriodo = Convert.ToDecimal(modPagina3["66"].Valor) + Convert.ToDecimal(modPagina3["77"].Valor) + Convert.ToDecimal(modPagina3["68"].Valor);

                if (Convert.ToDecimal(modPagina3["78"]?.Valor) == 0)
                {
                    if(resultadoPeriodo <= 0)
                        modPagina3["78"].Valor = 0;
                    else if (resultadoPeriodo >= cuotasACompensar)
                        modPagina3["78"].Valor = cuotasACompensar;
                    else
                        modPagina3["78"].Valor = resultadoPeriodo;
                }                    
            }

            // Cuotas a compensar de periodos previos pendientes para periodos posteriores ([110] - [78]) [87]
            if (Convert.ToDecimal(modPagina3["87"]?.Valor) == 0)
                modPagina3["87"].Valor = Convert.ToDecimal(modPagina3["110"].Valor) - Convert.ToDecimal(modPagina3["78"].Valor);

            // Resultado ( [66] + [77] - [78] + [68] )
            decimal resultado = Convert.ToDecimal(modPagina3["66"].Valor) +
            Convert.ToDecimal(modPagina3["77"].Valor) -
            Convert.ToDecimal(modPagina3["78"].Valor) +
            Convert.ToDecimal(modPagina3["68"].Valor);

            if (Convert.ToDecimal(modPagina3["69"]?.Valor) == 0)
                modPagina3["69"].Valor = resultado;

            // Resultado de la liquidación ( [69] - [70] ) [71]
            if (Convert.ToDecimal(modPagina3["71"]?.Valor) == 0)
                modPagina3["71"].Valor = Convert.ToDecimal(modPagina3["69"].Valor) - Convert.ToDecimal(modPagina3["70"].Valor);

            Paginas.Empaquetables.Sort(); // Ordenamos las páginas para evitar problemas indeseados.
        }

        #endregion

    }
}
