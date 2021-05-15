using System;
using System.Collections.Generic;

namespace Exerc01___List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas pessoas serão resgistradas? ");
            int contRegister = int.Parse(Console.ReadLine());

            List<Registro> Funcionarios = new List<Registro>();

            for (int reg = 0; reg < contRegister; reg++)
            {
                Console.WriteLine($"Registro #{reg + 1}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                Funcionarios.Add(new Registro(id, nome, salario));

                Console.WriteLine();
            }

            foreach (Registro cadastro in Funcionarios)
            {
                Console.WriteLine(cadastro);
            }

            Console.Write("Entre com o numero de Registro para alterar o Salario: ");
            int registerNum = int.Parse(Console.ReadLine());

            Registro test = Funcionarios.Find(x => x.ID == registerNum);
            if (test != null)
            {
                Console.Write("Digite a Porcentagem: ");
                int Porcentagem = int.Parse(Console.ReadLine());
                test.AumentoSalario(Porcentagem);

            }
            else
            {
                Console.WriteLine("Registro invalido");  
            }

            Console.WriteLine();
            Console.WriteLine("Cadastros atualizados");
            foreach (Registro cadastro in Funcionarios)
            {
                Console.WriteLine(cadastro);
            }
        }
    }
}
