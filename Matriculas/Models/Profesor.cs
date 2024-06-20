using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Models
{
    internal class Profesor : Persona
    {
        // Propiedad adicional para la clase Profesor
        public string Especialidad { get; set; }

        // Constructor de la clase Profesor
        //public Profesor(string nombre, string email, string especialidad) : base(nombre, email)
        //{
        //    Especialidad = especialidad;
        //}
    }
}
