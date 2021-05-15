using System;

namespace Proj02___Tipos_Basícos
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte Type01 = 100;
            int Type02 = 1000;
            int Type03 = 214783647;
            long Type04 = 2147483648L;

            bool Test01 = false;
            char Test02 = 'f';

            float num01 = 4.5f;
            double num02 = 4.5;

            string nome = "willian";

            double numTest = 23.3475584;

            Console.WriteLine(Type01);
            Console.WriteLine(Type02);
            Console.WriteLine(Type03);
            Console.WriteLine(Type04);

            Console.WriteLine(Test01);
            Console.WriteLine(Test02);
            Console.WriteLine(num01);
            Console.WriteLine(num02);
            Console.WriteLine(nome);

            //Determinar os numeros de casas decimais usando o ToString
            Console.WriteLine(numTest.ToString("F2"));
            Console.WriteLine(numTest.ToString("F4"));
        }
    }
}
