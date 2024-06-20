using Matriculas.Models;

class Program
{
    // Método estático Main: punto de entrada del programa
    static void Main()
    {
        // Crear una instancia de Alumno y mostrar sus detalles
        Alumno alumno1 = new Alumno();
        alumno1.Nombre = "Jose";
        alumno1.Email = "Alvarado";
        alumno1.Mostrar();

        // Crear una instancia de Profesor y mostrar sus detalles
        Profesor profesor1 = new Profesor();
        profesor1.Mostrar();
    }
}
