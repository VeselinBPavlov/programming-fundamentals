namespace LongerLine
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
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double sumX1Y1 = (x1 * x1) + (y1 * y1);
            double sumX2Y2 = (x2 * x2) + (y2 * y2);
            double firstLine = sumX1Y1 + sumX2Y2;

            double sumX3Y3 = (x3 * x3) + (y3 * y3);
            double sumX4Y4 = (x4 * x4) + (y4 * y4);
            double secondLine = sumX3Y3 + sumX4Y4;

            if (firstLine >= secondLine)
            {
                if (sumX1Y1 <= sumX2Y2)
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                if (sumX3Y3 <= sumX4Y4)
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                else
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }
    }
}
