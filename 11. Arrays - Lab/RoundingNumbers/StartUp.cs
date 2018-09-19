namespace RoundingNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var arrayRealNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)               
                .ToArray();

            var arrayInts = arrayRealNumbers
                .Select(double.Parse)
                .Select(x => x = Math.Round(x, MidpointRounding.AwayFromZero))
                .ToArray();

            for (int i = 0; i < arrayRealNumbers.Length; i++)
            {
                Console.WriteLine($"{arrayRealNumbers[i]} => {arrayInts[i]}");
            }            
        }
    }
}
