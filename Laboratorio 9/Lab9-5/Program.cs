using Lab9_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        // Generar un arreglo de números no repetidos
        int min = 1;
        int max = 20;
        int cantidad = 10;

        try
        {
            int[] arregloNoRepetidos = aleatorios.GenerarArregloNoRepetidos(min, max, cantidad);
            Console.WriteLine("Arreglo de números aleatorios no repetidos: " + string.Join(", ", arregloNoRepetidos));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}