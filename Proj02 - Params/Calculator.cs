

namespace Proj02___Params
{
    class Calculator
    {
        public static int Soma(int[] numbers)
        {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                soma += numbers[i];
            }
            return soma;
        }
    }
}
