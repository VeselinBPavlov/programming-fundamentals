namespace TheaThePhotographer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double numberOfPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            double timeToUpload = double.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(numberOfPictures * (filterFactor / 100));
            double timeFilterAllPictures = numberOfPictures * filterTime;
            double uploadTimeFilteredPictures = filteredPictures * timeToUpload;
            double totalTime = timeFilterAllPictures + uploadTimeFilteredPictures;

            TimeSpan timeTaken = TimeSpan.FromSeconds(totalTime);
            string formattedTime = timeTaken.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(formattedTime);
        }
    }
}