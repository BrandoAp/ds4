internal class Program
{
    private static void Main(string[] args)
    {
        Matriz matriz = new Matriz();
        matriz.Ingresar();
        matriz.Imprimir();
    }
}

class Matriz
{
    private int[,] mat;

    public void Ingresar()
    {
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.WriteLine("Ingrese posicion [" + (f + 1) + ", " + (c + 1) + "]");
                string linea;
                linea = Console.ReadLine();
                mat[f, c] = int.Parse(linea);
            }
        }
    }

    public void Imprimir()
    {
        for (int f = 0; f < 3; f++)
        {
            for(int c = 0; c < 4; c++)
            {
                Console.WriteLine(mat[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}