using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

int opcion = 0;
double valorCompra = 3.839;
double valorVenta = 3.849;

static async Task ObtenerTipoCambio()
{
    var url = "https://www.sbs.gob.pe/app/pp/sistip_portal/paginas/publicacion/tipocambiopromedio.aspx";

    try
    {
        // Inicializar HttpClient
        using HttpClient client = new HttpClient();
        var response = await client.GetStringAsync(url);

        if (response != null)
        {
            // Cargar el contenido HTML usando HtmlAgilityPack
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(response);

            // Encontrar la tabla con el id específico
            var table = htmlDocument.DocumentNode.SelectSingleNode("//table[@id='ctl00_cphContent_rgTipoCambio_ctl00']");

            if (table != null)
            {
                // Encontrar la primera fila con el id específico
                var row = table.SelectSingleNode(".//tr[@id='ctl00_cphContent_rgTipoCambio_ctl00__0']");

                if (row != null)
                {
                    // Extraer la moneda
                    var monedaNode = row.SelectSingleNode(".//td[@class='APLI_fila3']");
                    // Extraer los tipos de cambio
                    var tipoCambioNodes = row.SelectNodes(".//td[@class='APLI_fila2']");

                    if (monedaNode != null && tipoCambioNodes != null && tipoCambioNodes.Count >= 2)
                    {
                        var moneda = monedaNode.InnerText.Trim();
                        var compra = tipoCambioNodes[0].InnerText.Trim();
                        var venta = tipoCambioNodes[1].InnerText.Trim();

                        Console.WriteLine($"Moneda : {moneda}");
                        Console.WriteLine($"Compra : {compra}");
                        Console.WriteLine($"Venta : {venta}");
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron los datos necesarios en la fila especificada.");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró la fila especificada en la tabla.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró la tabla especificada en la página.");
            }
        }
        else
        {
            Console.WriteLine("No se pudo obtener el contenido de la página.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrió un error: {ex.Message}");
    }
}

while (opcion != 3)
{
    Console.Clear();
    Console.WriteLine(new string('=', 60));
    Console.WriteLine(new string(' ', 10) + "CONVERTIDOR DE MONEDAS VERSION 1.0");
    Console.WriteLine(new string('=', 60));
    Console.WriteLine(@"
          OPCIÓN 1 : Convertir de soles a dolares
          OPCIÓN 2 : Convertir de dolares a soles
          OPCIÓN 3 : Salir del programa
          ");
    Console.WriteLine(new string('=', 60));
    Console.Write("Ingrese una opción del menú: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.Clear();
        Console.WriteLine(new string('=', 60));
        Console.WriteLine("CONVERTIR DE SOLES A DOLARES");
        Console.WriteLine(new string('=', 60));
        Console.Write("Ingrese monto en soles: ");
        double montoOrigen = double.Parse(Console.ReadLine());
        double montoDestino = montoOrigen / valorVenta;
        string monedaDestino = "dolares";
        Console.WriteLine($"El monto en {monedaDestino} es {Math.Round(montoDestino, 2)}");
    }
    else if (opcion == 2)
    {
        Console.Clear();
        Console.WriteLine(new string('=', 60));
        Console.WriteLine("CONVERTIR DE DOLARES A SOLES");
        Console.WriteLine(new string('=', 60));
        Console.Write("Ingrese monto en dolares: ");
        double montoOrigen = double.Parse(Console.ReadLine());
        double montoDestino = montoOrigen * valorCompra;
        string monedaDestino = "soles";
        Console.WriteLine($"El monto en {monedaDestino} es {Math.Round(montoDestino, 2)}");
    }
    else if (opcion == 3)
    {
        Console.WriteLine("ADIOS !!!");
    }
    else if (opcion == 4)
    {
        await ObtenerTipoCambio();
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Debe ingresar una opción válida ...");
    }

    if (opcion == 1 || opcion == 2)
    {
        Console.WriteLine("PRESIONE ENTER PARA CONTINUAR..");
        Console.ReadLine();
    }
}