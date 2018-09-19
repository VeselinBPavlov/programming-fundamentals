namespace Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"([A-Z][A-Z])(\d+\.\d+)([A-Za-z]+)(\|)";
            var forecastWeather = new Dictionary<string, string>();
            var forecastTemperature = new Dictionary<string, double>();

            while (input != "end")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    var town = match.Groups[1].Value;
                    var temerature = double.Parse(match.Groups[2].Value);
                    var weather = match.Groups[3].Value;

                    if (forecastWeather.ContainsKey(town) == false)
                    {
                        forecastWeather.Add(town, weather);
                        forecastTemperature.Add(town, temerature);
                    }
                    else
                    {
                        forecastWeather[town] = weather;
                        forecastTemperature[town] = temerature;
                    }
                }
                
                input = Console.ReadLine();
            }           

            foreach (var town in forecastTemperature.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{town.Key} => {town.Value:f2} => {forecastWeather[town.Key]}");               
            }
        }
    }
}
