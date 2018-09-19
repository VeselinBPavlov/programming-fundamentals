namespace LongestIncreasingSubnumbers
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

            var length = new int[numbers.Length];
            var prev = new int[numbers.Length];
            var bestLength = 0;
            var lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > bestLength)
                {
                    bestLength = length[i];
                    lastIndex = i;
                }
            }

            var sequence = new List<int>();
            for (int i = 0; i < bestLength; i++)
            {
                sequence.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            sequence.Reverse();
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}