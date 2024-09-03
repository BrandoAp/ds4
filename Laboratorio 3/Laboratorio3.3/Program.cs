using Laboratorio_3._1;

internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos calculos = new CalculosMatematicos();
        float ancho, alto;

        Console.WriteLine("Ingrese los 4 lados del triangulo");
        ancho = Convert.ToSingle(Console.ReadLine());
        alto = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine(calculos.CalcularPerimetro(ancho, alto));
    }
}
