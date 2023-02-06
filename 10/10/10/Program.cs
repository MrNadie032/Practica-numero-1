using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS A CONVERSIONES DE TEMPERATURA");


            Console.WriteLine("Las opciones para calcular son: ");
            Console.WriteLine("1 - CELSIUS A KELVIN");
            Console.WriteLine("2 - CELCIUS A FARENHEIT");
            Console.WriteLine("3 - KELVIN A CELSIUS");
            Console.WriteLine("4 - KELVIN A FARENHEIT");
            Console.WriteLine("5 - FARENHEIT A CELSIUS");
            Console.WriteLine("5 - FARENHEIT A KELVIN");
            Console.WriteLine("Ingresa la función a calcular: ");
            int opciones = int.Parse(Console.ReadLine());

            Console.WriteLine("INTRODUZCA LA TEMPERATURA: ");
            Double temperatura = double.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    double a = temperatura + 273.15;
                    Console.WriteLine(temperatura + "°C = " + a + "K");
                    Console.ReadLine();
                    break;
                case 2:
                    double b = (temperatura * 9 / 5) + 32;
                    Console.WriteLine(temperatura + "°C = " + b + "°F");
                    Console.ReadLine();
                    break;
                case 3:
                    double c = temperatura - 273.15;
                    Console.WriteLine(temperatura + "K = " + c + "°C");
                    Console.ReadLine();
                    break;
                case 4:
                    double d = (temperatura - 273.15) * (9 / 5) + 32;
                    Console.WriteLine(temperatura + "K = " + d + "°F");
                    Console.ReadLine();
                    break;
                case 5:
                    double e = (temperatura - 32) * (5 / 9);
                    Console.WriteLine(temperatura + "F = " + e + "°C");
                    Console.ReadLine();
                    break;
                case 6:
                    double f = (temperatura + 459.67) * (5 / 9);
                    Console.WriteLine(temperatura + "F = " + f + "°K");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion Invalida, aprende a leer");
                    Console.ReadLine();
                    return;
            }
        }
    }
}

