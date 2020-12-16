using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace LW7
{
    class Program
    {
        public static void Main(string[] args)
        {    
            var lists = new List<string> { "1", "2", "3", "10", "120", "5485", "4", "5", "6" };
            var counter = 0;

            for (int i = 0; i < lists.Count; i++)
            {
                if (lists.Where(s => s.Length == lists[i].Length).Count() > 1)
                    counter++;
            }

            Console.WriteLine("List: 1 , 2 , 3 , 10 , 120 , 5485 , 4 , 5 , 6 ");
            Console.WriteLine("Result: " + counter);
        }
    }
}
