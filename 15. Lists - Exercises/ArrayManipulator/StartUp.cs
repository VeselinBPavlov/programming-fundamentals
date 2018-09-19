namespace ArrayManipulator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var input = Console.ReadLine();

            while (input != "print")
            {
                var commandLine = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var command = commandLine[0];

                switch (command)
                {
                    case "add":
                        {
                            var index = int.Parse(commandLine[1]);
                            var number = int.Parse(commandLine[2]);
                            numbers.Insert(index, number);
                        }
                        break;
                    case "addMany":
                        {
                            var index = int.Parse(commandLine[1]);
                            var numsList = commandLine.Skip(2).Take(commandLine.Length).Select(int.Parse).ToList();
                            numbers.InsertRange(index, numsList);
                        }
                        break;
                    case "contains":
                        {
                            var number = int.Parse(commandLine[1]);
                            Console.WriteLine(numbers.IndexOf(number));
                        }
                        break;
                    case "remove":
                        {
                            var index = int.Parse(commandLine[1]);
                            numbers.RemoveAt(index);
                        }
                        break;
                    case "shift":
                        {
                            var possition = int.Parse(commandLine[1]);
                            for (int i = 0; i < possition; i++)
                            {
                                var number = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(number);
                            }
                        }
                        break;
                    case "sumPairs":
                        {
                            for (int i = 0; i < numbers.Count - 1; i++)
                            {
                                numbers[i] += numbers[i + 1];
                                numbers.RemoveAt(i + 1);
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
