using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Lab4_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la nota del estudiante");
            float score = float.Parse(Console.ReadLine());

            if (score == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota  es {score} ha aprovado");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score} ha reprovado, debe repetir");
            }
        }
    }
}
