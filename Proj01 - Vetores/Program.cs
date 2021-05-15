using System;

namespace Proj01___Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());

            //simplificando
          //Tipo[] Nome = Nova instancia Tipo[numero de posições]
            double[] vetor = new double[n];

            //Laço FOR para inserir as informações passando pelas posições do vetor
            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine()); //comando usado para inserir as informações na posição expecifica do vetor
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            double media = soma / n;

            Console.WriteLine($"Média de altura = {media.ToString("F2")}");

        }
    }
}
