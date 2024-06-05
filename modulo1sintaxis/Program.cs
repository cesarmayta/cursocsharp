//variables

//String nombre = "Cesar";
//var nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu nombre : ");
string nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);
//tipos de datos
//STRING
//int letras = nombre.Length;
int letras = nombre.Trim().Replace(" ", "").Length;
Console.WriteLine($"Tu nombre {nombre} tiene {letras} caracteres");

// enteros
short? edad = 30;
Int16 altura = 178;
float alturaEnMetros = 1.78f;



Console.WriteLine($"Mi edad es: {edad}");

Console.WriteLine($"Mi altura es: {altura} cms");

Console.WriteLine($"Mi altura en metros es: {alturaEnMetros}");


//fecha
DateTime fechaNacimiento = new DateTime(1990, 4, 1);
var fechaActual = DateTime.Now;

Console.WriteLine($"Mi fecha de nacimiento es: {fechaNacimiento.Date.ToString("MM/dd/yy")}");

Console.WriteLine($"La fecha actual es {fechaActual.Date.ToString("MM/dd/yy")}");

var diferenciaDeFechas = fechaActual - fechaNacimiento;

Console.WriteLine($"Mi edad de acuerdo a mi fecha de nacimiento es {diferenciaDeFechas.Days / 365}");


DateTime? fechaTerminacionCurso = null;

Console.WriteLine($"Fechas terminación curso: {fechaTerminacionCurso?.Date} ");

bool? tieneMascota = null;

Console.WriteLine($"Tengo mascota?: {tieneMascota}");


/*
//suma de 2 números
Console.WriteLine("Ingrese el primer número : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número : ");
int b = Convert.ToInt32(Console.ReadLine());
int resultado = a + b;
Console.WriteLine("La suma de {0} y {1} es {2}", a, b, resultado);
using System.Diagnostics;

Console.WriteLine("MIS PROGRAMAS");
Console.WriteLine("Ingrese programa (1 suma/Resta  | 2 tabla multiplicar | 3 contador)");
int opcion = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(3000);
switch (opcion)
{
    case 1:
        Console.WriteLine("Ingrese el primer número : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingres el segundo número : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el tipo de operación(suma,resta)");
        String? operador = Console.ReadLine();
        if (operador == "suma")
        {
            int resultado = a + b;
            Console.WriteLine("La suma de {0} y {1} es {2}", a, b, resultado);
        }
        else if (operador == "resta")
        {
            int resta = a - b;
            Console.WriteLine("La resta de {0} y {1} es {2}", a, b, resta);
        }
        else
        {
            Console.WriteLine("No existe la operación solicitada");
        }
        break;
    case 2:
        Console.WriteLine("Ingrese la tabla a multiplicar : ");
        int tabla = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine("{0} x {1} es {2}", tabla, i, tabla * i);
        }
        break;
    case 3:
        int n = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (n <= 1000)
        {
            Console.Write(n);
            n++;
        }
        stopwatch.Stop();
        TimeSpan tiempoTranscurrido = stopwatch.Elapsed;
        Console.WriteLine("tiempo de ejecución {0}", tiempoTranscurrido.TotalMilliseconds);
        break;
}
*/