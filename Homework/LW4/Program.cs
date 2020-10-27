using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace LW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, max = 0, coord_min = 0, min, coord_max = 0, tmp = 0;
            Random r = new Random();
            int[] mas = new int [n];
            for (int i = 0; i < n; i++)
                mas[i] = r.Next(0,100);
 
            min = mas[0];
            for (int i = 0; i < n; i++)
                Console.Write(mas[i]+ " ");
            for (int i = 0; i < n; i++)
                if (mas[i] > max) { max = mas[i]; coord_max = i; }
            for (int i = 0; i < n; i++)
                if (mas[i] < min) { min = mas[i]; coord_min = i; }
 
            Console.Write("\nmin = "+coord_min + " max = " + coord_max + " ");
 
            tmp = mas[coord_min];
            mas[coord_min] = mas[coord_max];
            mas[coord_max] = tmp;
            Console.Write("\n");
            for (int i = 0; i < n; i++)
                Console.Write(mas[i] + " ");
 
            Console.ReadKey();
            
        }
    }
}
