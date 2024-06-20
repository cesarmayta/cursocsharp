using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Models
{
    internal class Profesor : Persona
    {
        public string Especialidad { get; set; }

        // Constructor de la clase Profesor
        public Profesor(string nombre, string email, string especialidad) : base(nombre, email)
        {
            Especialidad = especialidad;
        }

        // Implementación del método abstracto Mostrar
        public override void Mostrar()
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("NOMBRE : " + Nombre);
            Console.WriteLine("EMAIL : " + Email);
            Console.WriteLine("ESPECIALIDAD : " + Especialidad);
        }
    }
}
