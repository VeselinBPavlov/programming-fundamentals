namespace ExactSumOfRealNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            decimal sum = 0.00M;

            for (int i = 0; i < numbers; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            if (sum % 1 == 0)
                Console.WriteLine($"{sum:f0}");
            else
                Console.WriteLine(sum);
        }
    }
}
