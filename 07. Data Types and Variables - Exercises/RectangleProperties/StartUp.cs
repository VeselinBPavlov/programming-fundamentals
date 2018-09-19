namespace RectangleProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double widgth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (widgth + height);
            double area = widgth * height;
            double diagonal = Math.Sqrt((widgth * widgth) + (height * height));

            Console.WriteLine($"{perimeter}");
            Console.WriteLine($"{area}");
            Console.WriteLine($"{diagonal}");
        }
    }
}