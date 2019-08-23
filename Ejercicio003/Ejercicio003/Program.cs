using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio003
{
    class Ejericicio3
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";

            int numero;

            Console.Write("Ingrese Numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i <= numero; i++)
            {
                if(i != 2 && i != 3 )
                {
                    if ((i % 2 != 0) && (i % 3 != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        } 
    }
}
