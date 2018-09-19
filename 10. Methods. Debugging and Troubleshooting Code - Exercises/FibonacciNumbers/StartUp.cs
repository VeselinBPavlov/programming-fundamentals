namespace FibonacciNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(1);
                return;
            }

            int fibNum = GetFibNumber(number);
            Console.WriteLine(fibNum);
        }

        public static int GetFibNumber(int number)
        {
            int input  = 0;
            int output = 1;
            int fibNum = 0;

            for (int i = 0; i < number; i++)
            {
                fibNum = input + output;
                input  = output;
                output = fibNum;
            }

            return fibNum;
        }
    }
}
