namespace FixEmails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var personalEmails = new Dictionary<string, string>();

            while (input != "stop")
            {
                var name = input;
                var email = Console.ReadLine();

                if (email.EndsWith("uk") || email.EndsWith("us"))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    personalEmails.Add(name, email);
                }

                input = Console.ReadLine();
            }

            foreach (var person in personalEmails)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
