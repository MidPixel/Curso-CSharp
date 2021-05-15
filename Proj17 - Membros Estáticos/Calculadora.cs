

namespace Proj17___Membros_Estáticos
{
    class Calculadora
    {
        public static double pi = 3.14; // Acresentado o Prefixo "STATIC" para poder chamar os membros sem a necesidade de instanciar um Objeto

        public static double Circunferencia(double r)
        {
            return 2.0 * pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * r * r * r;
        }

    }
}
