using System;

namespace Proj03___Operadores_Aritméticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01 = 3 + 4 * 2;
            // Nesse caso, a multiplicação será feita antes da soma

            int num02 = (3 + 4) * 2;
            // Nesse caso, a Soma será feita antes da Multiplicação

            int num03 = 17 % 3;
                        
            double num04 = 10 / 8;
            // Forma errada de calcular com Casas decimais

            double num05 = (double)10 / 8;
            double num06 = 10.0 / 8;
            // forma certa de calcular com Casas decimais

            Console.WriteLine($"Resultado = {num01}");
            Console.WriteLine($"Resultado = {num02}");
            Console.WriteLine($"Resultado = {num03}");
            Console.WriteLine($"Resultado = {num04}");
            Console.WriteLine($"Resultado = {num05}");
            Console.WriteLine($"Resultado = {num06}");

            double a = 1.0, b = -3.0, c = -4.0;
            //Criando 3 variaves do tipo Double na mesma linha
                        
            double delta = Math.Pow(b, 2.0) - (4.0 * a * c);
            // Para calcular Potêcia utilizando o comando Math
                        
            double Root01 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            // Para calcular a raiz quadrada utilizando o comando Math

            Console.WriteLine($"Resultado raiz quadrada = {Root01}");
        }
    }
}
