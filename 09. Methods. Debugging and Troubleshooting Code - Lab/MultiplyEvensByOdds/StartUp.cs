namespace MultiplyEvensByOdds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number   = int.Parse(Console.ReadLine());
            int multiply = Result(number);
            Console.WriteLine(multiply); 
        }

        static int Result(int number)
        {
            int sumEven = 0;
            int sumOdd  = 0;

            for (int i = 10; i <= Math.Abs(number * 10); i *= 10)
            {
                int currentNumber = number % (i);
                    currentNumber /= (i / 10);

                if (currentNumber % 2 == 0)
                    sumEven += currentNumber;
                else
                    sumOdd  += currentNumber;
            }
            return sumEven * sumOdd;
        }
    }
}
