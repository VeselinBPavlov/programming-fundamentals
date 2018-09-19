namespace BackIn30Minutes
{    
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;

                if (hours == 24)
                    hours = 0;
            }          

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}