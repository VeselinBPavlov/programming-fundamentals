namespace BeerKegs
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            double volumeKeg = 0;
            double biggestKeg = 0;
            string nameBeerKeg = "";

            for (int i = 0; i < number; i++)
            {
                string modelBeerKeg = Console.ReadLine();               
                double radiusKeg = double.Parse(Console.ReadLine());
                double heightKeg = double.Parse(Console.ReadLine());

                volumeKeg = Math.PI * radiusKeg * radiusKeg * heightKeg;

                if (biggestKeg < volumeKeg)
                {
                    biggestKeg = volumeKeg;
                    nameBeerKeg = modelBeerKeg;
                }
            }
            Console.WriteLine(nameBeerKeg);
        }
    }
}
