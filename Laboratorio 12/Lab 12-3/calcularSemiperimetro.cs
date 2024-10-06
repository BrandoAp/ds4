using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_3
{
    class calcularSemiperimetro
    {
        private double lado1, lado2, lado3;

        public calcularSemiperimetro(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public double calcularSemip()
        {
            return (lado1 + lado2 + lado3) / 2;  
        }
    }
}
