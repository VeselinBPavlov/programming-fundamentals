namespace FoldAndSum
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

            var length = numbers.Length / 4;

            var left = numbers.Take(length).Reverse().ToList();
            var righ = numbers.Skip(length * 3).Take(length).Reverse().ToList();
            var firstList = new List<int>();
            firstList.AddRange(left);
            firstList.AddRange(righ);
            var secondList = numbers.Skip(length).Take(length * 2).ToList();
            var sumList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                var number = firstList[i] + secondList[i];
                sumList.Add(number);
            }

            Console.WriteLine(string.Join(" ", sumList));
        }
    }
}
