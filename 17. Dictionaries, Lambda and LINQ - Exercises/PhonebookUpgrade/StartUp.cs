namespace PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var phoneBook = new SortedDictionary<string, string>();

            while (inputLine != "END")
            {
                var command = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var operation = command[0];               

                switch (operation)
                {                   
                    case "A":
                        {
                            var name = command[1];
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
                            var name = command[1];
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
                    case "ListAll":
                        {
                            foreach (var name in phoneBook)
                            {
                                Console.WriteLine($"{name.Key} -> {name.Value}");
                            }
                        }
                        break;
                }

                inputLine = Console.ReadLine();
            }

        }
    }
}