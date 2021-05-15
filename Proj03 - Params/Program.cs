using System;

// O jeito com Params

namespace Proj03___Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Soma( 2, 3 ); //Com Params na Classe, não é mais preciso instanciar um novo vetor, ele faz isso automaticamente
            int s2 = Calculator.Soma( 2, 4, 3 );

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
