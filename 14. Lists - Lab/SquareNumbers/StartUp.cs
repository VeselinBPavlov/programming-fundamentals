namespace SquareNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x))
                .OrderByDescending(x => x)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
