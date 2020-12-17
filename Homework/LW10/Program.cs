using System;

class Program
{
    static void Main()
    {
        Random r = new Random();
        int max = Int32.MinValue, min = Int32.MaxValue;
        int imax = 0, imin = 0;
        int[] a = new int[5];

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write((a[i] = r.Next(0, 50)) + " ");
            if (min > a[i])
            {
                min = a[i];
                imin = i;
            }
            if (max < a[i])
            {
                max = a[i];
                imax = i;
            }
        }

        a[imin] = max;
        a[imax] = min;

        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
            Console.Write(a[i] + " ");
        Console.ReadKey();
    }
}
