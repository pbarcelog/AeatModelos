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

using AeatModelos.Configuracion;
using System;
using System.Collections.Generic;

namespace AeatModelos.Comunicaciones
{

    /// <summary>
    /// Enlaces con los servicios de la agencia tributaria.
    /// </summary>
    public class Enlaces
    {

        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasica = "https://www1.agenciatributaria.gob.es/wlpl/PFTW-PICW/PresBasica";

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones versión 2022 del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasicaDos = "https://www1.agenciatributaria.gob.es/wlpl/PFTW-PICW/PresBasicaDos";

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones mediante TGVI.
        /// </summary>
        public static string PftwPicwPresBasicaTgvi = "https://www1.agenciatributaria.gob.es/wlpl/OVPT-NTGV/";

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasicaPruebas = "https://www7.aeat.es/wlpl/PFTW-PICW/PresBasica";

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones del modelo 130,
        /// 303...
        /// </summary>
        public static string PftwPicwPresBasicaDosPruebas = "https://prewww1.aeat.es/wlpl/PFTW-PICW/PresBasicaDos";

        /// <summary>
        /// Enlace al servicios de presentación de declaraciones mediante TGVI.
        /// </summary>
        public static string PftwPicwPresBasicaPruebasTgvi = "https://www7.aeat.es/wlpl/OVPT-NTGV/";

        #endregion

    }
}
