using System;

namespace Root
{
    public class Root
    {
        public static double GetSqrt(double num)
        {
            if (num == 0) return 0;

            double x = num;
            double y = (x + 1) / 2;

            while (y < x)
            {
                x = y;
                y = (x + num / x) / 2;
            }

            return x;
        }
    }
}