using System;
using System.Text;
using System.Collections.Generic;
namespace LW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите 1-е число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3-е число: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == -b || a == -c || b == -c)
            {
                Console.WriteLine("Пара противоположных чисел существует");
            }
            else
                Console.WriteLine("Пары противоположных чисел нет");
            Console.ReadKey();
        }
    }
}
