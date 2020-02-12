![Irene Solutions SL](http://www.irenesolutions.com/archive/img/logo-irene-solutions-transparent-sm.png)

Bienvenidos a la herramienta AeatModelos!
[By Irene Solutions SL](https://www.irenesolutions.com)

AeatModelos es una herramienta escrita en C# para la generación y carga de los ficheros más habituales en el cumplimiento de las obligaciones fiscales en España. Con ella podremos generar de forma sencilla los ficheros necesarios para presentar las declaraciones del IVA, IRPF, IS, Censales...

También podemos realizar las presentaciones telemáticas mediante el sistema de firma básica establecido por la AEAT.

Si estás interesado en que incluyamos algún modelo adicional o tienes alguna aportación que hacernos, por favor, no dudes en ponerte en contacto con nosotros mediante el mail support@irenesolutions.com

Antes de comenzar a probar con la librería es conveniente revisar la [configuración del sistema](https://github.com/mdiago/AeatModelos/wiki/000-Archivo-de-configuraci%C3%B3n).

Con AeatModelos confeccionar y presentar una autoliquidación de impuestos es algo muy sencillo. Por ejemplo, confeccionar y enviar a los servicios telemáticos de la AEAT una declaración a devolver del modelo 303 del periodo 4T se haría con estos pasos:

# Modelo 303 año 2019 versión 10.10
## Devolución IVA 
### Se genera un fichero para la última autoliquidación del año y se presenta telemáticamente

```C#
var taxFormID = "Mod303e19v10_10";

dynamic modelo = RegistroMod.CrearEmpaquetable(taxFormID,
    "2019", "4T");

dynamic pagina1 = modelo.Paginas.Empaquetables[0];

pagina1["TipoDeclaracion"].Valor = "D"; // A DEVOLVER

// Iva soportado bienes corrientes
pagina1["28"].Valor = 3292.90;   // Base
pagina1["29"].Valor = 691.51;   // Cuota


pagina1["NIF"].Valor = "12334455L";
pagina1["Nombre"].Valor = "FULANO";
pagina1["ApellidosRazonSocial"].Valor = "SOTANEZ MENGANEZ";

var pagina3 = modelo.InsertaPagina(3);

// Cuenta del banco
pagina3["IBAN"].Valor = "ES4500330888310002009999";

// Debemos mostrar esta info al usuario y que confirme
string fichero = modelo.AFichero();
string declarante = modelo.Declarante();
string presentador = modelo.Presentador();

// Tras la confirmación del usuario
modelo.Confirmar();

// Realizamos el envío
Respuesta respuesta = modelo.Presentar();

if (respuesta.Erronea) 
{
    var msg = "";
    foreach (RespuestaError error in respuesta.Errores)
    {
        msg = error.Descripcion;
    }
}
else 
{

    string csv = respuesta.CSV;
    // Guardamos el fichero
    File.WriteAllBytes($"C:\\Users\\usuario\\Downloads\\{csv}.pdf", respuesta.DatosPdf);
}

```

# Contenido

## Ejemplos

[IVA Modelo 303 a pagar con domiciliación](https://github.com/mdiago/AeatModelos/wiki/001-Ejemplo:-IVA-Modelo-303-a%C3%B1o-2019-versi%C3%B3n-10.10-(Declaraci%C3%B3n-domiciliada))

[IVA Modelo 303 a compensar](https://github.com/mdiago/AeatModelos/wiki/002-Ejemplo:-IVA-Modelo-303-a%C3%B1o-2019-versi%C3%B3n-10.10-(Declaraci%C3%B3n-a-compensar))

[IRPF Modelo 111 a pagar con domiciliación](https://github.com/mdiago/AeatModelos/wiki/003-Ejemplo:-IRPF-Modelo-111-a%C3%B1o-2016-versi%C3%B3n-18)

[IRPF Modelo 130 actividad empresarial en estimación directa simplificada ](https://github.com/mdiago/AeatModelos/wiki/004-Ejemplo:-IRPF-Pago-a-cuenta-estimaci%C3%B3n-directa-Modelo-130-a%C3%B1o-2015)

[IRPF Modelo 130 actividades agrícolas, ganaderas, forestales y pesqueras](https://github.com/mdiago/AeatModelos/wiki/005-Ejemplo:-IRPF-Pago-a-cuenta-estimaci%C3%B3n-directa-Modelo-130-a%C3%B1o-2015-(Actividades-agr%C3%ADcolas,-ganaderas,-forestales-y-pesqueras))

[IRPF Modelo 115 a pagar con domiciliación](https://github.com/mdiago/AeatModelos/wiki/006-Ejemplo:-Arrendamientos-inmuebles-urbanos-Modelo-115-a%C3%B1o-2015-versi%C3%B3n-1.3
)

[IRPF Modelo 131 a pagar con aplazamiento](https://github.com/mdiago/AeatModelos/wiki/007-Ejemplo:-Pago-a-cuenta-IRPF-m%C3%B3dulos-Modelo-131-a%C3%B1o-2019-versi%C3%B3n-1.00)

[Cargar fichero declaración](https://github.com/mdiago/AeatModelos/wiki/008-Ejemplo:-Cargar-un-fichero-de-declaraci%C3%B3n)

[IVA Modelo 303 presentación telemática](https://github.com/mdiago/AeatModelos/wiki/009-Ejemplo:-Modelo-303-4T-a-devolver-con-presentaci%C3%B3n-telem%C3%A1tica)

[IVA resumen anual Modelo 390 presentación telemática](https://github.com/mdiago/AeatModelos/wiki/009-Ejemplo:-Modelo-303-4T-a-devolver-con-presentaci%C3%B3n-telem%C3%A1tica)

[Retenciones IRPF resumen anual Modelo 190 presentación telemática](https://github.com/mdiago/AeatModelos/wiki/009-Ejemplo:-Modelo-303-4T-a-devolver-con-presentaci%C3%B3n-telem%C3%A1tica)

[Retenciones capital mobilidadio Modelo 123 presentación telemática](https://github.com/mdiago/AeatModelos/wiki/009-Ejemplo:-Modelo-303-4T-a-devolver-con-presentaci%C3%B3n-telem%C3%A1tica)

