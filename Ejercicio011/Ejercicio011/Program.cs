using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011
{
    class Ejercicio011
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            int max = 0;
            int min = 0;
            int valor;
            int acumulador = 0;
            int contador = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese 6 numeros enteros: ");
                while ( !int.TryParse(Console.ReadLine(), out valor) ||
                        !Validacion.Validar(valor, -100, 100))
                {
                    Console.WriteLine("Ingrese 10 numeros enteros validos: ");
                }

                acumulador += valor;
                contador++;

                if (i == 0)
                {
                    max = valor;
                    min = valor;
                }
                else if (valor > max)
                {
                    max = valor;
                }
                else if (valor < min)
                {
                    min = valor;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Maximo : {0}", max);
            Console.WriteLine("Minimo : {0}", min);
            Console.WriteLine("Promedio : {0}", acumulador / contador);
            Console.ReadKey();
        }
    }

    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if(valor < min || valor > max)
            {
                return false;
            }
            return true;
        }
    }
}
