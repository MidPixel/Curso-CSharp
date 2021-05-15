using System;

namespace Proj11___Estrutura_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um Numero: ");
            double num = double.Parse(Console.ReadLine());

            while (num >= 0.0) //O laço só encerra quando o resultado do teste for Falso
            {
                double raiz = Math.Sqrt(num);
                Console.WriteLine(raiz.ToString("F3"));
                Console.Write("Digite outro Numero: ");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numero Negativo");
        }
    }
}
