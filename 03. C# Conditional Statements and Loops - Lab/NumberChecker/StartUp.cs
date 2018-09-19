namespace NumberChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                int m = Int32.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input!", e);
            }
            
        }
    }
}
