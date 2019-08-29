using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio015
{
    class Calculadora
    {
        public static float Calcular(float numeroUno, float numeroDos, char operacion)
        {
            float resultado = 0;

            switch(operacion)
            {   
                case "*":
                    resultado = numeroUno * numeroDos;
                    return resultado;
                    break;




        }
    }
}
