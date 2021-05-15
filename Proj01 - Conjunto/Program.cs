using System;
using System.Collections.Generic; //O Conjunto utiliza a mesma Biblioteca que a Lista

namespace Proj01___Conjunto
        // Conjuntos njão aceitam repetições de Elementos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> conj01 = new HashSet<int>(); //forma de intanciar um conjunto

            HashSet<int> conj02 = new HashSet<int>();

            conj01.Add(3);
            conj01.Add(5);
            conj01.Add(8);
            conj01.Add(9);

            conj02.Add(3);
            conj02.Add(4);
            conj02.Add(5);

            foreach (int itemVar in conj01)  //Só é possivel imprimir os itens de um conjunto usando o ForEach
            {
                Console.WriteLine(itemVar);
            }

            foreach (int itemVar in conj02)
            {
                Console.WriteLine(itemVar);
            }

            Console.WriteLine("Digite um valor inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (conj02.Contains(num)) //teste usado para saber se o Conjunto contem ou não o valor pesquisado
            {
                Console.WriteLine($"{num} pertence ao Conjunto 02");
            }
            else
            {
                Console.WriteLine($"{num} não pertence ao Conjunto 02");
            }

            conj02.Remove(4); //usado para remover algum elemento do conjunto

            conj01.ExceptWith(conj02); // usado para remover os elemento de um conjunto existentes em outro

            conj01.UnionWith(conj02); //usado para unir os elementos de um conjunto em outro

            conj01.IntersectWith(conj02); // usado para saver quais são os elementos iguais entre conjuntos
        }
    }
}
