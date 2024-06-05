//listas
List<string> dias = new List<string> { "lunes", "martes", "miércoles" };
Console.WriteLine(dias);
Console.WriteLine(string.Join(", ", dias));

// Imprimir el último elemento
Console.WriteLine(dias[^1]);

// Agregar valor a una lista
dias.Add("jueves");
dias.Add("viernes");
Console.WriteLine(string.Join(", ", dias));

// Eliminar valor de una lista
dias.RemoveAt(3);
Console.WriteLine(string.Join(", ", dias));

// Eliminar un rango de valores de la lista
dias.RemoveRange(2, 2);
Console.WriteLine(string.Join(", ", dias));

// Actualizar valor de una lista
dias[0] = "domingo";
dias[1] = "lunes";
Console.WriteLine(string.Join(", ", dias));

dias.AddRange(new List<string> { "martes", "miércoles", "jueves", "viernes" });
Console.WriteLine(string.Join(", ", dias));

// Recorrer una lista
for (int contador = 0; contador < dias.Count; contador++)
{
    Console.WriteLine(dias[contador]);
}

foreach (string dia in dias)
{
    Console.WriteLine(dia);
}