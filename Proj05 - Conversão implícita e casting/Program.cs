using System;

namespace Proj05___Conversão_implícita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão Implicita
            float x = 4.5f; // 4 Bytes
            double y = x;   // 8 Bytes
            //conversão de Float para Double
            Console.WriteLine(y);

            // Fazendo casting entre tipos de tamanhos diferente
            double type01 = 5.1;            // 8 bytes
            float type02 = (float)type01;   // 4 bytes
            //Casting de double para float
            Console.WriteLine(type02);

            // No caso de operações com resultado decimal é necessário efetuar o Casting dos dados
            int a = 5;
            int b = 2;
            double result = (double)a / b;
            // efetuando o casting de um resultado INT para DOUBLE
            Console.WriteLine(result);
        }
    }
}
