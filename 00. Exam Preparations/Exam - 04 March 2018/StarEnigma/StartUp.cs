namespace StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();
            var countAttacked = 0;
            var countDestroyed = 0;


            for (int i = 0; i < n; i++)
            {
                var encryptedMessage = Console.ReadLine();
                var count = 0;

                var decryptRegex = @"S|T|A|R|s|t|a|r";
                var matches = Regex.Matches(encryptedMessage, decryptRegex);

                foreach (Match m in matches)
                {
                    count++;
                }

                var decryptedMessageArr = encryptedMessage
                     .Select(x => x -= (char)count)
                     .ToArray();

                var decryptedMessage = new string(decryptedMessageArr);

                var pattern = @"\@([a-zA-Z]+)[^@\-!:>]*\:([0-9]+)[^@\-!:>]*\!(A|D)\![^@\-!:>]*\-\>[0-9]+";

                var match = Regex.Match(decryptedMessage, pattern);

                if (match.Success == false)
                {
                    continue;
                }

                var planetName = match.Groups[1].Value;
                var attackType = match.Groups[3].Value;

                if (attackType == "A")
                {
                    countAttacked++;
                    attackedPlanets.Add(planetName);
                }
                else
                {
                    countDestroyed++;
                    destroyedPlanets.Add(planetName);
                }
            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {countAttacked}");
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {countDestroyed}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
