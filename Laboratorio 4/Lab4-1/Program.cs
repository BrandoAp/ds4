﻿class Program
{
    private static void Main(string[] args)
    {
        int n, x;
        string linea;
        Console.WriteLine("Ingrese el valor de n");
        linea = Console.ReadLine();
        n = int.Parse(linea);
        x = 1;
        while (x <= n) {
            Console.WriteLine(x);
            Console.WriteLine(" , ");
            x++;
        }
    }
}