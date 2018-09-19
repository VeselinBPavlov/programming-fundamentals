namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var phoneBook = new Dictionary<string, string>();

            while (inputLine != "END")
            {
                var command = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var operation = command[0];
                var name = command[1];

                switch (operation)
                {
                    case "A":
                        {
                            var phoneNumber = command[2];
                            if (!phoneBook.ContainsKey(name))
                            {
                                phoneBook.Add(name, "");
                            }
                            phoneBook[name] = phoneNumber;
                        }
                        break;
                    case "S":
                        {
                            if (phoneBook.ContainsKey(name))
                            {
                                Console.WriteLine($"{name} -> {phoneBook[name]}");
                            }
                            else
                            {
                                Console.WriteLine($"Contact {name} does not exist.");
                            }
                        }
                        break;
                }

                inputLine = Console.ReadLine();
            }

        }
    }
}
