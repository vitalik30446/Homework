using System;
using System.Text;
using System.Collections.Generic;
namespace LW1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4;
            double b = 3;
            Console.Write("Введите значение r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write($" r={r} ");
            double pi = 3.14;
            Console.Write($" pi={pi} ");
            double S = 4 * (pi * r * r);
            Console.Write($" S={S} ");
            double V = a / b * (pi * r * r * r);
            Console.Write($" V={V} ");
        }
    }
} 
