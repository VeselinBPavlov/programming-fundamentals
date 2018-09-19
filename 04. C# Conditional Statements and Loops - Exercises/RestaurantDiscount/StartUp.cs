namespace RestaurantDiscount
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal groupSize = decimal.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            string room = "";
            decimal priceRoom = 0.00M;
            decimal discount = 0.00M;
            decimal price = 0.00M;

            if (groupSize <= 50)
            {
                room = "Small Hall";
                priceRoom = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                room = "Terrace";
                priceRoom = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                room = "Great Hall";
                priceRoom = 7500;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "normal": discount = 0.05M; price = 500; break;
                case "gold": discount = 0.10M; price = 750; break;
                case "platinum": discount = 0.15M; price = 1000; break;
            }

            decimal totalPrice = priceRoom + price;
            totalPrice -= totalPrice * discount;
            decimal pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {room}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
