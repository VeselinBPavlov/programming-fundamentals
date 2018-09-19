namespace Megapixels
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal widgth = decimal.Parse(Console.ReadLine());
            decimal length = decimal.Parse(Console.ReadLine());

            decimal mexapixels = Math.Round((widgth * length) / 1000000, 1);
            Console.WriteLine($"{widgth}x{length} => {mexapixels}MP");
        }
    }
}
