using System;

//Jeito errado de se fazer

namespace Proj01___Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Soma(2, 3);
            int s2 = Calculator.Soma(2, 5, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
