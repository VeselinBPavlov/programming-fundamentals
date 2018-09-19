namespace JumpAround
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

            var sum = 0;
            var position = 0;            

            while (position >= 0)
            {
                if (position < array.Length)
                {
                    sum += array[position];
                    position = position + array[position] < array.Length ?
                    position + array[position] : position - array[position];
                }
            }
            Console.WriteLine(sum);
        }
    }
}