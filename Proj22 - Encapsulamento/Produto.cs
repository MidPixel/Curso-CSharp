

namespace Proj22___Encapsulamento
{
    class Produto
    {
        //Por convenção, quando um atributo é determinado como "Private" o nome do atributo deve começar com "_"
        private string _nome;
        private double _preco;
        private int _estoque; //Mudando o Atributo para Private, ele fica inacessivel fora da classe

        public Produto(string nome, double preco, int estoque) 
        {
            _nome = nome;
            _preco = preco;
            _estoque = estoque;
        }

        //Método Get criado para Obter o Nome do produto
        public string GetNome() //Método criado com "public string" obrigatóriamente retorna o Nome do produto
        {
            return _nome;
        }

        //Método Set criado para alterar ou determinar o nome do Produto
        public void SetNome(string nome) //Método com void, não retorna nada para o programa principal
        {
            _nome = nome;
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
