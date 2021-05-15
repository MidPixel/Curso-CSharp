

namespace Proj18___Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public Produto(string nome, double preco, int estoque) // Construtor
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }


        public double ValorTotalEmEstoque()
        {
            double total = Estoque * Preco;

            return total;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Estoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Estoque -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", R$" + Preco + ", " + Estoque + " unidades, Total: R$" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}