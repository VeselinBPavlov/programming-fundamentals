namespace TemperatureConversion
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var fahrenheitDegrees = double.Parse(Console.ReadLine());
            var celsiusDegrees    = FahrenheitToCelsius(fahrenheitDegrees);

            Console.WriteLine($"{celsiusDegrees:f2}");
        }

        static double FahrenheitToCelsius(double fahrenheitDegrees)
        {
            return (fahrenheitDegrees - 32) * 5 / 9;
        }
    }
}