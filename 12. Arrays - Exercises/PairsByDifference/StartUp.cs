namespace PairsByDifference
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
            var difference = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var fistNum = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    var secondNum = array[j];
                    if (Math.Abs(fistNum - secondNum) == difference)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
