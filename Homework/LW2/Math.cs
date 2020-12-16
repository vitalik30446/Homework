using System;
using System.Collections.Generic;
using System.Text;
namespace LW2
{
    public static class NumericSeries
    {
        public static double GetSum(double n, double k)
        {
            double res = 0;
            for (int i = 0; i < k; i++)
            {
                res += (Math.Pow(k, 2) - 3) / ((k * k) * Math.Pow(-1, k)) * k + 3);
            }
        }
    }
}
