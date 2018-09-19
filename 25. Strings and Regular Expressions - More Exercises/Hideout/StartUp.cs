namespace Hideout
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var map = Console.ReadLine();
            var clue = Console.ReadLine();
            var bestCount = 0;
            var bestIndex = 0;
            var veryBestCount = 0;
            var veryBestIndex = 0;

            while (true)
            {
                var signs = clue.Split(' ').ToArray();
                var searchedChar = char.Parse(signs[0]);
                var minimumCount = int.Parse(signs[1]);
                var count = 0;
                var searchedString = new string(searchedChar, minimumCount);
                var bestChar = new char();

                for (int i = 0; i < map.Length; i++)
                {
                    if (map.Contains(searchedString) == false)
                    {                      
                        break;
                    }

                    if (bestChar == searchedChar)
                    {
                        break;
                    }

                    if (searchedChar == map[i])
                    {
                        count++;
                        if (count >= minimumCount)
                        {
                            bestCount = count;
                            bestIndex = i - count + 1;
                        }
                    }
                    else
                    {
                        count = 0;
                    }                    
                }

                if (bestCount >= minimumCount && bestCount > veryBestCount)
                {
                    veryBestCount = bestCount;
                    veryBestIndex = bestIndex;
                    break;
                }

                clue = Console.ReadLine();
            }            
            
            Console.WriteLine($"Hideout found at index {veryBestIndex} and it is with size {veryBestCount}!");            
        }
    }
}
