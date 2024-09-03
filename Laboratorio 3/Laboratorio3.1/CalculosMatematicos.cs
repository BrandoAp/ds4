using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3._1
{
    public class CalculosMatematicos
    {
        public int Calcular(int a, int b)
        {
            int calculo;
            calculo = (a + b) * (a - b);
            return calculo;
        }

        public float calculoArea(float r)
        {
            float area;
            float PI = (float)Math.PI;
            area = PI * r * r;
            return area;
        }

        public float CalcularPerimetro(float alto, float ancho)
        {
            float perimetro;
            perimetro = (float)alto*2 + ancho*2;
            return perimetro;
        }
    }
}
