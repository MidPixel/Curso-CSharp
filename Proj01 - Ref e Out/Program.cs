using System;

// Não Funciona

namespace Proj01___Ref_e_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(a); //não funciona, pois a função "Tripe" não retorna nada.
            Console.WriteLine(a);
        }
    }
}
