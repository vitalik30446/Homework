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
            var lists = new List<string> { "4", "34", "765", "325", "234", "8796546", "20", "18", "19"};
            var counter = 0;
 
            for(int i = 0; i < lists.Count; i++)
            {
                if (lists.Where(s => s.Length == lists[i].Length).Count() > 1)
                    counter++;
            }
 
            Console.WriteLine("Result: " + counter);
        }
    }
}
