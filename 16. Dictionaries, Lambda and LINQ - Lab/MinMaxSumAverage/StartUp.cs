namespace MinMaxSumAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbersCount = int.Parse(Console.ReadLine());

            var numbersList = new List<int>();

            for (int i = 0; i < numbersCount; i++)
            {
                var number = int.Parse(Console.ReadLine());
                numbersList.Add(number);
            }
            var sum = numbersList.Sum();
            var min = numbersList.Min();
            var max = numbersList.Max();
            var average = numbersList.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
