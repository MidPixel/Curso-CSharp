using System;
using System.Globalization

namespace Proj01___DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builders Basicos
            DateTime agora = DateTime.Now; //Exibe o horario atual do Sistema
            DateTime hoje = DateTime.Today; //Exibe o dia Atual do SIstema
            DateTime gmt = DateTime.UtcNow; //Exibe o horario Global Atual

            Console.WriteLine(agora);
            Console.WriteLine(hoje);
            Console.WriteLine(gmt);

            //Construtores  e Sobrecargas do DateTime
            DateTime dia01 = new DateTime(2017, 05, 18);                    //Com a data    
            DateTime dia02 = new DateTime(2017, 05, 18, 20, 14, 03);        //Com a data e Hora
            DateTime dia03 = new DateTime(2017, 05, 18, 20, 14, 03, 300);   //Com a data, hora e Milisegundos

            Console.WriteLine(dia01);
            Console.WriteLine(dia02);
            Console.WriteLine(dia03);

            //Convertendo uma String para um formato data
            DateTime convert01 = DateTime.Parse("2000-08-15");
            DateTime convert02 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime convert03 = DateTime.Parse("15/08/2000");
            DateTime convert04 = DateTime.Parse("15/08/2000 13:05:08");

            Console.WriteLine(convert01);
            Console.WriteLine(convert02);
            Console.WriteLine(convert03);
            Console.WriteLine(convert04);

            //Converter com mascara de formatação
            DateTime convertExact01 = DateTime.ParseExact("2017-05-18", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime convertExact02 = DateTime.ParseExact("15/08/2021 15:03:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(convertExact01);
            Console.WriteLine(convertExact02);

        }
    }
}
