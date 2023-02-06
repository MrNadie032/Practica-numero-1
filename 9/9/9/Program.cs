using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS AL CALCULOS FISICO DE VELOCIDAD, DISTANCIA, TIEMPO");


            Console.WriteLine("Las opciones para calcular son: ");
            Console.WriteLine("1 - DISTANCIA");
            Console.WriteLine("2 - VELOCIDAD");
            Console.WriteLine("3 - TIEMPO");
            Console.WriteLine("Ingresa la función a calcular: ");
            int opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.WriteLine("LA FORMULA DE LA DISTANCIA = VELOCIDAD * TIEMPO");
                    Console.WriteLine("INTRUZCA LA VELOCIDAD EN KM/H: ");
                    double velocidad = double.Parse(Console.ReadLine());
                    Console.WriteLine("INTRODUZCA EL TIEMPO EN SEGUNDOS: ");
                    double tiempo = double.Parse(Console.ReadLine());
                    double distancia = velocidad * tiempo;
                    Console.WriteLine("LA RESPUESTA ES: " + distancia + "M");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("LA FORMULA DE LA VELOCIDAD = DISTANCIA / TIEMPO");
                    Console.WriteLine("INTRUZCA LA DISTANCIA EN METRO: ");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine("INTRODUZCA EL TIEMPO EN SEGUNDOS: ");
                    double t = double.Parse(Console.ReadLine());
                    double v = d / t;
                    Console.WriteLine("LA RESPUESTA ES: " + v + "KM/H");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("LA FORMULA DE LA TIEMPO = DISTANCIA / VELOCIDAD");
                    Console.WriteLine("INTRUZCA LA DISTANCIA EN METROS: ");
                    double d2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("INTRODUZCA EL VELOCIDAD EN KM/H: ");
                    double V2 = double.Parse(Console.ReadLine());
                    double T2 = d2 / V2;
                    Console.WriteLine("LA RESPUESTA ES: " + T2 + "S");
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
