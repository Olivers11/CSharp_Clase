
//clases

using ClaseEjemplo;

int tamanio = 0;
Alumno[] alumnos;
int opcion;

Console.Write("Cuantos alumnos desea ingresar?: ");
tamanio = Convert.ToInt32(Console.ReadLine());
alumnos = new Alumno[tamanio];

int posicion = 0;

do
{
    Console.Clear();
    Console.WriteLine("1- Ingresar alumno");
    Console.WriteLine("2- Ver Alumnos");
    Console.WriteLine("3- Salir");
    opcion = Convert.ToInt32(Console.ReadLine());

    if (opcion == 1)
    {
        Console.Clear();
        if (posicion == tamanio)
        {
            Console.WriteLine("lista llena");
            Console.ReadKey();
        }
        else
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Carnet: ");
            string carnet = Console.ReadLine();

            Console.Write("Semestre: ");
            int semestre = Convert.ToInt32(Console.ReadLine());

            alumnos[posicion] = new Alumno(nombre, carnet, semestre);
            posicion++;
            Console.WriteLine("Alumno ingresado correctamente :D");
            Console.ReadKey(true);
        }
    }
    else if (opcion == 2)
    {
        Console.Clear();
        Console.WriteLine("==== LISTADO ===");
        for (int i = 0; i < posicion; i++)
        {
            alumnos[i].imprimirDatos();
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
} while (opcion != 3);




















