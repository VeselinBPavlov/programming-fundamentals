namespace PokemonDontGo
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var sequence = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var counter = 0L;

            while (sequence.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                var tempNumber = 0L;
                
                if (index < 0)
                {
                    tempNumber = sequence[0];
                    sequence[0] = sequence[sequence.Count - 1];
                }
                else if (index > sequence.Count - 1)
                {
                    tempNumber = sequence[sequence.Count - 1];
                    sequence[sequence.Count - 1] = sequence[0];
                }
                else
                {
                    tempNumber = sequence[index];
                    sequence.RemoveAt(index);
                }
                counter += tempNumber;

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= tempNumber)
                    {
                        sequence[i] += tempNumber;
                    }
                    else
                    {
                        sequence[i] -= tempNumber;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
