using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_3
{
    class calcularArea
    {
        private double lado1, lado2, lado3;

        public calcularArea(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public double calcularA()
        {
            calcularSemiperimetro calcular = new calcularSemiperimetro(lado1, lado2, lado3);
            double area;
            double semiP = calcular.calcularSemip();
            area = Math.Sqrt(semiP * (semiP - lado1) * (semiP - lado2) * (semiP - lado3)); //formula de Heron
            return area;
        }
    }

}
