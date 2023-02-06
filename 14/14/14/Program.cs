using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE ECUACIONES DE PRIMER GRADO");
            Console.WriteLine("Resolviendo ecuación de primer grado (ax + b = 0)");

            Console.WriteLine("Ingrese el valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b: ");
            double b = double.Parse(Console.ReadLine());

            if (a != 0)
            {
                double x = -b / a;
                Console.WriteLine("El valor de x es: " + x);
            }
            else
            {
                Console.WriteLine("El valor de a no puede ser cero");
            }
        }
    }
}
