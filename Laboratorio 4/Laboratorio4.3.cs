using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Lab4_3
    {
        static void Main(String[] arga)
        {
            int suma, cant, valor, promedio;
            string linea;
            suma = 0;
            cant = 0;
            do
            {
                Console.WriteLine("Ingrese un numero (0 para finalizar): ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != 0)
                {
                    suma = suma + valor;
                    cant++;
                }
            } while (valor != 0);
            if(cant != 0)
            {
                promedio = suma / cant;
                Console.WriteLine("El promedio de los valores ingresados es: ");
                Console.WriteLine(promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron valores");
            }
            Console.ReadKey();
        } 
    }
}
