namespace NumberChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            long checkNumber = 0L;

            try
            {
                checkNumber = long.Parse(number);
                Console.WriteLine("integer");
            }
            catch
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
