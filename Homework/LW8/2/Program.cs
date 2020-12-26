using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Phones();
            var flag = true;
            while (flag)
            {               
                Console.WriteLine("1 - выход");
                Console.Write("Опция > ");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: ; break; 
                    default: Console.WriteLine("Упс"); break;
                }
            }
        }
    }
}
