namespace OddNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 0; i <= 1000; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                    Console.WriteLine($"Please write an odd number.");
                else
                {
                    if (number < 0)
                        number *= -1;
                    Console.WriteLine($"The number is: {number}");
                    break;
                }            
            }
        }
    }
}
