

namespace Exerc01___List
{
    class Registro
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Registro(int idCod, string nomeFunc, double funcSalario)
        {
            ID = idCod;
            Nome = nomeFunc;
            Salario = funcSalario;
        }

        public void AumentoSalario(int percent)
        {
            Salario += Salario * (percent / 100.0);

        }
    

        public override string ToString()
        {
            return ID + ", " + Nome + ", " + Salario.ToString("F2");
        }
    }

    
}
