namespace KarateStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('>').ToArray();
            var result = new List<string>();
            result.Add(input[0]);
            var power = 0;
            var prevPower = 0;

            for (int i = 1; i < input.Length; i++)
            {
                power = int.Parse(input[i].First().ToString()) + prevPower;
                var punch = "";
                if (power <= input[i].Length)
                {
                    punch = input[i].Remove(0, power);
                    power = 0;
                    prevPower = 0;
                }
                else
                {
                    prevPower = power - input[i].Length;
                    punch = "";
                }
                
                result.Add(punch);
            }

            Console.WriteLine(string.Join(">", result));
        }
    }
}
