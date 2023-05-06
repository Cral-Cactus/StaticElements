using System;

namespace Geometry
{
    public class Geometry
    {
        public static double SquareP(double side)
        {
            return 4 * side;
        }

        public static double SquareA(double side)
        {
            return side * side;
        }

        public static double RectangleP(double a, double b)
        {
            return 2 * (a + b);
        }

        public static double RectangleA(double a, double b)
        {
            return a * b;
        }

        public static double Circle(double r)
        {
            return Math.PI * r * r;
        }
    }
}