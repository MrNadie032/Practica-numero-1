using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS A CALCULOS CON AREA DE FIGURA GEOMETRICAS");
            Console.WriteLine("Las opciones para calcular son: ");
            Console.WriteLine("1 - CUADRADO");
            Console.WriteLine("2 - CIRCULO");
            Console.WriteLine("3 - TRIANGULO");
            Console.WriteLine("4 - PENTAGONO");
            Console.WriteLine("5 - HEXAGONO");
            Console.WriteLine("SELECIONES LA FIGURA QUE DESEE CALCULAR");
            int opciones = int.Parse(Console.ReadLine());
            switch (opciones)
            {
                case 1:
                    Console.WriteLine("La ecuacion es AREA = BASE * ALTURA");
                    Console.WriteLine("ingrese la base");
                    double b = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la altura");
                    double h = int.Parse(Console.ReadLine());
                    double a = 0;
                    a = b * h;
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + a);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("La ecuacion es AREA = π * Radio^2");
                    Console.WriteLine("ingrese el radio");
                    double n = int.Parse(Console.ReadLine());
                    double f = 0;
                    f = (int)(System.Math.PI * Math.Pow(n, 2));
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + f);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("La ecuacion es AREA = BASE * ALTURA / 2");
                    Console.WriteLine("ingrese la base");
                    int e = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la altura");
                    int j = int.Parse(Console.ReadLine());
                    double q = 0;
                    q = ((e * j) / 2);
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + q);
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("La ecuacion es AREA = PERIMETRO * APOTEMA / 2");
                    Console.WriteLine("ingrese la perimetro");
                    int O = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la apotema");
                    int L = int.Parse(Console.ReadLine());
                    b = 0;
                    b = ((O * L) / 2);
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + b);
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("La ecuacion es AREA = PERIMETRO * APOTEMA / 2");
                    Console.WriteLine("ingrese la perimetro");
                    int v = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la apotema");
                    int u = int.Parse(Console.ReadLine());
                    h = 0;
                    h = ((v * u) / 2);
                    Console.WriteLine("El RESULTADO DEL CALCULO ES: " + h);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion Invalida, aprende a leer");
                    Console.ReadLine();
                    break;
            }
        }
        }
    }

