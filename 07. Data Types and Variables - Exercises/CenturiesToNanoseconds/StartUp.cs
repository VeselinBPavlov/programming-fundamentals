namespace CenturiesToNanoseconds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = (long)minutes * 60;
            long miliseconds = seconds * 1000;
            long microseconds = miliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = " +
                $"{microseconds} microseconds = {nanoseconds} nanoseconds ");
        }
    }
}