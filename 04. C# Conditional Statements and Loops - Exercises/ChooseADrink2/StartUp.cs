namespace ChooseADrink2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string proffesion = Console.ReadLine();
            var drinkQuantity = decimal.Parse(Console.ReadLine());

            string drinkType = "";
            decimal price = 0.00M;           

            switch (proffesion)
            {
                case "Athlete": drinkType = "Water"; price = 0.70M;  break;
                case "Businessman":
                case "Businesswoman": drinkType = "Coffee"; price = 1.00M; break;
                case "SoftUni Student": drinkType = "Beer"; price = 1.70M;  break;
                default: drinkType = "Tea"; price = 1.20M; break;
            }

            decimal sumDrinks = price * drinkQuantity;

            Console.WriteLine($"The {proffesion} has to pay {sumDrinks:f2}.");
        }
    }
}
