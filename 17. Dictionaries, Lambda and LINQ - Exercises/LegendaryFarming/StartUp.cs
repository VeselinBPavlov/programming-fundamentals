namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var keyMaterials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "fragments", 0},
                { "motes", 0 }
            };

            var junkMaterials = new SortedDictionary<string, int>();

            var isObrained = false;

            while (!isObrained)
            {
                var inputLine = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < inputLine.Length; i += 2)
                {
                    var quantity = int.Parse(inputLine[i]);
                    var material = inputLine[i + 1];

                    if (material == "shards")
                    {
                        keyMaterials["shards"] += quantity;
                        if (keyMaterials["shards"] >= 250)
                        {
                            keyMaterials["shards"] -= 250;
                            isObrained = true;
                            Console.WriteLine("Shadowmourne obtained!");
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        keyMaterials["fragments"] += quantity;
                        if (keyMaterials["fragments"] >= 250)
                        {
                            keyMaterials["fragments"] -= 250;
                            isObrained = true;
                            Console.WriteLine("Valanyr obtained!");
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        keyMaterials["motes"] += quantity;
                        if (keyMaterials["motes"] >= 250)
                        {
                            keyMaterials["motes"] -= 250;
                            isObrained = true;
                            Console.WriteLine("Dragonwrath obtained!");
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }
                        junkMaterials[material] += quantity;
                    }
                }              
            }

            foreach (var keyItem in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{keyItem.Key}: {keyItem.Value}");
            }
            foreach (var junkItem in junkMaterials)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }
    }
}
