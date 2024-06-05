int opcion = 0;
double valorCompra = 3.839;
double valorVenta = 3.849;

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