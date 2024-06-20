using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Models
{
    abstract class Persona
    {
        // Propiedades de la clase Persona
        public string Nombre { get; set; }
        public string Email { get; set; }

        // Constructor de la clase Persona
        public Persona(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }

        // Método abstracto para mostrar los detalles de la persona
        public abstract void Mostrar();
    }
}
