using System;

namespace Proj17___Membros_Estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o  Valor do Raio: ");

            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);

            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2")}");
            Console.WriteLine($"Volume: {volume.ToString("F2")}");
            Console.WriteLine($"Valor de PI : {Calculadora.pi.ToString("F2")}");
        }
    }
}
