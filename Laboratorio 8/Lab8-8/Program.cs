internal class Program
{
    private static void Main(string[] args)
    {
        ClaseConcretaa1 concreta1 = new ClaseConcretaa1();
        concreta1.printOut();
        Console.WriteLine(concreta1.prefixValor("ES_"));

        ClaseConcreta2 concreta2 = new ClaseConcreta2();
        concreta2.printOut();
        Console.WriteLine(concreta2.prefixValor("ES_"));
    }
}