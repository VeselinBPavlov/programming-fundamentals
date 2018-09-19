namespace SortTimes
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var timeList = Console.ReadLine()
                .Split(' ')
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", timeList));
        }
    }
}
