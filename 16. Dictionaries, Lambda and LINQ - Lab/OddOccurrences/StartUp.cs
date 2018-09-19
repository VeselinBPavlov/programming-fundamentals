namespace OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var words = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => x.ToLower())
               .ToArray();

            var numbersCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!numbersCount.ContainsKey(words[i]))
                {
                    numbersCount.Add(words[i], 0);
                }
                numbersCount[words[i]]++;
            }
            var oddWords = new List<string>();            

            foreach (var number in numbersCount.Where(x => x.Value % 2 == 1))
            {
                oddWords.Add(number.Key);
            }

            Console.WriteLine(string.Join(", ", oddWords));
        }
    }
}
