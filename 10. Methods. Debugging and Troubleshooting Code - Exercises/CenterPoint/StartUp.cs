namespace CenterPoint
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sumX1Y1 = (x1 * x1) + (y1 * y1);
            double sumX2Y2 = (x2 * x2) + (y2 * y2);

            if (sumX1Y1 <= sumX2Y2)
                Console.WriteLine($"({x1}, {y1})");
            else
                Console.WriteLine($"({x2}, {y2})");
        }
    }
}
