namespace IntervalOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                for (int i = number1; i <= number2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (number2 < number1)
            {
                for (int j = number2; j <= number1; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
