namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<List<string>> numbers = Console.ReadLine()
                .Split('|')
                .Reverse()
                .Select(s => s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList())
                .ToList();

            foreach (var nums in numbers)
            {
                Console.Write(string.Join(" ", nums) + " ");
            }
            Console.WriteLine();
        }
    }
}
