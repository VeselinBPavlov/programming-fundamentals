namespace SequenceOfCommands
{
    using System;
    using System.Linq;

    public class StartUp
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()               
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();             

            while (command != "stop")
            {
                string[] commandAndArguments = command.Split(' ');
                array = PerformAction(array, commandAndArguments);

                Console.WriteLine(string.Join(" ", array));

                command = Console.ReadLine();                  
            }
        }

        public static long[] PerformAction(long[] array, string[] action)
        {
            int index = 0;
            int value = 0;

            if (action.Length == 3)
            {
                index = int.Parse(action[1]);
                index--;
                value = int.Parse(action[2]);
            }

            switch (action[0])
            {
                case "multiply":
                    array[index] *= value;
                    break;
                case "add":
                    array[index] += value;
                    break;
                case "subtract":
                    array[index] -= value;
                    break;
                case "lshift":
                    array = ArrayShiftLeft(array);
                    break;
                case "rshift":
                    array = ArrayShiftRight(array);
                    break;
            }

            return array;
        }

        public static long[] ArrayShiftRight(long[] array)
        {
            long mem = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = mem;

            return array;
        }

        public static long[] ArrayShiftLeft(long[] array)
        {
            long mem = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = mem;

            return array;
        }

        public static void PrintArray(long[] array)
        {
            Console.Write(string.Join(" ", array));
        }
    }
}

