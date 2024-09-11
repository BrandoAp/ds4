internal class Program
{
    private static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.cargar();
        pv.imprimir();
    }
}

class PruebaVector1
{
    private int[] sueldos;

    public void cargar()
    {
        sueldos = new int[6];
        for (int f = 1; f < 5; f++)
        {
            Console.WriteLine("Ingrese sueldo del operario" + f + ": ");
            String linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }
    public void imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios: \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.WriteLine("[" + sueldos[f] + "]");
        }
        Console.ReadKey();
    }
}