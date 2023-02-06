using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero: ");
            int Numero = int.Parse(Console.ReadLine());

            if (Numero > 0)
            {
                int Factorial = 1;
                for (int i = Factorial; i <= Numero; i++)
                {
                    Factorial *= i;
                }
                Console.WriteLine("El factorial de: " + Numero + '\n' + "es: " + Factorial);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("El numero no es mayor a 1");
                Console.ReadLine();
         
            }
        }
        

    }
}
