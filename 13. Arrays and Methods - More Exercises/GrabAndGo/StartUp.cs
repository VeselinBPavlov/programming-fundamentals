namespace GrabAndGo
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var number = long.Parse(Console.ReadLine());           
            var take = 0;
            
            if (array.Contains(number))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (number == array[i])
                    {
                        take = i;
                    }
                }
                Console.WriteLine(array.Take(take).Sum());
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
