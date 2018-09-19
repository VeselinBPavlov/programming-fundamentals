namespace NeighbourWars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int goshoHealth = 100;
            int peshoHealth = 100;
            int rounds = 0;            

            for (int i = 1; i <= 1000; i++)
            {               
                rounds++;
                

                if (i % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {rounds}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    
                }

                if (i % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {rounds}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");                    
                }
                if (i % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }
        }
    }
}
