namespace SumReversedNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(string.Join("", x.Reverse())))
                .Sum();

            Console.WriteLine(numbers);
        }
    }
}
