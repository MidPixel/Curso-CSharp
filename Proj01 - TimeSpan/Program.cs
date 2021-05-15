using System;

namespace Proj01___TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30); //Hora, Minuto, Segundo
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            //Construtores
            TimeSpan ts01 = new TimeSpan();                 //Vazio
            TimeSpan ts02 = new TimeSpan(900000000L);       //Ticks
            TimeSpan ts03 = new TimeSpan(2, 11, 21);        //Hora, Minuto, Segundo
            TimeSpan ts04 = new TimeSpan(1, 2, 11, 21);     //Dia, Hora, Minuto, Segundo
            TimeSpan ts05 = new TimeSpan(1, 2, 11, 21, 321);//Dia, Hora, Minuto, Segundo, Milisegundo
            Console.WriteLine(ts01);
            Console.WriteLine(ts02);
            Console.WriteLine(ts03);
            Console.WriteLine(ts04);
            Console.WriteLine(ts05);

            TimeSpan time01 = TimeSpan.FromDays(1.5);
            TimeSpan time02 = TimeSpan.FromHours(1.5);
            TimeSpan time03 = TimeSpan.FromMinutes(1.5);
            TimeSpan time04 = TimeSpan.FromSeconds(1.5);
            TimeSpan time05 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan time06 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(time01);
            Console.WriteLine(time02);
            Console.WriteLine(time03);
            Console.WriteLine(time04);
            Console.WriteLine(time05);
            Console.WriteLine(time06);
        }
    }
}
