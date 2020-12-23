using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Task_1
{
    class Shop
    {
        List<Headphones> headphones = new List<Headphones>()
        {
            new Headphones() { Name = "Razer", Color="Red",  Year="2017", Price="1000"},
            new Headphones() { Name = "HyperX", Color = "Green",  Year = "2018", Price = "1500"},
            new Headphones() { Name = "JBL", Color = "Yellow",  Year = "2019", Price = "2000"},
            new Headphones() { Name = "Sony", Color = "Gray",  Year = "2019", Price = "3000"},
        };
        public void SearchHeadphoneName()
        {
            Console.WriteLine("Название наушников:");
            string name = Console.ReadLine();
            var headphone = headphones.FirstOrDefault(d => d.Name == name);
            if (headphone == null) Console.WriteLine("Данних наушников нет в нашем магазине.Попробуйте найти по цене");
            else
                Console.WriteLine($"Name:{headphone.Name}\t Color: {headphone.Color}\t Year: {headphone.Year}\t Price: { headphone.Price}");
        }
        public void SearchHeadphonePrice()
        {
            Console.WriteLine("Цена наушников:");
            string price = Console.ReadLine();
            var headphone = headphones.FirstOrDefault(d => d.Price == price);
            if (headphone == null)
            {
                Console.WriteLine("Данних наушников нет в нашем магазине.Попробуйте найти по году производства");
                return;
            }
            else
                Console.WriteLine($"Name:{headphone.Name}\t Color: {headphone.Color}\t Year: {headphone.Year}\t Price: { headphone.Price}");
        }
        public void SearchHeadphonePriceYear()
        {
            Console.WriteLine("Год:");
            string year = Console.ReadLine();
            var headphone = headphones.FirstOrDefault(d => d.Year == year);
            if (headphone == null)
            {
                Console.WriteLine("Данних наушников нет в нашем магазине.Попробуйте найти по цвету");
                return;
            }
            else
                Console.WriteLine($"Name:{headphone.Name}\t Color: {headphone.Color}\t Year: {headphone.Year}\t Price: { headphone.Price}");
        }
        public void SearchHeadphoneColor()
        {
            Console.WriteLine("Цвет:");
            string color = Console.ReadLine();
            var headphone = headphones.FirstOrDefault(d => d.Color == color);
            if (headphone == null)
            {
                Console.WriteLine("Данних наушников нет в нашем магазине.Вы вернулись к начальному меню");
                return;
            }
            else
                Console.WriteLine($"Name:{headphone.Name}\t Color: {headphone.Color}\t Year: {headphone.Year}\t Price: { headphone.Price}");
        }
    }
}
