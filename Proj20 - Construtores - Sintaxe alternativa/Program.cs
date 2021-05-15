using System;

namespace Proj20___Construtores___Sintaxe_alternativa
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com os dados do Produto:");
            Console.WriteLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em Estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            // Essa Sintaxe funciona mesmo se a Classe não tiver construtores
            Produto prod = new Produto 
            { 
                Nome = nome, 
                Preco = preco, 
                Estoque = estoque 
            };


            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {prod}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            prod.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {prod}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do Estoque: ");
            qtd = int.Parse(Console.ReadLine());
            prod.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.Write($"Dados atualizados: {prod}");
        }
    }
}
