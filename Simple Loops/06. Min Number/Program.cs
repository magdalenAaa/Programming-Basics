﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minNumber = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int currentNumbers = int.Parse(Console.ReadLine());
            if (minNumber < currentNumbers)
            {
                minNumber = currentNumbers;
            }
            Console.WriteLine(currentNumbers);
        }
    }
}

