namespace MostFrequentNumber
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var tempCounter = 0;
            var counter = 0;
            var number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        tempCounter++;
                        if (tempCounter > counter)
                        {
                            counter = tempCounter;
                            number = array[i];
                        }
                    }
                    else
                    {
                        tempCounter = 0;
                    }
                }
            }

            Console.WriteLine(number);
        }
    }
}
