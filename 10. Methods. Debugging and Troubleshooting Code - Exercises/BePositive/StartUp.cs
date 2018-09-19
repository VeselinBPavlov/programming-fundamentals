﻿namespace BePositive
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');

                var number = new List<int>();
                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        number.Add(int.Parse(input[j]));
                    }
                }

                bool isFound = false;
                for (int j = 0; j < number.Count; j++)
                {
                    int currentNum = number[j];

                    if (currentNum >= 0)
                    {
                        Console.Write(isFound ? $" {currentNum}" : $"{currentNum}");
                        isFound = true;
                    }
                    if (currentNum < 0)
                    {
                        if (j + 1 >= number.Count)
                        {
                            continue;
                        }
                        currentNum = number[j] + number[j + 1];
                        if (currentNum >= 0)
                        {
                            Console.Write(isFound ? $" {currentNum}" : $"{currentNum}");
                            isFound = true;
                        }
                        j++;
                    }
                }

                if (isFound)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}
