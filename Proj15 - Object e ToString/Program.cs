using System;

namespace Proj16___Object_e_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();

            Console.WriteLine("Entre com os dados do Produto:");
            Console.WriteLine();

            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em Estoque: ");
            prod.Estoque = int.Parse(Console.ReadLine());

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
