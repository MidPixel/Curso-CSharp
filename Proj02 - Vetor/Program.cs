using System;

namespace Proj02___Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Criando um vetor com classes
          //Classe[] Nome = nova Instancia Tipo[quantidade de posições]
            Product[] vetorProd = new Product[n];


            // Utilizando FOR para inserir as informações dentro do vetor
            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vetorProd[i] = new Product(nome, preco);
                            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                //chamando os valores do vetor na posição Preço
                soma += vetorProd[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine($"A média de preço é = {media.ToString("F2")}");
        }
    }
}
