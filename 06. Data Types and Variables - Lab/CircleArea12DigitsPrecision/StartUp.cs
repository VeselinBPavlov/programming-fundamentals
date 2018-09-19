namespace CircleArea12DigitsPrecision
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:f12}");
        }
    }
}
