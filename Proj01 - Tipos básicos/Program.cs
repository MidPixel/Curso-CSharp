using System;

namespace Proj01___Tipos_básicos
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = 100;
            //sbyte     Byte:1  Max/Min: -128/127

            //short     Byte:2  Max/Min: -32768/32767

            int num3 = 1000;
            //int       Byte:4  Max/Min: -2147483648/2147483647

            long num4 = 2147483648L;
            /*long      Byte:8  Max/Min: -9223372036854776000/9223372036854775999
            colocar um "L" no final para indicar explicitamente que é um numero Long*/

            byte num5 = 126;
            //byte      Byte:1  Max/Min: 0/255

            //ushort    Byte:2  Max/Min: 0/65535
            //uint      Byte:4  Max/Min: 0/4294967295
            //ulong     Byte:8  Max/Min: 0/9223372036854775999

            float num9 = 4.5f;
            /*float     Byte:4
            colocar um "f" no final para indicar explicitamente que é um numero float*/

            double num10 = 4.5;
            //double    Byte:8

            char gen = 'F';
            //char      Byte:2  Any Unicode Character

            bool comp = false;
            //bool      Byte:1/2    Max/Min: true/False

            object obj01 = "Maria";
            object obj02 = 2.4f;
            /*O object é um tipo genérico, que pode receber todos e quaisquer tipo
            toda classe em c# é uma subclasse de Object*/

            Console.WriteLine($"Numero sbyte: {num1}");
            Console.WriteLine($"Numero short: ");
            Console.WriteLine($"Numero int: {num3}");
            Console.WriteLine($"Numero long: {num4}");
            Console.WriteLine($"Numero byte: {num5}");
            Console.WriteLine($"Numero float: {num9}");
            Console.WriteLine($"Numero double: {num10}");
            Console.WriteLine($"Valor char: {gen}");
            Console.WriteLine($"Valor Booleano: {comp}");
            Console.WriteLine($"Object recebe: {obj01}");
            Console.WriteLine($"Object recebe: {obj02}");
        }
    }
}
