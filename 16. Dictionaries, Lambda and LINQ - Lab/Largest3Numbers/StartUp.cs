namespace Largest3Numbers
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
               .OrderByDescending(x => x)
               .Take(3)
               .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
