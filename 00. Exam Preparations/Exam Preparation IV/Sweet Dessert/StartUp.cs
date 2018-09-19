namespace Sweet_Dessert
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var ammountCash = decimal.Parse(Console.ReadLine());
            var guestCount = long.Parse(Console.ReadLine());
            var bananasPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPriceKg = decimal.Parse(Console.ReadLine());

            var portions = Math.Ceiling((decimal)guestCount / 6);

            var neededMoney = (decimal)(portions * (2 * bananasPrice) + portions * (4 * eggsPrice) + portions * (0.2M * berriesPriceKg));

            if (ammountCash >= neededMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney - ammountCash:f2}lv more.");
            }
        }
    }
}
