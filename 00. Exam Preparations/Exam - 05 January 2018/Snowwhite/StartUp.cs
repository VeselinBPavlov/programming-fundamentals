namespace Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var colorsDwarfs = new Dictionary<string, List<Dwarf>>();
            var allDwarfs = new List<Dwarf>();

            while (command != "Once upon a time")
            {
                var dwarfInfo = command
                    .Split(new char[] { ' ', '<', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = dwarfInfo[0];
                var color = dwarfInfo[1];
                var physics = int.Parse(dwarfInfo[2]);

                if (!colorsDwarfs.ContainsKey(color))
                {
                    colorsDwarfs[color] = new List<Dwarf>();
                }

                var dwarfsByCurrentCoulor = colorsDwarfs[color];
                var foundDwarf = dwarfsByCurrentCoulor.FirstOrDefault(d => d.Name == name);

                if (foundDwarf != null)
                {
                    foundDwarf.Physics = Math.Max(physics, foundDwarf.Physics);
                }
                else
                {
                    var dwarf = new Dwarf
                    {
                        Name = name,
                        Color = color,
                        Physics = physics
                    };

                    dwarfsByCurrentCoulor.Add(dwarf);
                    allDwarfs.Add(dwarf);
                }                

                command = Console.ReadLine();
            }

            var result = allDwarfs.OrderByDescending(x => x.Physics).ThenByDescending(d => colorsDwarfs[d.Color].Count()).ToList();

            foreach (var dwarf in result)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }          
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
    }
}
