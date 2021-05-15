using System;
using System.Collections.Generic;

namespace Exerc01___Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O curso A possui quantos alunos? ");
            int numAlunosA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            HashSet<int> cursoA = new HashSet<int>();

            for (int var = 0; var < numAlunosA; var++)
            {
                cursoA.Add(int.Parse(Console.ReadLine()));
            }


            Console.WriteLine("O curso B possui quantos alunos? ");
            int numAlunosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            HashSet<int> cursoB = new HashSet<int>();

            for (int var = 0; var < numAlunosB; var++)
            {
                cursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("O curso C possui quantos alunos? ");
            int numAlunosC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            HashSet<int> cursoC = new HashSet<int>();

            for (int var = 0; var < numAlunosC; var++)
            {
                cursoC.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> totalAlunos = new HashSet<int>();

            totalAlunos.UnionWith(cursoA);
            totalAlunos.UnionWith(cursoB);
            totalAlunos.UnionWith(cursoC);

            Console.WriteLine($"Total de alunos: {totalAlunos.Count}");
        }
    }
}
