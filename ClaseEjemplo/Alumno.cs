using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjemplo
{
    public class Alumno
    {
        public string nombre;
        public string carnet;
        public int semestre;

        //Metodo constructor
        public Alumno()
        {
            this.nombre = "Oliver";
            this.carnet = "";
            this.semestre = 0;
        }

        public Alumno(string nombre, string carnet, int s)
        {
            this.nombre = nombre;
            this.carnet = carnet;
            this.semestre = s;
        }

        public void imprimirDatos()
        {
            Console.WriteLine("Datos de alumno");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Carnet: " + this.carnet);
            Console.WriteLine("Semestre: " + this.semestre);
        }
    }
}
