using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Task_1
{
    class Garage
    {
        List<Cars> cars = new List<Cars>()
        {
            new Cars() { Name = "Nissan", Color="Red", Max_Speed=315, Year="2017", Type="Gasoline"},
            new Cars() { Name = "Porsche", Color = "Green", Max_Speed = 330, Year = "2018", Type = "Gasoline"},
            new Cars() { Name = "Ferrari", Color = "Yellow", Max_Speed = 340, Year = "2019", Type = "Gasoline"},
            new Cars() { Name = "Tesla", Color = "Gray", Max_Speed = 120, Year = "2019", Type = "Electric"},
        };

        public void RemoveCar()
        {
            Console.WriteLine("Назовите машину, которую хотите удалить:");
            string name = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Name == name);
            if (car == null)
            {
                Console.WriteLine("Данной машини нет в вашем гараже");
                return;
            }
            cars.Remove(car);
            Console.WriteLine($"Вы удалили з вашего гаража {car.Name}");
        }
        public void ChoiceCarToName()
        {
            Console.WriteLine("Название машини:");
            string name = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Name == name);
            if (car == null) Console.WriteLine("Данной машини нет в вашем гараже.Попробуйте найти по скорости");
            else
                Console.WriteLine($"Name:{car.Name}\t Color: {car.Color}\t Max_Speed: { car.Max_Speed}\t Year: {car.Year}\t Type: { car.Type}");
        }
        public void ChoiceCarMax_Speed()
        {
            Console.WriteLine("Максимальная скорость:");
            string max_speed = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Max_Speed == Convert.ToInt32(max_speed));
            if (car == null) Console.WriteLine("Данной машини нет в вашем гараже.Попробуйте найти по типу");
            else
                Console.WriteLine($"Name:{car.Name}\t Color: {car.Color}\t Max_Speed: { car.Max_Speed}\t Year: {car.Year}\t Type: { car.Type}");
        }
        public void ChoiceCarToType()
        {
            Console.WriteLine("Тип:");
            string type = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Type == type);
            if (car == null)
            {
                Console.WriteLine("Данной машини нет в вашем гараже.Попробуйте найти по году производства");
                return;
            }
            else
                Console.WriteLine($"Name:{car.Name}\t Color: {car.Color}\t Max_Speed: { car.Max_Speed}\t Year: {car.Year}\t Type: { car.Type}");
        }
        public void ChoiceCarToYear()
        {
            Console.WriteLine("Год:");
            string year = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Year == year);
            if (car == null)
            {
                Console.WriteLine("Данной машини нет в вашем гараже.Попробуйте найти по цвету");
                return;
            }
            else
                Console.WriteLine($"Name:{car.Name}\t Color: {car.Color}\t Max_Speed: { car.Max_Speed}\t Year: {car.Year}\t Type: { car.Type}");
        }
        public void ChoiceCarToColor()
        {
            Console.WriteLine("Цвет:");
            string color = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Color == color);
            if (car == null)
            {
                Console.WriteLine("Данной машини нет в вашем гараже.Вы вернулись к начальному меню");
                return;
            }
            else
                Console.WriteLine($"Name:{car.Name}\t Color: {car.Color}\t Max_Speed: { car.Max_Speed}\t Year: {car.Year}\t Type: { car.Type}");
        }
    }
}
