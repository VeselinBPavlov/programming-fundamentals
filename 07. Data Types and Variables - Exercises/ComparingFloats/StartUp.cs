namespace ComparingFloats
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal numberA = decimal.Parse(Console.ReadLine());
            decimal numberB = decimal.Parse(Console.ReadLine());

            if ((Math.Abs(numberA - numberB)) < 0.000001M)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}