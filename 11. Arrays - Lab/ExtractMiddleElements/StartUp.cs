namespace ExtractMiddleElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            var length = array.Length;

            if (length == 1)
            {
                Console.WriteLine($"{{ {array[0]} }}");
            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {array[length / 2 - 1]}, {array[length / 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {array[length / 2 - 1]}, {array[length / 2]}, {array[length / 2 + 1]} }}");
            }
        }
    }
}
