

namespace Proj03___Params
{
    class Calculator
    {
        public static int Soma(params int[] numbers) // O Params avisa para a função, que vc quer receber uma quantia variavel de valores
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
