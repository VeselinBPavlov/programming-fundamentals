namespace StringConcatenation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char delimeter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string sumStrings = "";

            for (int i = 1; i <= number; i++)
            {
                string word = Console.ReadLine();

                if (evenOdd == "even" && i % 2 == 0)                
                    sumStrings += word + delimeter;                
                if (evenOdd == "odd" && i % 2 == 1)
                    sumStrings += word + delimeter;
            }
            sumStrings = sumStrings.Remove(sumStrings.Length - 1);
            Console.WriteLine(sumStrings);
        }
    }
}
