using System;

namespace Proj12___Estrutura_For // A estrutura For é usada para executar um laço com Contagem determinada de repetições
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Numeros vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++) //Toda vez que a condição for verdadeira, ele executa o laço novamente Incrementando após chegar no final
            {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor; // O comando "+=" é usado para incrementar uma váriavel com o valor de outra
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
