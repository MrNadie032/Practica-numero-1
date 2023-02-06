using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS AL PROGRAMA DE PERMUTACIONES");
            Console.WriteLine("FAVOR INTRODUCIR UN NUMERO DE PERMUTACIONES: ");
            int permutaciones = int.Parse(Console.ReadLine());
            Console.WriteLine("FAVOR INTRODUCIR EL NUMERO DE POSICIONES A PERMUTAR");
            int posiciones = int.Parse(Console.ReadLine());

            int Factorial = 1;
            int factorialp = 1;
            int factorialm = 1;
            if (permutaciones <= posiciones)
            {

                for (int i = Factorial; i <= permutaciones; i++)
                {
                    Factorial *= i;
                }
                Console.WriteLine("El Numero de permutaciones es: " + Factorial);
                Console.ReadLine();
            }
            else
            {
                for (int i = factorialp; i <= permutaciones; i++)
                {
                    factorialp *= i;

                    for (int j = factorialm; j <= permutaciones; i++)
                    {
                        factorialm *= j;
                    }
                }
                int cambios = 0;
                cambios = Factorial / (factorialp - factorialm);

                Console.WriteLine("LA CANTIDAD DE PERMUTACIONES ES: " + cambios);
                Console.ReadLine();

            }
        }
    }
}