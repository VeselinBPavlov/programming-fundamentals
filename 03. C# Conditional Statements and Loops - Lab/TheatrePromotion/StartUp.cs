namespace TheatrePromotion
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var typeOfDay = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());

            var price = 0;

            if (age >= 0 && age <= 18)
            {
                switch (typeOfDay)
                {
                    case "weekday": price = 12; break;
                    case "weekend": price = 15; break;
                    case "holiday": price = 5; break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeOfDay)
                {
                    case "weekday": price = 18; break;
                    case "weekend": price = 20; break;
                    case "holiday": price = 12; break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeOfDay)
                {
                    case "weekday": price = 12; break;
                    case "weekend": price = 15; break;
                    case "holiday": price = 10; break;
                }
            }

            if (age < 0 || age > 122)
                Console.WriteLine("Error!");            
            else
                Console.WriteLine($"{price}$");
        }
    }
}
