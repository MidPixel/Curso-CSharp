using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj15___Metodos
{
    class Triangulo
    {
        public double CatetoVertical;
        public double CatetoHorizontal;
        public double Hipotenusa;

        public double Area() //criar o metodo dentro da propria classe
        {
            double p = (CatetoVertical + CatetoHorizontal + Hipotenusa) / 2;
            double result = Math.Sqrt((p + CatetoVertical) * (p + CatetoHorizontal) * (p + Hipotenusa));

            return result;
        }
    }
}
