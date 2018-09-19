namespace DayОfWeek
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var day = int.Parse(Console.ReadLine());
            var daysOfWeek = new string[] 
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }            
        }
    }
}
