﻿using System;

namespace PrintFibonacciNumbersInOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            printFibonacciNumbers(10);
        }

        public static void printFibonacciNumbers(int n)
        {
            int f1 = 0, f2 = 1, i;

            if (n < 1)
                return;

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(f2 + " ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
                
        }
    }
}
