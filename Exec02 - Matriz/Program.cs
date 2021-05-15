using System;

//Outra forma de Resolver o Problema

namespace Exerc02___Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas Linhas e Colunas terá a Matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite os valores que a linha {i + 1} ira receber:");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; i++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            for (int var = 0; var < n; var++)
            {
                Console.Write(mat[var, var] + " ");
            }
            Console.WriteLine();

            int count = 0;

            for (int lin = 0; lin < n; lin++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (mat[lin, col] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Valores negativos: {count}");
        }
    }
}
