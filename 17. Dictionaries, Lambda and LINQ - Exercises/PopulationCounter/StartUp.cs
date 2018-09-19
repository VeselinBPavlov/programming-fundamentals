namespace PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var totalCountryPopulation = new Dictionary<string, long>();
            var citiesPopulation = new Dictionary<string, Dictionary<string, int>>();

            while (input != "report")
            {
                var countryData = input.Split('|').ToArray();

                var city = countryData[0];
                var country = countryData[1];
                var cityPopulation = int.Parse(countryData[2]);

                if (!citiesPopulation.ContainsKey(country))
                {
                    totalCountryPopulation.Add(country, 0L);
                    citiesPopulation.Add(country, new Dictionary<string, int>());
                }

                citiesPopulation[country].Add(city, cityPopulation);
                totalCountryPopulation[country] += cityPopulation;

                input = Console.ReadLine();
            }

            foreach (var country in totalCountryPopulation.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                Console.WriteLine(string.Join(Environment.NewLine, citiesPopulation[country.Key]
                    .OrderByDescending(x => x.Value).Select(x => $"=>{x.Key}: {x.Value}")));
            }
        }
    }
}
