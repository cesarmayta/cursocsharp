using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Models
{
    internal class Persona
    {
        // Propiedades de la clase Persona
        public string Nombre { get; set; }
        public string Email { get; set; }

        // Constructor de la clase Persona
        public Persona()
        {
        }

        // Método para mostrar los detalles de la persona
        public void Mostrar()
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("NOMBRE : " + Nombre);
            Console.WriteLine("EMAIL : " + Email);
        }
    }
}
