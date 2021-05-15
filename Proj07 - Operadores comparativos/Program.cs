using System;

namespace Proj07___Operadores_comparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool Cond01 = a < 10; // Menor
            bool Cond02 = a < 20; // Menor
            bool Cond03 = a > 10; // Maior
            bool Cond04 = a > 5;  // Maior

            Console.WriteLine(Cond01);
            Console.WriteLine(Cond02);
            Console.WriteLine(Cond03);
            Console.WriteLine(Cond04);
            Console.WriteLine("------------------");

            bool Cond05 = a <= 10; // Menor ou Igual
            bool Cond06 = a >= 10; // Maior ou Igual
            bool Cond07 = a == 10; // Igual
            bool Cond08 = a != 10; // Diferente

            Console.WriteLine(Cond05);
            Console.WriteLine(Cond06);
            Console.WriteLine(Cond07);
            Console.WriteLine(Cond08);
            Console.WriteLine("------------------");

        }
    }
}
