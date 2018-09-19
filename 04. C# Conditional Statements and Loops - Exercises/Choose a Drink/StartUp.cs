namespace Choose_a_Drink
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string proffesion = Console.ReadLine().ToLower();

            string druinkType = "";

            switch (proffesion)
            {
                case "athlete": druinkType = "Water"; break;
                case "businessman":
                case "businesswoman": druinkType = "Coffee"; break;
                case "softuni student": druinkType = "Beer"; break;
                default: druinkType = "Tea"; break;
            }

            Console.WriteLine(druinkType);
        }
    }
}
