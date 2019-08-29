using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    class Ejercicio014
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double ladoCuadrado, baseTriangulo, alturaTriangulo, radioCirculo;
            double areaCuadrado, areaTriangulo, areaCirculo;
            int opcionUno;

            Console.Write("Seleccione que calculo desea realizar: \n");
            Console.Write("1 - Calcular Area del Cuadrado  \n");
            Console.Write("2 - Calcular Area del Triangulo \n");
            Console.Write("3 - Calcular Area del Circulo   \n");
            opcionUno = Convert.ToInt32(Console.ReadLine());

            switch (opcionUno)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("AREA CUADRADO\n");
                    Console.Write("Ingrese lado del cuadrado: ");
                    ladoCuadrado = Convert.ToInt32(Console.ReadLine());
                    areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                    Console.WriteLine("Area del cuadrado: {0}", areaCuadrado);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("\nAREA TRIANGULO\n");
                    Console.Write("Ingrese base del triangulo: ");
                    baseTriangulo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese altura del triangulo: ");
                    alturaTriangulo = Convert.ToInt32(Console.ReadLine());
                    areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                    Console.WriteLine("Area del triangulo: {0}", areaTriangulo);
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("\nAREA CIRCULO\n");
                    Console.Write("Ingrese el radio circulo: ");
                    radioCirculo = Convert.ToInt32(Console.ReadLine());
                    areaCirculo = CalculoDeArea.CalcularCirculo(radioCirculo);
                    Console.WriteLine("Area del circulo: {0}", areaCirculo);
                    break;
                
                default:
                    Console.Clear();
                    Console.Write("Opción no válida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
