using System;
using System.Collections.Generic;

namespace Exerc02___List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos serão cadastrados? ");
            int prodQuant = int.Parse(Console.ReadLine());
            Console.WriteLine();



            List<Produto> prodList = new List<Produto>();

            for (int quant = 0; quant < prodQuant; quant++) // Informações de entrada do Produto
            {
                Console.WriteLine($"Cadastro #{quant + 1}");
                Console.Write("Id do produto: ");
                int prodId = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string prodNome = Console.ReadLine();
                Console.Write("Estoque: ");
                int prodEstoque = int.Parse(Console.ReadLine());
                Console.Write("Valor: ");
                double prodValor = double.Parse(Console.ReadLine());
                Console.WriteLine();

                prodList.Add(new Produto(prodId, prodNome, prodEstoque, prodValor));

            }

            Console.Write("Gostaria de ver a Lista de porodutos?(Y or N): ");
            char respTest = char.Parse(Console.ReadLine());

            if (respTest == 'y' || respTest == 'Y')
            {
                foreach (Produto item in prodList)
                {
                    Console.WriteLine();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("O que gostaria de executar?");
            Console.WriteLine();
            Console.WriteLine("Novo produto(N)");
            Console.WriteLine("Remover produto(R)");
            Console.WriteLine("Alterar Valor(V)");
            Console.WriteLine("Alterar estoque(E)");
            Console.WriteLine();

            Console.Write("Digite o comando: ");
            char exec = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            if (exec == 'n' || exec == 'N') // Linha comando "Adicionar Produto"
            {
                respTest = 'y';
                while (respTest == 'y' || respTest == 'Y')
                {
                    Console.WriteLine("Digite as informações do Produto");
                    Console.Write("Id do produto: ");
                    int prodId = int.Parse(Console.ReadLine());
                    Produto prodBusca = prodList.Find(var => var.ID == prodId);
                    if (prodBusca != null)
                    {
                        Console.WriteLine();
                        Console.WriteLine("A ID de Produto já existe");
                    }
                    else
                    {
                        Console.Write("Nome: ");
                        string prodNome = Console.ReadLine();
                        Console.Write("Estoque: ");
                        int prodEstoque = int.Parse(Console.ReadLine());
                        Console.Write("Valor: ");
                        double prodValor = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        prodList.Add(new Produto(prodId, prodNome, prodEstoque, prodValor));
                    }

                    Console.Write("Gostaria de continuar?(Y or N) ");
                    respTest = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

            }

            else if (exec == 'r' || exec == 'R') // Linha comando "Remover Valor"
            {
                respTest = 'y';
                while (respTest == 'y' || respTest == 'Y')
                {
                    Console.Write("Digite a ID do Produto: ");
                    int prodRemove = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Produto listRemove = prodList.Find(var => var.ID == prodRemove);

                    if (listRemove != null)
                    {
                        Console.WriteLine(listRemove);
                        Console.WriteLine();
                        Console.Write("Confirmar remoção?(Y or N): ");
                        respTest = char.Parse(Console.ReadLine());
                        if (respTest == 'y' || respTest == 'Y')
                        {
                            Console.WriteLine("Produto Deletado");
                            prodList.Remove(listRemove);
                        }

                        Console.WriteLine();
                        Console.Write("Gostaria de ver a Lista de porodutos?(Y or N): ");
                        respTest = char.Parse(Console.ReadLine());

                        if (respTest == 'y' || respTest == 'Y')
                        {
                            foreach (Produto item in prodList)
                            {
                                Console.WriteLine();
                                Console.WriteLine(item);
                                Console.WriteLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Código de Produto Inválido");
                    }

                    Console.Write("Gostaria de continuar?(Y or N) ");
                    respTest = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            else if (exec == 'v' || exec == 'V') // Linha comando "Alterar Valor"
            {
                respTest = 'y';
                while (respTest == 'y' || respTest == 'Y')
                {
                    Console.WriteLine("Alteração de Valor");
                    Console.WriteLine();
                    Console.Write("Qual a ID do Produto? ");
                    int prodBusca = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Produto resultBusca = prodList.Find(var => var.ID == prodBusca);
                    if (resultBusca != null)
                    {
                        Console.Write("Digite a Alteração de preço: ");
                        int altValor = int.Parse(Console.ReadLine());
                        resultBusca.AlterarValor(altValor);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Produto Invalido");
                    }

                    Console.Write("Gostaria de continuar?(Y or N) ");
                    respTest = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            else if (exec == 'e' || exec == 'V') // Linha comando "Alterar Estoque"
            {
                respTest = 'y';
                while (respTest == 'y' || respTest == 'Y')
                {
                    Console.WriteLine("Alteração de estoque");
                    Console.WriteLine();
                    Console.Write("Qual a Id do Produto? ");
                    int prodBusca = int.Parse(Console.ReadLine());

                    Produto resultBusca = prodList.Find(var => var.ID == prodBusca);

                    if (resultBusca != null)
                    {
                        Console.Write("Digite a Alteração do estoque");
                        int valEstoque = int.Parse(Console.ReadLine());
                        resultBusca.AlterarEstoque(valEstoque);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("ID de produto inválida");
                    }

                    Console.Write("Gostaria de continuar?(Y or N) ");
                    respTest = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Comando Inválido");
            }

            Console.WriteLine();
            Console.Write("Gostaria de ver a Lista de porodutos?(Y or N): ");
            respTest = char.Parse(Console.ReadLine());

            if (respTest == 'y' || respTest == 'Y')
            {
                foreach (Produto item in prodList)
                {
                    Console.WriteLine();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }

        }
    }
}
