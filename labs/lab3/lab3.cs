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
            Console.WriteLine("���������� ����� ����� �");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("������� a �");int a = int.Parse(Console.ReadLine());
                Console.WriteLine("������� b �");int b = int.Parse(Console.ReadLine());
                Console.WriteLine("������� c �");int c = int.Parse(Console.ReadLine());
                if (c >= a + b)
                {
                    Console.WriteLine("���������� ����������� ������ ������������");tr++;
                }
                else
                {
                    Console.WriteLine("������������ ����������� ������ ������������");
                }
            }
             Console.WriteLine("���������� ���������� ��� ���������� ������ ������������ ����� �� " + tr);
             int fl = n - tr;
             Console.WriteLine("���������� �� ���������� �� " + fl);
             Console.ReadKey(true);
        }
    }
}
