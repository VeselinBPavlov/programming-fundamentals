namespace OddFilter
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .Where(x => x % 2 == 0)
                .ToList();

            var average = numbers.Average();

            var result = numbers
                .Select(x => x > average ? x + 1 : x - 1)
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
