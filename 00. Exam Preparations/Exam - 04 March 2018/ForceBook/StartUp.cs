namespace ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
           
            var forceRegister = new Dictionary<string, List<string>>();
            var forceUsers = new List<string>();

            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    var input = command.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var forceSide = input[0];
                    var forceUser = input[1];

                    if (forceRegister.ContainsKey(forceSide) == false)
                    {
                        if (forceUsers.Contains(forceUser) == false)
                        {
                            forceRegister.Add(forceSide, new List<string>());
                            forceRegister[forceSide].Add(forceUser);
                            forceUsers.Add(forceUser);
                        }
                    }
                    else
                    {
                        if (forceUsers.Contains(forceUser) == false)
                        {                            
                            forceRegister[forceSide].Add(forceUser);
                            forceUsers.Add(forceUser);
                        }
                    }
                }

                if (command.Contains("->"))
                {
                    var input = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var forceSide = input[1];
                    var forceUser = input[0];

                    if (forceUsers.Contains(forceUser))
                    {
                        var otherSide = forceRegister.First(x => x.Value.Contains(forceUser)).Key;
                        forceRegister[otherSide].Remove(forceUser);

                        if (forceRegister.ContainsKey(forceSide) == false)
                        {                           
                            forceRegister.Add(forceSide, new List<string>());
                        }
                       
                        forceUsers.Add(forceUser);
                        forceRegister[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        if (forceRegister.ContainsKey(forceSide) == false)
                        {
                            forceUsers.Add(forceUser);
                            forceRegister.Add(forceSide, new List<string>());
                        }
                           
                        forceRegister[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var side in forceRegister.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (side.Value.Count == 0)
                {
                    continue;
                }
                else
                {
                    side.Value.Sort();
                }

                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                
                foreach (var user in side.Value)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
