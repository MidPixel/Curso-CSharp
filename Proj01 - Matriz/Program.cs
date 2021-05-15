using System;

namespace Proj01___Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];    //O Comando "[,]" informa que vc está declarando um Arranjo Bidimensional
                                                    //O Comando "[2, 3]" Informa quantas Linhas e quantas colunas a Matriz terá

            Console.WriteLine(matriz.Length);       //O Comando ".Length" mostra quantos elementos a Matriz tem no total

            Console.WriteLine(matriz.Rank);         //O Comando ".Rank" mostra a primeira dimensão, quantas linhas tem dentro da matriz



                                                    //O comando ".GetLength(posição)" se refere a indicação feita em "double[,] matriz", onde cada posição (0 e 1)
                                                    //se refere a "new double[Posição 0, Posição 1]", o que indica que 0 são as linhas e 1 são as colunas

            Console.WriteLine(matriz.GetLength(0)); //O Comando ".GetLength(0)" Mostra quantas Linhas tem na Matriz
            Console.WriteLine(matriz.GetLength(1)); //O Comando ".GetLength(1)" Mostra quantas Colunas tem na Matriz

                                                    
        }           
    }
}
