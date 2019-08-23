using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio002
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";
            int numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese Numero:");
            numero = Convert.ToInt32(Console.ReadLine());

           /* Console.WriteLine("Numero al cuadrado:");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero al cubo:");
            numero = Convert.ToInt32(Console.ReadLine());*/

            if(numero <= 0)
            {
                Console.WriteLine("ERROR.¡Reingresar nùmero!");
                Console.WriteLine("Reingrese Numero:");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                cuadrado = Math.Pow(numero, 2);
                Console.WriteLine("Numero al cuadrado : {0}", cuadrado);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("Numero al cubo : {0}", cubo);
            }
            Console.ReadKey();
        }
    }
}
