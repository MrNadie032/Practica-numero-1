using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BIENVENIDO A LA SERIE DE FIBONACCI");
            Console.WriteLine("Ingrese un límite de iteraciones: ");
            int iteraciones = int.Parse(Console.ReadLine());

            int anterior = 0, actual = 1, siguiente = 0;

            Console.WriteLine("Serie de Fibonacci: ");
            Console.Write(anterior + " " + actual);

            for (int i = 2; i < iteraciones; i++)
            {
                siguiente = anterior + actual;
                Console.Write(" " + siguiente);
                anterior = actual;
                actual = siguiente;
            }
            Console.ReadLine();

        }
    }
}
