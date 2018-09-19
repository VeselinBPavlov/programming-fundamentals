namespace CameraView
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var inputLine = Console.ReadLine();

            
            var skipping = numbers[0];
            var taking = numbers[1];
            var pattern = $@"(\|<\w{{{skipping}}})(\w{{{1},{taking}}})";

            var matches = Regex.Matches(inputLine, pattern);

            var validPhotos = matches
                .Cast<Match>()
                .Select(x => x.Groups[2].Value)
                .ToList();

            Console.WriteLine(string.Join(", ", validPhotos));
        }
    }
}
