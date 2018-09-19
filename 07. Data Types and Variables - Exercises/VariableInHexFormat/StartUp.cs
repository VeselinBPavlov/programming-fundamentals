namespace VariableInHexFormat
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(number, 16));
        }
    }
}