namespace ArrayStatistics
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            var maxNum = array.Max();
            var minNum = array.Min();
            var sum = array.Sum();
            var average = array.Average();            

            Console.WriteLine($"Min = {minNum}");
            Console.WriteLine($"Max = {maxNum}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
