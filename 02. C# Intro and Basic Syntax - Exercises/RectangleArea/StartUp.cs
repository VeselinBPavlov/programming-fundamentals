namespace RectangleArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c = a * b;

            Console.WriteLine($"{c:f2}");
        }
    }
}
