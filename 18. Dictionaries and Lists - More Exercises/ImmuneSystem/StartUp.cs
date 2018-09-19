namespace ImmuneSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var health = int.Parse(Console.ReadLine());
            var virus = Console.ReadLine();
            var startHealth = health;            
            var virusList = new List<string>();

            while (virus != "end")
            {
                var defeatingMin = 0;
                var defeatingSec = 0;
                var defeatingTimeSec = 0;               

                var virusStreingth = virus.ToCharArray().Select(x => Convert.ToInt32(x)).ToList().Sum() / 3;

                if (virusList.Contains(virus) == false)
                {
                    virusList.Add(virus);
                    defeatingTimeSec = virusStreingth * virus.Length;                   
                }
                else
                {
                    defeatingTimeSec = (virusStreingth * virus.Length) / 3;
                }
                defeatingMin = defeatingTimeSec / 60;
                defeatingSec = defeatingTimeSec % 60;

                if (defeatingTimeSec > health)
                {
                    Console.WriteLine($"Virus {virus}: {virusStreingth} => {defeatingTimeSec} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    health -= defeatingTimeSec;
                    Console.WriteLine($"Virus {virus}: {virusStreingth} => {defeatingTimeSec} seconds");
                    Console.WriteLine($"{virus} defeated in {defeatingMin}m {defeatingSec}s.");
                    Console.WriteLine($"Remaining health: {health}");
                }

                var refresh = health * 0.2;
                health += (int)refresh;

                if (health > startHealth)
                {
                    health = startHealth;
                }

                virus = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {health}");
        }
    }
}
