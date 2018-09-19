namespace SinoTheWalker
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var leaveHour = Console.ReadLine()
                .Split(':')
                .Select(long.Parse)
                .ToArray();

            var hours = leaveHour[0];
            var minutes = leaveHour[1];
            var seconds = leaveHour[2];
            var numOfSteps = long.Parse(Console.ReadLine());
            var timeForStep = long.Parse(Console.ReadLine());

            var needTimeSec = (BigInteger)numOfSteps * timeForStep;

            needTimeSec += seconds;

            seconds = (long)needTimeSec % 60;
            minutes += (long)needTimeSec / 60;
            if (minutes > 59)
            {
                hours += minutes / 60;
                minutes %= 60;
            }
            if (hours > 23)
            {
                hours %= 24;
            }

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }       
    }
}
