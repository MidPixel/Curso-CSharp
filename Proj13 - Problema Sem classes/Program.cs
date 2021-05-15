using System;

namespace Proj13___Problema_Sem_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X");

            Console.Write("Cateto vertical: ");
            double vertX = double.Parse(Console.ReadLine());

            Console.Write("Cateto Horizontal: ");
            double horiX = double.Parse(Console.ReadLine());

            Console.Write("Hipotenusa: ");
            double hipoX = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y");

            Console.Write("Cateto vertical: ");
            double vertY = double.Parse(Console.ReadLine());

            Console.Write("Cateto Horizontal: ");
            double horiY = double.Parse(Console.ReadLine());

            Console.Write("Hipotenusa: ");
            double hipoY = double.Parse(Console.ReadLine());

            double pX = p(vertX, horiX, hipoX);
            double pY = p(vertY, horiY, hipoY);

            double areaX = Area(vertX, horiX, hipoX, pX);
            double areaY = Area(vertY, horiY, hipoY, pY);

            Console.WriteLine($"Area de X = {areaX.ToString("F4")}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4")}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area: X");
            }
            else if (areaX == areaY)
            {
                Console.WriteLine("As duas Areas são Iguais");
            }
            else
            {
                Console.WriteLine("Maior Area: Y");
            }


        }

        static double p(double num1, double num2, double num3)
        {
            double somaLados = num1 + num2 + num3;

            double result = somaLados / 2;

            return result;
        }

        static double Area(double a, double b, double c, double p)
        {
            double equal = p * (p - a) * (p - b) * (p - c);
            double result = Math.Sqrt(equal);

            return result;
        }
    }
}
