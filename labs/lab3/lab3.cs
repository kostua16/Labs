using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int tr = 0;
            Console.WriteLine("Количество троек чисел »");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите a »");int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите b »");int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите c »");int c = int.Parse(Console.ReadLine());
                if (c >= a + b)
                {
                    Console.WriteLine("Правильная размерность сторон треугольника");tr++;
                }
                else
                {
                    Console.WriteLine("НЕПРАВИЛЬНАЯ размерность сторон треугольника");
                }
            }
             Console.WriteLine("Количество подходящих для построения сторон треугольника троек »» " + tr);
             int fl = n - tr;
             Console.WriteLine("Количество не подходящих »» " + fl);
             Console.ReadKey(true);
        }
    }
}
