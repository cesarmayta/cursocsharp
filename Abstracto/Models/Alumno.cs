﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Models
{
    internal class Alumno : Persona
    {
        // Propiedad adicional para la clase Alumno
        public int Nota { get; set; }

        // Constructor de la clase Alumno
        public Alumno(string nombre, string email, int nota) : base(nombre, email)
        {
            Nota = nota;
        }

        // Implementación del método abstracto Mostrar
        public override void Mostrar()
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("NOMBRE : " + Nombre);
            Console.WriteLine("EMAIL : " + Email);
            Console.WriteLine("NOTA : " + Nota);
        }
    }
}
