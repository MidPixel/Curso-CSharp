using System;

namespace Proj14___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo trianguloX, trianguloY; //Chamando a classe criada e já associando cada variavel composta

            trianguloX = new Triangulo(); // instânciando a Variavel composta
            trianguloY = new Triangulo();
            
            Console.WriteLine("Entre com as medidas do triângulo X");

            Console.Write("Cateto vertical: ");
            trianguloX.CatetoVertical = double.Parse(Console.ReadLine()); //associando o valor do atributo da Variavel de Classe Triangulo

            Console.Write("Cateto Horizontal: ");
            trianguloX.CatetoHorizontal = double.Parse(Console.ReadLine());

            Console.Write("Hipotenusa: ");
            trianguloX.Hipotenusa = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y");

            Console.Write("Cateto vertical: ");
            trianguloY.CatetoVertical = double.Parse(Console.ReadLine());

            Console.Write("Cateto Horizontal: ");
            trianguloY.CatetoHorizontal = double.Parse(Console.ReadLine());

            Console.Write("Hipotenusa: ");
            trianguloY.Hipotenusa = double.Parse(Console.ReadLine());

            double pX = p(trianguloX.CatetoVertical, trianguloX.CatetoHorizontal, trianguloX.Hipotenusa);
            double pY = p(trianguloY.CatetoVertical, trianguloY.CatetoHorizontal, trianguloY.Hipotenusa);

            double areaX = Area(trianguloX.CatetoVertical, trianguloX.CatetoHorizontal, trianguloX.Hipotenusa, pX);
            double areaY = Area(trianguloY.CatetoVertical, trianguloY.CatetoHorizontal, trianguloY.Hipotenusa, pY);

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
