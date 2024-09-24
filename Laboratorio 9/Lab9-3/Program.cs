using System;

internal class Program
{
    private static void Main()
    {
        Console.Write("Ingrese el primer lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Verificar si puede formar un triángulo
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Los lados no forman un triángulo.");
        }
    }
}
