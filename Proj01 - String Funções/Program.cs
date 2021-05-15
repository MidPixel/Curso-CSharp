using System;

namespace Proj01___String_Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";

            //Todas as Letras para Maiusculo
            string s1 = original.ToUpper();

            //Todas as Letras para Minusculo
            string s2 = original.ToLower();

            //Remove os espaços em branco no inicio e no fim
            string s3 = original.Trim();

            //Indica qual a primeira posição do Parametro buscado
            int n1 = original.IndexOf("bc");

            //Indica qual a ultima posição do Parametro buscado
            int n2 = original.LastIndexOf("bc");

            //Mantem Itens a partir da posição determinada
            string s4 = original.Substring(3);

            //Mantem caracteres a partir da posição determinada, apontando quantos caracteres depois
            string s5 = original.Substring(3, 5);

            //Troca Caracteres especificos
            string s6 = original.Replace('a', 'x');

            //Troca Parte da String
            string s7 = original.Replace("abc", "xy");

            //Testa se a String for Nula ou Vazia
            bool b1 = String.IsNullOrEmpty(original);

            //Testa se a String é Nula ou se está em branco
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
