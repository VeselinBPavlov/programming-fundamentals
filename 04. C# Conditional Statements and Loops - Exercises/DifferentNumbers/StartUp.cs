namespace DifferentNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if ((secondNumber - firstNumber) < 5)
                Console.WriteLine("No");

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber + 1; j <= secondNumber; j++)
                {
                    for (int k = firstNumber + 2; k <= secondNumber; k++)
                    {
                        for (int l = firstNumber + 3; l <= secondNumber; l++)
                        {
                            for (int m = firstNumber + 4; m <= secondNumber; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                            }
                        }
                    }
                }
            }
        }
    }
}
