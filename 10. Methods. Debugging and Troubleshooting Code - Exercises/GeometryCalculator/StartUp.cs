using System.Security.Principal;

namespace GeometryCalculator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();

            double side   = 0;
            double height = 0;
            double result = 0;
            double radius = 0;

            switch (figureType)
            {
                case "triangle":  result = GetTriangleArea(side, height);  break;
                case "square":    result = GetSquareAre(side);             break;
                case "rectangle": result = GetRectangleArea(side, height); break;
                case "circle":    result = GetCircleArea(radius);          break;
            }
            Console.WriteLine($"{result:f2}");
        }

        public static double GetTriangleArea(double side, double height)
        {
            side   = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            double triangleArea = (side * height) / 2;
            return triangleArea;
        }

        public static double GetSquareAre(double side)
        {
            side = double.Parse(Console.ReadLine());
            double squareArea = side * side;
            return squareArea;
        }

        public static double GetRectangleArea(double side, double height)
        {
            side   = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            double rectangleArea = side * height;
            return rectangleArea;
        }

        public static double GetCircleArea(double radius)
        {
            radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * radius * radius;
            return circleArea;
        }
    }
}
