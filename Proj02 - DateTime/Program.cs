using System;

namespace Proj02___DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dia01 = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(dia01);

            Console.WriteLine("1) Date: " + dia01.Date);
            Console.WriteLine("2) Day: " + dia01.Day);
            Console.WriteLine("3) DayOfWeek: " + dia01.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + dia01.DayOfYear);
            Console.WriteLine("5) Hour: " + dia01.Hour);
            Console.WriteLine("6) Kind: " + dia01.Kind);
            Console.WriteLine("7) Millisecond: " + dia01.Millisecond);
            Console.WriteLine("8) Minute: " + dia01.Minute);
            Console.WriteLine("9) Month: " + dia01.Month);
            Console.WriteLine("10) Second: " + dia01.Second);
            Console.WriteLine("11) Ticks: " + dia01.Ticks);
            Console.WriteLine("12) TimeOfDay: " + dia01.TimeOfDay);
            Console.WriteLine("13) Year: " + dia01.Year);

            string s1 = dia01.ToLongDateString();
            string s2 = dia01.ToLongTimeString();
            string s3 = dia01.ToShortDateString();
            string s4 = dia01.ToShortTimeString();
            string s5 = dia01.ToString();
            string s6 = dia01.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = dia01.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            
            DateTime y2 = x.AddDays(2.3);       //Double
            DateTime y3 = x.AddHours(2);        //Double
            DateTime y4 = x.AddMilliseconds(4); //Double
            DateTime y5 = x.AddMinutes(3);      //Double
            DateTime y6 = x.AddMonths(1);       //int
            DateTime y7 = x.AddSeconds(2.6);    //Double
            DateTime y8 = x.AddTicks(2);        //Long
            DateTime y9 = x.AddYears(12);       //int
            TimeSpan t = x.Subtract(dia01);     //Datetime
            DateTime y10 = x.Subtract(t);       //TimeSpan
            DateTime y1 = x.Add(t);             //TimeSpan

        }
    }
}
