namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var start = 0;
            var length = 1;
            var bestStart = 0;
            var bestLength = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i + 1;
                }
                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            var result = numbers.Skip(bestStart).Take(bestLength).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}