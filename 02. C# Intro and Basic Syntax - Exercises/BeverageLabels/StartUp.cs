namespace BeverageLabels
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string typeCola = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyBy100 = double.Parse(Console.ReadLine());
            double sugerBy100 = double.Parse(Console.ReadLine());

            double energy = energyBy100 * (volume / 100);
            double sugar = sugerBy100 * (volume / 100);

            Console.WriteLine($"{volume}ml {typeCola}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
