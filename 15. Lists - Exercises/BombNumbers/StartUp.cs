namespace BombNumbers
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
            var bombProp = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var bombNumber = bombProp[0];
            var bombRange = bombProp[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!numbers.Contains(bombNumber))
                {
                    break;
                }
                var bombPosition = numbers.IndexOf(bombNumber);
                var leftSide = numbers.Take(bombPosition).Reverse().ToList();
                var rightSide = numbers.Skip(bombPosition + 1).Take(numbers.Count).ToList();

                if (bombRange < leftSide.Count)
                {
                    leftSide.RemoveRange(0, bombRange);
                    leftSide.Reverse();
                }
                else
                {
                    leftSide.Clear();
                }
                if (bombRange < rightSide.Count)
                {
                    rightSide.RemoveRange(0, bombRange);
                }
                else
                {
                    rightSide.Clear();
                }
                numbers.Clear();
                numbers.AddRange(leftSide);
                numbers.AddRange(rightSide);
            }

            var result = numbers.Sum();

            Console.WriteLine(result);
        }
    }
}
