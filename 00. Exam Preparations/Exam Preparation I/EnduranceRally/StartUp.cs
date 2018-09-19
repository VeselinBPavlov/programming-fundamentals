namespace EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var driversList = Console.ReadLine().Split(' ').ToArray();
            var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ranking = new List<string>();            

            foreach (var driver in driversList)
            {
                var fuel = (double)driver.First();
                var result = string.Empty;               

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];

                        if (fuel <= 0)
                        {
                            result = $"reached {i}";
                            break;
                        }
                    }
                }

                if (result == "")
                {
                    result = $"fuel left {fuel:f2}";
                }

                var rank = $"{driver} - {result}";
                ranking.Add(rank);
            }

            foreach (var driver in ranking)
            {
                Console.WriteLine($"{driver}");
            }
        }
    }
}
