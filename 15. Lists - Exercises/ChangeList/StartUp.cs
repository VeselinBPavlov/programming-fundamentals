namespace ChangeList
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

            while (input != "Odd" && input != "Even")
            {
                var command = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "Delete")
                {
                    var number = int.Parse(command[1]);
                    numbers.RemoveAll(x => x == number);
                }
                else if (command[0] == "Insert")
                {
                    var number = int.Parse(command[1]);
                    var index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                }

                input = Console.ReadLine();
            }

            if (input == "Even")
            {
                numbers = numbers.Where(x => x % 2 == 0).ToList();
            }
            else
            {
                numbers = numbers.Where(x => x % 2 == 1).ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}