namespace CountTheIntegers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int counter = 0;

            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
