using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO DE ECUACIONES DE 2DO GRADO");
            Console.WriteLine("INGRESE LA SIGUIENTES VARIABLES: ");
            Console.WriteLine("A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("C: ");
            int C = int.Parse(Console.ReadLine());


            double Parte1 = Math.Pow(B, 2) - 4 * (A * C);
            double X1, X2;

            if (Parte1 > 0)
            {
                X1 = -B + Math.Sqrt(Parte1) / (2 * A);
                X2 = -B - Math.Sqrt(Parte1) / (2 * A);
                Console.WriteLine("LA RESPUESTA ES PARA LA VARIABLE 1: " + X1 + '\n' + "LA RESPUESTA DE LA VARIABLE 2: " + X2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("NO EXISTE SOLUCION REAL MI BROTHER");
                Console.ReadLine();
            }




        }
    }
}