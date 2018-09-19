namespace GameOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber= int.Parse(Console.ReadLine());

            int numberOne = 0;
            int numberTwo = 0;
            int counter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    counter++;
                    if ((i + j) == magicNumber)
                    {
                        numberOne = i;
                        numberTwo = j;                                                                        
                    }
                }
            }
            if ((numberOne + numberTwo) == magicNumber)
                Console.WriteLine($"Number found! {numberOne} + {numberTwo} = {magicNumber}");
            else
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
