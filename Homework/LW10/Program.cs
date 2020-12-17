using System;
 
class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
 
        // Заполнение массива
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(i + " - введите значение: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
 
        /// Замена в массиве
for (int i = 0; i < arr.Length / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - i - 1];
    arr[arr.Length - i - 1] = temp;
}
 
        // Вывод массива на экран
        for (int i = 0;i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    
        Console.ReadKey();
    }
}
