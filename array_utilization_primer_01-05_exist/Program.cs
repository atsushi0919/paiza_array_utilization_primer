﻿using System;
using System.Linq;

namespace array_utilization_primer_01_05_exist
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(array.Contains(k) ? "Yes" : "No");
        }
    }
}