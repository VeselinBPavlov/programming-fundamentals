namespace TakeSkipRope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .ToCharArray();

            var numbersList = inputLine
                .Where(x => Char.IsDigit(x))
                .Select(x => x.ToString())
                .Select(int.Parse)
                .ToArray();

            var message = inputLine
                .Where(x => !(Char.IsDigit(x)))
                .ToArray();

            var takeList = numbersList
               .Where((x, i) => i % 2 == 0)
               .ToList();

            var skipList = numbersList
                .Where((x, i) => i % 2 == 1)
                .ToList();

            var skipTakeSum = 0;
            var hiddenMessage = new List<char>();          

            for (int i = 0; i < takeList.Count; i++)
            {
                var skipped = message.Skip(skipTakeSum).ToList();
                var taked = skipped.Take(takeList[i]).ToList();
                hiddenMessage.AddRange(taked);
                skipTakeSum += skipList[i] + takeList[i];
            }

            Console.WriteLine(string.Join("", hiddenMessage));
        }
    }
}
