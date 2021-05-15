using System;

namespace Proj08___Operadores_Lógicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cond01 = 2 > 3 && 4 != 5;      // False
            bool cond02 = 2 > 3 || 4 != 5;      // True 
            bool cond03 = !(2 > 3) || 4 != 5;   // True
                                                // O operador "!" nega/inverte o resultado

            Console.WriteLine($"Condição 1: {cond01}");
            Console.WriteLine($"Condição 2: {cond02}");
            Console.WriteLine($"Condição 3: {cond03}");

            Console.WriteLine("-----------------");

            // Sequência de precedência ! > && > ||

            bool condEx = cond01 || cond02 && cond03;

            Console.WriteLine(condEx);
        }
    }
}
