namespace Snowmen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            

            while (numbersList.Count > 1)
            {
                var snowmansToRemove = new List<int>();

                for (int attacker = 0; attacker < numbersList.Count; attacker++)
                {
                   
                    var target = numbersList[attacker] % numbersList.Count;                    
                    
                    var difference = Math.Abs(attacker - target);

                    if (numbersList.Count - snowmansToRemove.Count == 1)
                    {
                        break;
                    }

                    if (snowmansToRemove.Contains(attacker))
                    {
                        continue;
                    }
                    
                    if (difference == 0)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        snowmansToRemove.Add(attacker);
                        numbersList[attacker] = -1;
                    }
                    else if (difference % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        numbersList[target] = -1;
                        snowmansToRemove.Add(target);
                    }
                    else if (difference % 2 == 1)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        snowmansToRemove.Add(attacker);
                        numbersList[attacker] = -1;
                    }

                    snowmansToRemove = snowmansToRemove.Distinct().ToList();
                }

                numbersList = numbersList.Where(x => x != -1).ToList();                
            }
        }
    }
}
