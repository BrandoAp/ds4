using System;

internal class Program
{
    private static void Main()
    {
        decimal precio;
        string formaDePago;
        string numeroDeCuenta = string.Empty;

        // Pedir el precio del producto
        while (true)
        {
            Console.Write("Ingrese el precio del producto (valor positivo): ");
            if (decimal.TryParse(Console.ReadLine(), out precio) && precio > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un valor positivo válido.");
            }
        }

        // Pedir la forma de pago
        while (true)
        {
            Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
            formaDePago = Console.ReadLine()?.ToLower();
            if (formaDePago == "efectivo" || formaDePago == "tarjeta")
            {
                break;
            }
            else
            {
                Console.WriteLine("Forma de pago inválida. Debe ser 'efectivo' o 'tarjeta'.");
            }
        }

        // Si la forma de pago es tarjeta, pedir el número de cuenta
        if (formaDePago == "tarjeta")
        {
            while (true)
            {
                Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                numeroDeCuenta = Console.ReadLine() ?? string.Empty;
                if (numeroDeCuenta.Length == 16 && long.TryParse(numeroDeCuenta, out _))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Número de cuenta inválido. Debe tener 16 dígitos.");
                }
            }
        }

        // Mostrar informe de la transacción
        Console.WriteLine("\nInforme de la transaccion:");
        Console.WriteLine($"Precio del producto: {precio:c}");
        Console.WriteLine($"Forma de pago: {formaDePago}");
    }
}
