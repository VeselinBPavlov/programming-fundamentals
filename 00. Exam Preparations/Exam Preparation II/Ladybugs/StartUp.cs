namespace Ladybugs
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugPossitions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var field = new int[fieldSize];

            for (int i = 0; i < field.Length; i++)
            {
                if (ladybugPossitions.Contains(i))
                {
                    field[i] = 1;
                }
            }

            var command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                var commandList = command
                    .Split();
                var cuurentBugIndex = int.Parse(commandList[0]);
                var direction = commandList[1].ToLower();
                var flyLength = int.Parse(commandList[2]);


                var flyToIndex = direction == "right" ?
                    cuurentBugIndex + flyLength :
                    cuurentBugIndex - flyLength;
                if (!(0 <= cuurentBugIndex && cuurentBugIndex < fieldSize))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (!(0 <= flyToIndex && flyToIndex < fieldSize))
                {
                    field[cuurentBugIndex] = 0;
                    command = Console.ReadLine();
                    continue;
                }


                if (field[cuurentBugIndex] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (direction == "right")
                {
                    field[cuurentBugIndex] = 0;

                    var landed = false;
                    while (!landed)
                    {
                        if (field[flyToIndex] == 1)
                        {
                            flyToIndex += flyLength;
                            if (flyToIndex >= fieldSize)
                            {
                                break;
                            }
                        }
                        else
                        {
                            field[flyToIndex] = 1;
                            landed = true;
                        }
                    }
                }
                else
                {
                    field[cuurentBugIndex] = 0;

                    var landed = false;
                    while (!landed)
                    {
                        if (field[flyToIndex] == 1)
                        {
                            flyToIndex -= flyLength;
                            if (flyToIndex < 0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            field[flyToIndex] = 1;
                            landed = true;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
