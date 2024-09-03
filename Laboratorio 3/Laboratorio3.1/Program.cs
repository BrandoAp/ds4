using Laboratorio_3._1;

internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos calculos = new CalculosMatematicos();
        int a, b;


        Console.WriteLine("Ingrese el numero A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el numero B: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(calculos.Calcular(a, b));

    }
}