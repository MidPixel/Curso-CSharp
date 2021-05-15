using System;

namespace Exerc01___Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o Numero de linhas da Matriz: ");
            int matLinhas = int.Parse(Console.ReadLine());
            Console.Write("Insira o Numero de Colunas da Matriz: ");
            int matColunas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matriz = new int[matLinhas, matColunas];

            for (int lin = 0; lin < matLinhas; lin++)
            {
                for (int col = 0; col < matColunas; col++)
                {
                    Console.Write($"Insira o Valor para a posição Linha {lin}, Coluna {col}: ");
                    matriz[lin, col] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Diagonal Principal: ");

            for (int var = 0; var < matLinhas; var++)
            {
                Console.Write(matriz[var, var] + " ");
            }
            Console.WriteLine();

            int valNegativo = 0;

            for (int lin = 0; lin < matLinhas; lin++)
            {
                for (int col = 0; col < matColunas; col++)
                {
                    if (matriz[lin, col] < 0)
                    {
                        valNegativo++;
                    }
                }
            }

            Console.WriteLine($"Valores negativos: {valNegativo}");
        }
    }
}
