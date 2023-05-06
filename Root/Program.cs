using System;

namespace Root
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                double sqrt = Root.GetSqrt(num);

                Console.WriteLine(sqrt);
            }
        }
    }
}