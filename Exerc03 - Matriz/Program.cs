using System;

namespace Exerc03___Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de Linhas: ");
            int matLinhas = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de Colunas: ");
            int matColunas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matriz = new int[matLinhas, matColunas];

            for (int x = 0; x < matLinhas; x++)
            {
                Console.WriteLine($"Digite os valores da Linha {x + 1}:");
                string[] vector = Console.ReadLine().Split(' ');
                for (int y = 0; y < matColunas; y++)
                {
                    matriz[x, y] = int.Parse(vector[y]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz Completa:");
            for (int x = 0; x < matLinhas; x++)
            {
                for (int y = 0; y < matColunas; y++)
                {
                    Console.Write(matriz[x, y] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Digite o Numero que gostaria de achar: ");
            int findNumber = int.Parse(Console.ReadLine());

            for (int x = 0; x < matLinhas; x++)
            {
                for (int y = 0; y < matColunas; y++)
                {
                    if (matriz[x, y] == findNumber)
                    {
                        Console.WriteLine($"Possição {x}, {y}");
                        Console.WriteLine($"A Cima {matriz[x - 1, y]}");
                        Console.WriteLine($"A Baixo {matriz[x + 1, y]}");
                        Console.WriteLine($"A esquerda {matriz[x, y - 1]}");
                        Console.WriteLine($"A esquerda {matriz[x, y + 1]}");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
