using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio001
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            int numero;
            int acumulador = 0;
            int max = 0;
            int min = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese 5 numeros:");
                numero = Convert.ToInt32(Console.ReadLine());

                acumulador += numero;

                if(i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else if(i == 0 || numero > max)
                {
                    max = numero;
                }
                else if(i == 0 || numero < min)
                {
                    min = numero;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Maximo : {0}", max);
            Console.WriteLine("Minimo : {0}", min);
            Console.WriteLine("Promedio : {0}", acumulador / 5.0);
            Console.ReadKey();

        }
    }
}
