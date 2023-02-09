using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO NETO DE SALARIOS EMPRESARIALES");

            Console.WriteLine("INTRODUZCA SU SALARIO TOTAL: ");
            int salario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca sus horas trabajadas a la semana: ");
            int HORAS = Convert.ToInt32(Console.ReadLine());

            if (HORAS > 44)
            {
                int preciohorasestandar = (salario / 44);
                int horasPorPagar = preciohorasestandar + (preciohorasestandar * (30 / 100));
                int salario1 = salario + horasPorPagar;
                double afp = (salario1 * (0.15));
                double s = (salario1 * (0.125));
                double salarioN = salario1 - afp - s;

                Console.WriteLine("USTED POSEE UN SALARIO NETO DE: " + salarioN);
            }
            else
            {
                double afp = (salario * (0.15));
                double s = (salario * (0.125));
                double salarioN = salario - afp - s;
                Console.WriteLine("USTED POSEE UN SALARIO NETO DE " + salarioN);
            }

            Console.ReadLine();
        }
    }
}
