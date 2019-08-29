using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area = Math.Pow(lado, 2);
            return area;
        }

        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            double area = (baseTriangulo * altura) / 2;
            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
