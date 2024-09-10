using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Lab4_2
    {
            static void Main(string[] args)
        {
            int fac = 1, n;
            string linea;
            Console.WriteLine("Ingrese un numero entero");
            linea = Console.ReadLine();
            n = int .Parse(linea);
            for (int i = 0; i < n; i++)
            {
                fac++;
            }
            Console.WriteLine("La factorial es: " + fac);
            Console.ReadKey();
        }
    }
}
