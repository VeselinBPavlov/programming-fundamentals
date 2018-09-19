namespace ReverseArrayOfIntegers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var arraySize = int.Parse(Console.ReadLine());

            var arrayOfNumbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                var number = int.Parse(Console.ReadLine());
                arrayOfNumbers[i] = number;
            }

            for (int i = arraySize - 1; i >= 0; i--)
            {
                Console.Write($"{arrayOfNumbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
