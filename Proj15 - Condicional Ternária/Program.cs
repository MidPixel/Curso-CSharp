using System;

namespace Proj15___Condicional_Ternária
{
    class Program
    {
        /*Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma condição.
            
        Sintaxe:

        ( condição ) ? valor_se_verdadeiro : valor_se_falso

        */
        static void Main(string[] args)
        {
            double preco = 34.5;

            //Uma simplificação da Sintaxe If-Else
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
