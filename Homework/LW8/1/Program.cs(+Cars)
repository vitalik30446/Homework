using System;
using System.Collections.Generic;
using System.Text;
namespace Task_1
{

      class Cars
      {
        public string Name { get; set; }
        public string Color { get; set; }
        public short Max_Speed { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public override string ToString()

        {
            return $"Name:{Name}\t Color: {Color}\t Max_Speed: { Max_Speed}\t Type: {Type}";
        }
        static void Main(string[] args)
        {
            var g = new Garage();
            var flag = true;
            while (flag)
            {
                Console.WriteLine("1 - найти машину в гараже");
                Console.WriteLine("2 - удалить машину");
                Console.WriteLine("3 - выход");
                Console.Write("Опция > ");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: g.ChoiceCarToName(); g.ChoiceCarMax_Speed(); g.ChoiceCarToType(); g.ChoiceCarToYear(); g.ChoiceCarToColor(); break;
                    case 2: g.RemoveCar(); break;                              
                    case 3: flag = false; break;
                    default: Console.WriteLine("Упс"); break;
                }
            }
        }

    }
}
