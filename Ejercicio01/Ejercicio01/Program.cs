using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class HolaMundo
    {
        static void Main(string[] args)
        {
            Console.Title = "Primera clase";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string nombre = "Nico";
            string apellido = "Ramirez";
            Console.WriteLine("Hola {0} {1}", nombre, apellido);

            Console.ReadKey();
        }
    }
}

