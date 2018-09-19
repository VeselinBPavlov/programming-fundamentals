namespace CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numbersList = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbersList.ContainsKey(numbers[i]))
                {
                    continue;
                }

                numbersList.Add(numbers[i], 0);

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbersList[numbers[i]] += 1;
                    }
                }
            }

            foreach (var number in numbersList)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}