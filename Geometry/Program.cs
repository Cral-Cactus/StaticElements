using System;

namespace Geometry
{
    internal class Program
    {
        static void Main()
        {
            double square = double.Parse(Console.ReadLine());

            double squareP = Geometry.SquareP(square);
            double squareA = Geometry.SquareA(square);

            string[] rectangle = Console.ReadLine().Split(' ');
            double rectangleA1 = double.Parse(rectangle[0]);
            double rectangleB = double.Parse(rectangle[1]);

            double rectangleP = Geometry.RectangleP(rectangleA1, rectangleB);
            double rectangleA = Geometry.RectangleA(rectangleA1, rectangleB);

            double circle = double.Parse(Console.ReadLine());

            double circleA = Geometry.Circle(circle);

            Console.WriteLine($"Square - Perimeter: {squareP}, Area: {squareA}");
            Console.WriteLine($"Rectangle - Perimeter: {rectangleP}, Area: {rectangleA}");
            Console.WriteLine($"Circle - Area: {circleA}");
        }
    }
}