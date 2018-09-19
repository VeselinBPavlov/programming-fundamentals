namespace SumOfOddNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;
            var count = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(count);
                sum += count;
                count += 2;                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
