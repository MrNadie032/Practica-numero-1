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
            Console.WriteLine("BIENVENIDOS AL CALCULAR DE FUNCIONES TRIGONOMETRICAS");

            Console.WriteLine("Ingresa el ángulo en grados:");
            double angulo = double.Parse(Console.ReadLine());

           
            Console.WriteLine("Las opciones para calcular son: ");
            Console.WriteLine("1 - SENO");
            Console.WriteLine("2 - COSENO");
            Console.WriteLine("3 - TANGENTE");
            Console.WriteLine("4 - COTANGENTE");
            Console.WriteLine("5 - SECANTE");
            Console.WriteLine("6 - CONSECANTE");
            Console.WriteLine("Ingresa la función a calcular: ");
            int opciones = int.Parse(Console.ReadLine());
            double radians = angulo * Math.PI / 180;
            double resultado;
            switch (opciones)
            {
                case 1:
                    resultado = Math.Sin(radians);
                    break;
                case 2:
                    resultado = Math.Cos(radians);
                    break;
                case 3:
                    resultado = Math.Tan(radians);
                    
                    break;
                case 4:
                    resultado = 1 / Math.Tan(radians);
                   
                    break;
                case 5:
                    resultado = 1 / Math.Cos(radians);
                    
                    break;
                case 6:
                    resultado = 1 / Math.Sin(radians);
                   
                    break;
                default:
                    Console.WriteLine("Opcion Invalida, aprende a leer");
                    Console.ReadLine();
                    return;
            }
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadLine();
        }
    }
}
