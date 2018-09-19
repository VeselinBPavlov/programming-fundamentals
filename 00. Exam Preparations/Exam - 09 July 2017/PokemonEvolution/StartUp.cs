namespace PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var pokemonRegister = new Dictionary<string, List<Tuple<string, int>>>();
            
            while (command != "wubbalubbadubdub")
            {
                var pokemonData = command
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();                

                if (pokemonData.Length > 1)
                {
                    var pokemonName = pokemonData[0];
                    var pokemonEvolution = pokemonData[1];
                    var pokemonIndex = int.Parse(pokemonData[2]);

                    if (pokemonRegister.ContainsKey(pokemonName) == false)
                    {
                        pokemonRegister.Add(pokemonName, new List<Tuple<string, int>>());
                    }

                    pokemonRegister[pokemonName].Add(new Tuple<string, int> (pokemonEvolution, pokemonIndex));
                }
                else
                {
                    var pokemonName = pokemonData[0];

                    if (pokemonRegister.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var evolution in pokemonRegister[pokemonName])
                        {
                            Console.WriteLine($"{evolution.Item1} <-> {evolution.Item2}");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var pokemon in pokemonRegister)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var evolution in pokemon.Value.OrderByDescending(x => x.Item2))
                {
                    Console.WriteLine($"{evolution.Item1} <-> {evolution.Item2}");
                }
            }
        }
    }
}
