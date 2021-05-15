using System;

namespace Proj06___Entrada_de_Dados_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            /*Console.ReadLine é usado para receber informação digitada no console
            por padrão Console.ReadLine recebe apenas String */

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            /* Podemos simplificar o código

            string s = Console.ReadLine();
            string[] vetor = s.Split(' ');

            com

            string[] vetor = Console.ReadLine().Split(' '); */

            string s = Console.ReadLine();
            string[] vetor = s.Split(' ');

            string p1 = vetor[0];
            string p2 = vetor[1];
            string p3 = vetor[2];

            Console.WriteLine("você digitou");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //----------------------------------------------------------------

            /* Para converter os dados para o tipo desejado
             * é usado o comando "tipo.Parse()"
             * Ex: int n1 = int.Parse(Console.ReadLine());*/

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            //"tipo.Parse()" também pode ser usado dentro de um vetor
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine("você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
