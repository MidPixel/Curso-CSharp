

namespace Proj23___Properties
{
    /*Properties
      São definições de métodos encapsulados, porém expondo uma 
      sintaxe similar à de atributos e não de métodos
    */
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _estoque;

        public Produto(string nome, double preco, int estoque)
        {
            _nome = nome;
            _preco = preco;
            _estoque = estoque;
        }

        //Propertier SImplifica o comando Get Set colocandoos dentro de um unico método
        public string Nome
        {
            get 
            {
                return _nome; 
            }

            set //O Set não tem mais um Parâmetro de entrada "SetNome(String nome)" 
            {
                if (value != null && value.Length > 1) //Usando "Value" como parâmetro de entrada padrão do Método
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            double total = _estoque * _preco;

            return total;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _estoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _estoque -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", R$" + _preco + ", " + _estoque + " unidades, Total: R$" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
