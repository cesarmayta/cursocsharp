List<Dictionary<string, string>> listaAlumnos = new List<Dictionary<string, string>>();
int opcion = 0;
const int ANCHO = 50;

while (opcion < 5)
{
    Console.Clear();
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(new string(' ', 10) + "PROGRAMA DE MATRICULA DE ALUMNOS");
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(@"
                [1] REGISTRAR ALUMNO
                [2] MOSTRAR ALUMNOS
                [3] ACTUALIZAR ALUMNO
                [4] ELIMINAR ALUMNO
                [5] SALIR
            ");
    Console.WriteLine(new string('=', ANCHO));
    Console.Write("INGRESE UNA OPCIÓN DEL MENU: ");
    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
            Console.WriteLine(new string('=', ANCHO));
            Console.WriteLine(new string(' ', 10) + "[1] REGISTRAR ALUMNO");
            Console.WriteLine(new string('=', ANCHO));
            Console.Write("NOMBRE: ");
            string nombre = Console.ReadLine();
            Console.Write("EMAIL: ");
            string email = Console.ReadLine();
            Console.Write("CELULAR: ");
            string celular = Console.ReadLine();
            Dictionary<string, string> nuevoAlumno = new Dictionary<string, string>
                    {
                        { "nombre", nombre },
                        { "email", email },
                        { "celular", celular }
                    };
            listaAlumnos.Add(nuevoAlumno);
            Console.WriteLine(new string('=', ANCHO));
            Console.WriteLine(new string(' ', 10) + "ALUMNO REGISTRADO CON EXITO");
            Console.WriteLine(new string('=', ANCHO));
            System.Threading.Thread.Sleep(1000);
            break;

        case 2:
            Console.WriteLine(new string('=', ANCHO));
            Console.WriteLine(new string(' ', 10) + "[2] MOSTRAR ALUMNOS");
            Console.WriteLine(new string('=', ANCHO));
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine(new string('*', ANCHO));
                foreach (var kvp in alumno)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            Console.WriteLine(new string('*', ANCHO));
            Console.Write("Presione ENTER para continuar...");
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine(new string('=', ANCHO));
            Console.WriteLine(new string(' ', 10) + "[3] ACTUALIZAR ALUMNO");
            Console.WriteLine(new string('=', ANCHO));
            Console.Write("INGRESE EL EMAIL DEL ALUMNO A ACTUALIZAR: ");
            string emailBusqueda = Console.ReadLine();
            int posicionActualizar = listaAlumnos.FindIndex(a => a["email"] == emailBusqueda);

            if (posicionActualizar == -1)
            {
                Console.WriteLine("NO SE ENCONTRO EL ALUMNO SOLICITADO");
            }
            else
            {
                Console.WriteLine($"ALUMNO A ACTUALIZAR: {listaAlumnos[posicionActualizar]["nombre"]}");
                Console.WriteLine("INGRESE NUEVOS DATOS PARA EL ALUMNO:");
                Console.WriteLine("NOTA: SI PRESIONA ENTER NO SE ACTUALIZARA EL VALOR");

                Console.Write($"NOMBRE ({listaAlumnos[posicionActualizar]["nombre"]}): ");
                nombre = Console.ReadLine();
                if (string.IsNullOrEmpty(nombre)) nombre = listaAlumnos[posicionActualizar]["nombre"];

                Console.Write($"EMAIL ({listaAlumnos[posicionActualizar]["email"]}): ");
                email = Console.ReadLine();
                if (string.IsNullOrEmpty(email)) email = listaAlumnos[posicionActualizar]["email"];

                Console.Write($"CELULAR ({listaAlumnos[posicionActualizar]["celular"]}): ");
                celular = Console.ReadLine();
                if (string.IsNullOrEmpty(celular)) celular = listaAlumnos[posicionActualizar]["celular"];

                listaAlumnos[posicionActualizar] = new Dictionary<string, string>
                        {
                            { "nombre", nombre },
                            { "email", email },
                            { "celular", celular }
                        };

                Console.WriteLine(new string('=', ANCHO));
                Console.WriteLine(new string(' ', 10) + "ALUMNO ACTUALIZADO CON EXITO!!!");
                Console.WriteLine(new string('=', ANCHO));
            }
            System.Threading.Thread.Sleep(1000);
            break;

        case 4:
            Console.WriteLine(new string('=', ANCHO));
            Console.WriteLine(new string(' ', 10) + "[4] ELIMINAR ALUMNO");
            Console.WriteLine(new string('=', ANCHO));
            Console.Write("INGRESE EL EMAIL DEL ALUMNO A ELIMINAR: ");
            emailBusqueda = Console.ReadLine();
            int posicionEliminar = listaAlumnos.FindIndex(a => a["email"] == emailBusqueda);

            if (posicionEliminar == -1)
            {
                Console.WriteLine("NO SE ENCONTRO EL ALUMNO SOLICITADO");
            }
            else
            {
                listaAlumnos.RemoveAt(posicionEliminar);
                Console.WriteLine("ALUMNO ELIMINADO!!!");
            }
            System.Threading.Thread.Sleep(1000);
            break;

        case 5:
            Console.WriteLine(new string('=', ANCHO));
            Console.WriteLine(new string(' ', 10) + "SALIENDO DEL SISTEMA....");
            Console.WriteLine(new string('=', ANCHO));
            break;

        default:
            Console.WriteLine(new string('=', ANCHO));
            Console.WriteLine(new string(' ', 10) + "OPCIÓN INVALIDA!!!!");
            Console.WriteLine(new string('=', ANCHO));
            System.Threading.Thread.Sleep(1000);
            break;
    }
}
