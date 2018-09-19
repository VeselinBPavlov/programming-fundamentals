namespace PokeMon
{
    using System;
    
    public class StartUp
    {
        public static void Main()
        {
            var pokePower = long.Parse(Console.ReadLine());
            var distanceTargets = long.Parse(Console.ReadLine());
            var exhaustionFactor = long.Parse(Console.ReadLine());
            var count = 0L;
            var halfPower = 0L;

            if (pokePower % 2 == 0)
            {
                halfPower = pokePower / 2;
            }

            while (pokePower >= distanceTargets)
            {
                pokePower -= distanceTargets;
                count++;

                if (pokePower == halfPower)
                {                    
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
