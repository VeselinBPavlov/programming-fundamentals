namespace HelloName
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintGreetingByName(name);
        }

        public static void PrintGreetingByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

    }
}

