namespace WeatherForecast
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string number = Console.ReadLine();
           
            long dataNumber = 0L;

            try
            {
                dataNumber = long.Parse(number);
                if (dataNumber <= sbyte.MaxValue && dataNumber >= sbyte.MinValue)
                {
                    Console.WriteLine("Sunny");
                    return;
                }
                if (dataNumber <= int.MaxValue && dataNumber >= int.MinValue)
                {
                    Console.WriteLine("Cloudy");
                    return;
                }
                if (dataNumber <= long.MaxValue && dataNumber >= long.MinValue)
                {
                    Console.WriteLine("Windy");
                    return;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
