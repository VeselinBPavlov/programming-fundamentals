namespace CalculateTriangleArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double wigth   = double.Parse(Console.ReadLine());
            double height  = double.Parse(Console.ReadLine());
            double area    = TriangleArea(wigth, height);
            Console.WriteLine(area);
        }

        static double TriangleArea(double wigth, double height)
        {
            return (wigth * height) / 2;
        }
    }
}