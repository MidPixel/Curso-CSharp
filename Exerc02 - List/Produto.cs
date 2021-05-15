using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02___List
{
    class Produto
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public int Estoque { get; private set; }
        public double Valor { get; private set; }

        public Produto(int prodID, string prodNome, int prodEstoque, double prodValor)
        {
            ID = prodID;
            Nome = prodNome;
            Estoque = prodEstoque;
            Valor = prodValor;
        }

        public void AlterarValor(int percent)
        {
            Valor += Valor * (percent / 100);
        }

        public void AlterarEstoque(int valEstoque)
        {
            Estoque += valEstoque;        
        }

        public override string ToString()
        {
            return
                "ID:" + ID +
                "\r\nNome: " + Nome +
                "\r\nEstoque: " + Estoque +
                "\r\nValor: " + Valor.ToString("F2");
        }
    }


}
