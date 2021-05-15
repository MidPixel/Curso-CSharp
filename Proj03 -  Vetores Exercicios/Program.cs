using System;

namespace Proj03____Vetores_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas pessoas irão se Hospedar?: ");
            int hospedagem = int.Parse(Console.ReadLine());

            Quartos[] list = new Quartos[10];

            for (int i = 0; i < hospedagem; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                list[quarto] = new Quartos(nome, email);
            }

            int reg = 1;

            for (int i = 0; i < 10; i++)
            {
                
                if (list[i] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Registro: {reg}\r\nNome: {list[i].Nome}\r\nEmail: {list[i].Email}\r\nQuarto: {i}");
                    reg++;
                }
                
            }
        }
    }
}
