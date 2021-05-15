

namespace Proj21___This
{
    class Produto
    {
        public string Nome; //Atributo de Classe
        public double Preco;
        public int Estoque;

        public Produto() //Construtor padrão da Classe
        {
            Estoque = 0; //Construtor padrão já determina um valor para um Atributo de classe
        }

        public Produto(string Nome, double Preco, int Estoque) // Variavel do Construtor
        {
            this.Nome = Nome;   //This é usado para apontar um atributo dentro de uma variavel local de um contrutor
            this.Preco = Preco; // quando os dois tem o mesmo nome de variavel
            this.Estoque = Estoque;
        }

        public Produto(string nome, double preco) : this()  //o comando This é usado tbm para referenciar outro contrutor em um contrutor
        {                                                   // como se falasse "use tambem o Contrutor X"
            Nome = nome;
            Preco = preco;
        }

        /*public Produto(string Nome, double Preco, int Estoque) : this(nome, preco)
        {
            Estoque = 0; 
        }*/

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