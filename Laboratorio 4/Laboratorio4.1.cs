using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            string linea;
            Console.WriteLine("Ingrese un valor N:");

            linea = Console.ReadLine();
            n = int.Parse(linea);
            x = 1; 
            while (x <= n) { 
                Console.WriteLine(x);
                Console.WriteLine(" , ");
                x++;
            }
            Console.ReadKey();
        }
    }
}
