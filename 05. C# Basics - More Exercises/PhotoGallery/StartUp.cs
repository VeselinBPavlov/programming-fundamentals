namespace PhotoGallery
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes= int.Parse(Console.ReadLine());
            int sizeInBytes = int.Parse(Console.ReadLine());
            int resolutionWidgth = int.Parse(Console.ReadLine());
            int resolutionHeight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{minutes:d2}");

            if (sizeInBytes < 1000)
                Console.WriteLine($"Size: {sizeInBytes}B");
            else if (sizeInBytes >= 1000 && sizeInBytes < 1000000)
                Console.WriteLine($"Size: {sizeInBytes * 0.001}KB");
            else
                Console.WriteLine($"Size: {sizeInBytes * 0.000001}MB");                    
           
             if (resolutionWidgth > resolutionHeight)
                Console.WriteLine($"Resolution: {resolutionWidgth}x{resolutionHeight} (landscape)");
            else if (resolutionWidgth < resolutionHeight)
                Console.WriteLine($"Resolution: {resolutionWidgth}x{resolutionHeight} (portrait)");
            else
                Console.WriteLine($"Resolution: {resolutionWidgth}x{resolutionHeight} (square)");
        }
    }
}
