using System;

namespace LW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дана матрица A(MxN)");
            Console.Write("M=");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Исходная матрица:");
            int[,] k = new int[m, n];
            Random r = new Random();
            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    k[i, j] = r.Next(1, 10);
                    Console.Write(k[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int Imax = 0, Jmax = 0, Imin = 0, Jmin = 0;
            for (int i = 0; i < m; i++)
            {
                int max = k[i, 0];
                int min = k[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (k[i, j] > max) { max = k[i, j]; Imax = i; Jmax = j; }
                    if (k[i, j] < min) { min = k[i, j]; Imin = i; Jmin = j; }
                }

                int z = k[Imax, Jmax];
                k[Imax, Jmax] = k[Imin, Jmin];
                k[Imin, Jmin] = z;

                Jmax = 0; Jmin = 0; Imax = i + 1; Imin = i + 1;
            }

            Console.WriteLine("Преобразованная матрица:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(k[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
