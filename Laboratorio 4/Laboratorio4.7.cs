using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Lab4_7
    {
        static void Main(String[] args)
        {
            int numeroUno = 70;
            double numeroDos = 67.89;
            double numeroTres = 67.89;

            Console.WriteLine(Suma(numeroUno, numeroTres));
            Console.WriteLine(Suma(numeroUno, numeroDos, numeroTres));
        }
        static double Suma(int x, double y, double z = 10)
        {
            return x + y + z;
        }
    }
}
