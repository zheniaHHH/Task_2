﻿using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Введіть змінну типу int ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть змінну типу double ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть змінну типу long ");
            long c = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"a={a}; b={b} ; c={c}");
            

        }   
    }
}
