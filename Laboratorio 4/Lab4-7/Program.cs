﻿class Program
{
    private static void Main(string[] args)
    {
        int numeroUno = 70;
        double numeroDos = 67.89;
        double numeroTres = 67.89;

        Console.WriteLine(suma(numeroUno, numeroDos));

        Console.WriteLine(suma(numeroUno, numeroDos, numeroTres));
    }

    static double suma(int x, double y, double z = 0) 
    {
        return x + y + z;
    }
}