

namespace Proj24___Auto_Properties
{
    /*Properties autoimplementadas
     
     É uma forma simplificada de se declarar propriedades que não 
     necessitam lógicas particulares para as operações get e set.
    */

    class Produto
    {
        private string _nome;
        public double Preco { get; private set; } //Auto Propertie caso não precise de Lógica propria
        public int Estoque { get; private set; };

        public Produto(string nome, double preco, int estoque)
        {
            _nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        //Propertier para Lógica customizada
        public string Nome
        {
            get 
            {
                return _nome; 
            }

            set 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome + ", R$" + Preco + ", " + Estoque + " unidades, Total: R$" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
