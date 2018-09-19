namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dragonStats = new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var dragonType = input[0];
                var dragonName = input[1];
                int damage;
                int health;
                int armor;

                if (int.TryParse(input[2], out damage))
                    damage = int.Parse(input[2]);
                else
                    damage = 45;
                if (int.TryParse(input[3], out health))
                    health = int.Parse(input[3]);
                else
                    health = 250;
                if (int.TryParse(input[4], out armor))
                    armor = int.Parse(input[4]);
                else
                    armor = 10;

                if (!dragonStats.ContainsKey(dragonType))
                {
                    dragonStats[dragonType] = new SortedDictionary<string, List<int>>();
                }

                if (!dragonStats[dragonType].ContainsKey(dragonName))
                {
                    dragonStats[dragonType][dragonName] = new List<int>();
                }
                else
                {
                    dragonStats[dragonType][dragonName].Clear();
                }

                dragonStats[dragonType][dragonName].Add(damage);
                dragonStats[dragonType][dragonName].Add(health);
                dragonStats[dragonType][dragonName].Add(armor);
            }


            foreach (var dragonType in dragonStats)
            {
                Console.WriteLine($"{dragonType.Key}::({GetDragonTypeAverageStats(dragonType.Value)})");
                Console.WriteLine(string.Join("\n", dragonType.Value
                    .Select(s => $"-{s.Key} -> damage: {s.Value[0]}, health: {s.Value[1]}, armor: {s.Value[2]}")));
            }

        }

        static string GetDragonTypeAverageStats(SortedDictionary<string, List<int>> dragonNames)
        {
            var damageList = new List<int>();
            var healthList = new List<int>();
            var armorList = new List<int>();

            foreach (var name in dragonNames)
            {
                damageList.Add(name.Value[0]);
                healthList.Add(name.Value[1]);
                armorList.Add(name.Value[2]);
            }

            return $"{damageList.Average():f2}/{healthList.Average():f2}/{armorList.Average():f2}";
        }
    }
}
