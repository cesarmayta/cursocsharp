// See https://aka.ms/new-console-template for more information
Console.WriteLine("DICCIONARIOS");
Dictionary<string, string> capitales = new Dictionary<string, string>
        {
            { "Perú", "Lima" },
            { "Ecuador", "Quito" },
            { "Chile", "Santiago" },
            { "Colombia", "Bogotá" }
        };

Console.Write("Ingrese el país: ");
string pais = Console.ReadLine();

if (capitales.ContainsKey(pais))
{
    string capital = capitales[pais];
    Console.WriteLine($"La capital de {pais} es {capital}");

    Console.Write("¿Desea eliminar la capital? (si, no): ");
    string? eliminar_capital = Console.ReadLine();

    if (eliminar_capital.ToLower() == "si")
    {
        capitales.Remove(pais);
        Console.WriteLine("Capital eliminada.");
        foreach (var item in capitales)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
else
{
    Console.WriteLine($"No se encontró la capital de {pais}");
    Console.Write($"Ingrese la capital de {pais}: ");
    string nueva_capital = Console.ReadLine();
    capitales[pais] = nueva_capital;
    Console.WriteLine("Nueva capital añadida.");
    foreach (var item in capitales)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}
