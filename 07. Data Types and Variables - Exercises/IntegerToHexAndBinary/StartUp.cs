namespace IntegerToHexAndBinary
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string outputHex = Convert.ToString(number, 16);
            string outputBinary = Convert.ToString(number, 2);

            Console.WriteLine(outputHex.ToUpper());
            Console.WriteLine(outputBinary);
        }
    }
}