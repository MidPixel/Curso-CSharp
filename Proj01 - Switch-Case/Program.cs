using System;

namespace Proj01___Switch_Case
{
    class Program
    {
        /*  Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste 
            do valor de uma variável.
         * Sintaxe
        
        var minhaVariavel = (...);

        switch (minhaVariavel) {
            case 1:
                Console.WriteLine("Caso 1");
                break;
            case 2:
                Console.WriteLine("Caso 2");
                break;
            default:
                Console.WriteLine("Caso padrão");
                break;
        }
        */

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);


        }

    }
}
