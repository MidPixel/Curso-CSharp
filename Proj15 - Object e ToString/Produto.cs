using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj16___Object_e_ToString
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public double ValorTotalEmEstoque()
        {
            double total = Estoque * Preco;

            return total;
        }

        public void AdicionarProdutos(int quantidade) //Criada a função para receber o valor indicado
        {
            Estoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Estoque -= quantidade;
        }

        public override string ToString() //Comando de sobrepossição
        {
            return Nome + ", R$" + Preco + ", " + Estoque + " unidades, Total: R$" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}