﻿using System;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Números pares o divisibles entre 3 del 1 al 100:");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
