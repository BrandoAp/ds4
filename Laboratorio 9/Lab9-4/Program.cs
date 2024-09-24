using Lab9_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        int numeroAleatorio = aleatorios.NumerosAleatorios(1,10);
        Console.WriteLine($"Número aleatorio: {numeroAleatorio}");

        int[] arregloAleatorio = aleatorios.GenerarArreglo(1, 10, 25);
        Console.WriteLine("Arreglo de números aleatorios: " + string.Join(", ", arregloAleatorio));
    }
}