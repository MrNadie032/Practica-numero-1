using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS A CALCULOS CON VOLUMEN DE FIGURA GEOMETRICAS");
            Console.WriteLine("Las opciones para calcular son: ");
            Console.WriteLine("1 - CUBO");
            Console.WriteLine("2 - ESFERA");
            Console.WriteLine("3 - CONO");
            Console.WriteLine("4 - PIRAMIDE");
            Console.WriteLine("SELECIONES LA FIGURA QUE DESEE CALCULAR");
            int opciones = int.Parse(Console.ReadLine());
            switch (opciones)
            {
                case 1:
                    Console.WriteLine("La ecuacion es VOLUMEN = LADO^3");
                    Console.WriteLine("ingrese la cantidad de lados: ");
                    double h = int.Parse(Console.ReadLine());
                    double n = Math.Pow(h, 3);
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + n);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("La ecuacion es volumen = 4/3 * π * Radio^3");
                    Console.WriteLine("ingrese el radio");
                    double y = double.Parse(Console.ReadLine());
                    double f = (4 / 3) * Math.PI * Math.Pow(y, 3);
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + f);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("La ecuacion es VOLUMEN = 1/3 * ALTURA * π * RADIO^2");
                    Console.WriteLine("ingrese la ALTURA");
                    double e = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la RADIO");
                    double j = double.Parse(Console.ReadLine());
                    double q = (1.0 / 3.0) * e * Math.PI * (Math.Pow(j, 2));
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + q);
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("La ecuacion es VOLUMEN = BASE * ALTURA / 3");
                    Console.WriteLine("ingrese la BASE");
                    double O = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la ALTURA");
                    double L = double.Parse(Console.ReadLine());
                    double b = ((O * L) / 3);
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + b);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Opcion Invalida, aprende a leer");
                    Console.ReadLine();
                    break;
            }
    }
}
