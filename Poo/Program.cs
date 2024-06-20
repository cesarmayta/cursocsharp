using System;

class Persona
{
    public string Nombre { get; set; }
    public string Email { get; set; }

    public Persona(string nombre, string email)
    {
        Nombre = nombre;
        Email = email;
    }

    public void Mostrar()
    {
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("NOMBRE : " + Nombre);
        Console.WriteLine("EMAIL : " + Email);
    }
}

class Alumno : Persona
{
    public int Nota { get; set; }

    public Alumno(string nombre, string email, int nota) : base(nombre, email)
    {
        Nota = nota;
    }
}

class Profesor : Persona
{
    public string Especialidad { get; set; }

    public Profesor(string nombre, string email, string especialidad) : base(nombre, email)
    {
        Especialidad = especialidad;
    }
}

class Program
{
    static void Main()
    {
        Alumno alumno1 = new Alumno("CESAR", "cesar@gmail.com", 20);
        alumno1.Mostrar();

        Profesor profesor1 = new Profesor("GUILLERMO", "guille@gmail.com", "REACT");
        profesor1.Mostrar();
    }
}

