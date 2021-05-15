using System;

namespace Proj01___DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data01 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local); //Instanciando uma data como data Local

            DateTime data02 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);   //Instanciando uma data como data Universal

            DateTime data03 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine($"Data 01: {data01}");
            Console.WriteLine($"Data 01 Kind: {data01.Kind}");              //Mostra a Localização
            Console.WriteLine($"Data01 Local: {data01.ToLocalTime()}");     //Converte para data Local
            Console.WriteLine($"Data01 Local: {data01.ToUniversalTime()}"); //Converte para data universal
            Console.WriteLine();
            Console.WriteLine($"Data 01: {data02}");
            Console.WriteLine($"Data 01 Kind: {data02.Kind}");              //Mostra a Localização
            Console.WriteLine($"Data01 Local: {data02.ToLocalTime()}");     //Converte para data Local
            Console.WriteLine($"Data01 Local: {data02.ToUniversalTime()}"); //Converte para data universal
            Console.WriteLine();
            Console.WriteLine($"Data 01: {data03}");
            Console.WriteLine($"Data 01 Kind: {data03.Kind}");              //Mostra a Localização
            Console.WriteLine($"Data01 Local: {data03.ToLocalTime()}");     //Converte para data Local
            Console.WriteLine($"Data01 Local: {data03.ToUniversalTime()}"); //Converte para data universal

            /*  -=Padrão ISO 8601=-
            
            Formato:
            yyyy-MM-ddTHH:mm:ssZ
            Z indica que a data/hora está em Utc
            */

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));                     // Jeito errado de Converter
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));   // Jeito certo de Converter
        }
    }
}
