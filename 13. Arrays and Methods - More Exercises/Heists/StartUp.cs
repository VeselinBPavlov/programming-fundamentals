namespace Heists
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var prices = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            var totalExpenses = 0L;
            var totalEarnings = 0L;
            var totalProfit = 0L;
           

            while (true)
            {
                var lootAndExpenses = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (lootAndExpenses[0] == "Jail" && lootAndExpenses [1] == "Time")
                {
                    break;
                }

                var jewels = '%';
                var gold = '$';
                var loot = lootAndExpenses[0].ToArray();
                var expenses = Convert.ToInt64(lootAndExpenses[1]);
                

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == jewels)
                    {
                        totalEarnings += prices[0];                       
                    }
                    if (loot[i] == gold)
                    {
                        totalEarnings += prices[1];
                    }
                }

                totalExpenses += expenses;
            }

            totalProfit = totalEarnings - totalExpenses;

            if (totalProfit >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalProfit}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalProfit)}.");
            }

        }
    }
}
