using System;

namespace Proj10___Funções_Sintaxe
{
    class Program
    {
        static void Main(string[] args) // Esse é o EntryPoint da Aplicação
        {
            Console.WriteLine("Digite três numeros");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = numMaior(num1, num2, num3);
            Console.WriteLine($"Maior = {result}");
        }

        static int numMaior(int num01, int num02, int num03) // Função criada para automatizar o código
        {
            int maior;
            if (num01 > num02 && num01 > num03)
            {
                maior = num01;
            }
            else if (num02 > num03)
            {
                maior = num02;
            }
            else
            {
                maior = num03;
            }

            return maior; //Return é usado para devolver o resultado para quem chamou a função "numMaior"
        }
    }
}
