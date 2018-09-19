namespace KaminoFactory
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var dnaLength = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();

            var result = new int[dnaLength];
            var bestCount = 0;
            var bestIndex = 0;
            var bestSequence = 1;
            var sequence = 1;

            while (command != "Clone them!")
            {
                var dnaSequence = command
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();             

                var counter = 0;
                var index = 0;                

                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    if (dnaSequence[i] == 1)
                    {
                        counter++;

                        if (counter > bestCount)
                        {
                            result = dnaSequence;
                            bestCount = counter;
                            bestIndex = index;                            
                            bestSequence = sequence;
                        }
                        else if (counter == bestCount)
                        {
                            if (index < bestIndex)
                            {
                                result = dnaSequence;
                                bestCount = counter;
                                bestIndex = index;                               
                                bestSequence = sequence;
                            }
                            else if (index == bestIndex && dnaSequence.Sum() > result.Sum())
                            {
                                result = dnaSequence;
                                bestCount = counter;
                                bestIndex = index;
                                bestSequence = sequence;
                            }
                        }
                    }
                    else
                    {
                        counter = 0;
                        index = i + 1;
                    }
                }
                sequence++;
                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequence} with sum: {result.Sum()}.");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
