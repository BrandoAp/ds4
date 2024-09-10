using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Lab4_6
    {
        static void Main (String[] args)
        {
            Console.WriteLine("Digite el radio del circulo");
            double radio = double.Parse (Console.ReadLine());
            double area = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine($"El area del circuito es: {area}");
        }
    }
}
