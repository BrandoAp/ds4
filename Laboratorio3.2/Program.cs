using Laboratorio_3._1;
internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos calculos = new CalculosMatematicos();

        float radio;

        Console.WriteLine("Por favor ingrese el Radio del Circulo");
        radio = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine(calculos.calculoArea(radio));
    }
}