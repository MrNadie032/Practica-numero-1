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
            Console.WriteLine("BIENVENIDOS A CALCULOS CON FRACCIONES");
            Console.WriteLine("ELIGE UNA OPCION");
            Console.WriteLine("1-SUMA");
            Console.WriteLine("2-RESTA");
            Console.WriteLine("3-MULTIPLICACION");
            Console.WriteLine("4-DIVISION");

            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:

                    Console.WriteLine("Ingrese su primer numerador: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su primer denominador: ");
                    int dem1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Su fraccion es: " + num1 + "/" + dem1);

                    Console.WriteLine("Ingrese su segundo numerador: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su segundo denominador: ");
                    int dem2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Su fraccion es: " + num2 + "/" + dem2);

                    if (dem1 == dem2)
                    {
                        int numis = num1 + num2;

                        Console.WriteLine("La suma de fracciones es: " + numis + "/" + dem1);
                    }
                    else
                    {
                        int numdif = ((num1 * dem2) + (num2 * dem1));
                        int demdif = dem1 * dem2;

                        Console.WriteLine("La suma de fracciones es: " + numdif + "/" + demdif);
                    }

                    break;

                case 2:
                    Console.WriteLine("Ingrese su primer numerador: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su primer denominador: ");
                    dem1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Su fraccion es: " + num1 + "/" + dem1);

                    Console.WriteLine("Ingrese su segundo numerador: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su segundo denominador: ");
                    dem2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Su fraccion es: " + num2 + "/" + dem2);

                    if (dem1 == dem2)
                    {
                        int numis = num1 - num2;

                        Console.WriteLine("La resta de fracciones es: " + numis + "/" + dem1);
                    }
                    else
                    {
                        int numdif = ((num1 * dem2) - (num2 * dem1));
                        int demdif = dem1 * dem2;

                        Console.WriteLine("La resta de fracciones es: " + numdif + "/" + demdif);
                    }
                    break;

                case 3:
                    Console.WriteLine("Ingrese el primer numerador: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el primer denominador: ");
                    dem1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Su fraccion es: " + num1 + "/" + dem1);

                    Console.WriteLine("Ingrese el segundo numerador: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo denominador: ");
                    dem2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Su fraccion es: " + num2 + "/" + dem2);

                    int numr = num1 * num2;
                    int demr = dem1 * dem2;
                    Console.WriteLine("La multiplicacion de fracciones es: " + numr + "/" + demr);

                    break;

                case 4:
                    Console.WriteLine("Ingrese su primer numerador: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su primer denominador: ");
                    dem1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("su fraccion es: " + num1 + "/" + dem1);

                    Console.WriteLine("Ingrese su segundo numerador: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su segundo denominador: ");
                    dem2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Su fraccion es: " + num2 + "/" + dem2);

                    numr = num1 * dem2;
                    demr = num2 * dem1;
                    Console.WriteLine("La division de fracciones es: " + numr + "/" + demr);

                    break;

                default:
                    Console.WriteLine("Opcion Invalida, aprende a leer");
                    break;
            }

            Console.ReadLine();
        }
        
    }
}

