using System;

//Jeito Certo

namespace Proj02___Ref_e_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a); // o parametro REF é usado para fazer uma referencia de entrada/ligação entre a função e a Classe


            Console.WriteLine(a);

            int triple;

            //O modificador OUT é similar ao REF (faz o parâmentro ser uma referência para a variável original), mas não exige que a variável original seja iniciada.

            Calculator.Triple(a, out triple); //o Parâmetro OUT fazendo referência para uma variável não iniciada

            Console.WriteLine(triple);

            //NOTA: ambos são considerados "code smells" (designer ruim) e devem ser evitados.
        }
    }
}
