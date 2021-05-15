using System;

namespace Proj15___Metodos
{
    class program
    {
        static void Main(string[] args)
        {
            Triangulo trianguloX, trianguloY;

            trianguloX = new Triangulo();
            trianguloY = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X");

            Console.Write("Cateto vertical: ");
            trianguloX.CatetoVertical = double.Parse(Console.ReadLine());

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

            double areaX = trianguloX.Area();
            double areaY = trianguloY.Area();

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


    }
}

