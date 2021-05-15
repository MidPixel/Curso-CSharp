using System;
using System.Collections.Generic;

namespace Proj02___List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista01 = new List<string>();

            lista01.Add("Maria"); // Adicionando Variáveis ao final da Lista
            lista01.Add("Alex");
            lista01.Add("Bob");
            lista01.Add("Ana");

            lista01.Insert(2, "Marco"); // Adiciona a Variável determinando a posição da Lista

            foreach (string name in lista01)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(lista01.Count); // Mostra Quantos elementos a Lista tem

            string busca01 = lista01.Find(Teste); // Pode receber como Argumento uma função que exercuta um teste
            Console.WriteLine($" Primeiro com 'A': {busca01}");

            // Usado para procurar o primero item, segundo a condição.
            string busca02 = lista01.Find(x => x[0] == 'B'); // Pode receber como Argumento uma expressão Lambda
            // "dado a String X quero a condição que o Primeiro Caracter de X seja Igual a 'A'"
            Console.WriteLine($" Primeiro com 'B': {busca02}");

            // Usado para procurar o primero item, segundo a condição.
            string busca03 = lista01.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Ultimo com 'A': {busca02}");

            // Usado para apontar a posição na Lista
            int position01 = lista01.FindIndex(x => x[0] == 'A'); // Primeira posição baseado no teste
            Console.WriteLine($"Primeira posição com 'A': {position01}");

            int position02 = lista01.FindLastIndex(x => x[0] == 'A'); // Ultima posição baseado no teste
            Console.WriteLine($"Ultima posição com 'A': {position01}");

            //Usado para Filtrar da Lista Principal
            List<string> listaResult = lista01.FindAll(y => y.Length == 5); // comando para filtrar colocando numa nova lista baseado no resultado do teste Lambda
            // "Todas as string tal que o tamanho seja igual a 5"

            Console.WriteLine("---------------------------");

            foreach (string nome in listaResult)
            {
                Console.WriteLine(nome);
            }

            //Usado para remover da Lista
            lista01.RemoveAt(3); //usado para remover de uma posição determinada
            foreach (string name in lista01)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            lista01.Remove("Alex"); //usado para remover um item determinado
            foreach (string name in lista01)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            lista01.RemoveAll(z => z[0] == 'B'); //Remove Baseado no resultado do teste de predicado
            foreach (string name in lista01)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            lista01.RemoveRange(2, 2); // Usado para remover paramentros de alcance
            // "A partir da posição 2, remover duas posições"
            foreach (string name in lista01)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

        }
        static bool Teste(string busca) // Função para Buscar dentro da lista
        {
            return busca[0] == 'A';
        }
    }
}
