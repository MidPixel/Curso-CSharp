using System;

namespace Proj21___This
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

            Produto prod = new Produto(nome, preco, estoque);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {prod}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados no estoque: ");
            int qtd = int.Parse(Console.ReadLine()); //Digitando o valor que a Função AdicionarProdutos irá receber
            prod.AdicionarProdutos(qtd); //Apontando para a função AdicionarProdutos o Valor Digitado

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