using System;

namespace Proj01___ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Alex", "Bob" }; //Iniciar um vetor de String com valores pré determinados

            //Forma usada com o o Laço FOR

            for (int i = 0; i < vetor.Length; i++) //O Comando "vetor.Length" aponta para o tamanho do vetor sem precisar determinar um valor
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("--------------------------------------------------------------------");

            //Forma Utilizando o FOREACH

            foreach (string s in vetor) // O foreach tabalha com (var item in collection)
            {
                Console.WriteLine(s);
            }
        }
    }
}
