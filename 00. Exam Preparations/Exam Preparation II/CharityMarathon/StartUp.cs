namespace CharityMarathon
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var marathonDays = long.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var laps = long.Parse(Console.ReadLine());
            var trackLength = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            var maximumRunners = trackCapacity * marathonDays;

            if (runners > maximumRunners)
            {
                runners = maximumRunners;
            }

            var totalMeters = (long)runners * laps * trackLength;
            var totalKm = (decimal)totalMeters / 1000;

            var donation = moneyPerKm * totalKm;

            Console.WriteLine($"Money raised: {donation:f2}");
        }        
    }
}
