using System;

namespace Proj04___Operadores_Atribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            Console.WriteLine(A);

            A += 2;
            Console.WriteLine(A);
            // adiciona o valor a variavel existente
                   
            A -= 1;
            Console.WriteLine(A);
            // Subitrai o valor a variavel existente
                        
            A *= 2;
            Console.WriteLine(A);
            // Multiplica o valor da variavel existente
                        
            int B = 0;
            B++;
            Console.WriteLine(B);
            // Atribui +1 a variavél
                        
            int C = 10;
            C--;
            Console.WriteLine(C);
            // Atribui -1 a variavél

            // Comando A++ é usado para Incrementar depois, já o comando ++A é usado para Incrementar antes
        }
    }
}
