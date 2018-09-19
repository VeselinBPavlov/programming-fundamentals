namespace DayOfWeek
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var day = Console.ReadLine();
            var date = DateTime.ParseExact(day, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}