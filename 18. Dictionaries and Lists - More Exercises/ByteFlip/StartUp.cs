namespace ByteFlip
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length == 2)
                .Select(x => (string.Join("", x.Reverse())))
                .Reverse()
                .Select(x => (char)Convert.ToInt32(x, 16))
                .ToList();

            Console.WriteLine(string.Join("", inputLine));
        }
    }
}
