using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_4
{
    public class Aleatorios
    {
        private Random random;
        public Aleatorios() { 
            random = new Random();
        }

        public int NumerosAleatorios(int min, int max)
        {
            return random.Next(min, max);
        }


        public int[] GenerarArreglo(int min, int max, int cantidad)
        {
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = NumerosAleatorios(min, max);
            }
            return arreglo;
        }

        public int[] GenerarArregloNoRepetidos(int min, int max, int cantidad)
        {
            // Verificar si la cantidad solicitada excede el rango disponible de números
            if (cantidad > (max - min + 1))
            {
                throw new ArgumentException("La cantidad solicitada excede el rango disponible de números.");
            }

            int[] arreglo = new int[cantidad];
            bool[] utilizados = new bool[max - min + 1]; // Array para marcar números utilizados
            int count = 0;

            // Generar números únicos hasta alcanzar la cantidad deseada
            while (count < cantidad)
            {
                int numero = NumerosAleatorios(min, max); // Generar un número aleatorio
                int index = numero - min; // Ajustar el índice para el array 'utilizados'

                // Comprobar si el número ya ha sido utilizado
                if (!utilizados[index])
                {
                    utilizados[index] = true; // Marcar como utilizado
                    arreglo[count] = numero; // Agregar el número al arreglo
                    count++; // Incrementar el contador
                }
            }

            return arreglo; // Retornar el arreglo con números únicos
        }


    }

}
