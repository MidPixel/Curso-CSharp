using System;

//Jeito com vertor

namespace Proj02___Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Soma(new int[] { 2, 3 });
            int s2 = Calculator.Soma(new int[] { 2, 4, 3 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
