namespace MaxMethod
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numberOne   = int.Parse(Console.ReadLine());
            int numberTwo   = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            if (numberThree > numberOne)
                numberOne = numberThree;
            else if (numberThree > numberTwo)
                numberTwo = numberThree;

            int maxNumber = GetMaxNumber(numberOne, numberTwo);
            Console.WriteLine(maxNumber);
        }

        public static int GetMaxNumber(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
                return numberOne;
            else
                return numberTwo;
        }
    }
}