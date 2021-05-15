using System;

namespace Proj09___Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero Inteiro");
            int Num01 = int.Parse(Console.ReadLine());

            int Result = Num01 % 2;

            if (Result == 0)
            {
                Console.WriteLine($"o Numero {Num01} é Par");
            }
            else
            {
                Console.WriteLine($"o Numero {Num01} é Impar");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Qual a Hora atual?");
            int Hora = int.Parse(Console.ReadLine());

            if (Hora <= 24) {
                if (Hora < 6) {
                    Console.WriteLine("boa noite");
                }
                else if (Hora < 12)
                {
                    Console.WriteLine("bom dia");
                }
                else if (Hora < 18)
                {
                    Console.WriteLine("Boa Tarde");
                }
                else
                {
                    Console.WriteLine("Boa noite");
                }
            } else {
                Console.WriteLine("Hora Invalida");   
            }
        }
    }
}
