namespace CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var cryptMessage = Console.ReadLine();
                     
            
            while (cryptMessage != "Over!")
            {
                var messageLength = int.Parse(Console.ReadLine());

                var decryptMessage = new StringBuilder();
                var messagePattern = $@"^(\d+)([A-Za-z]{{{messageLength}}})([^A-Za-z]+)?$";
                var match = Regex.Match(cryptMessage, messagePattern);

                if (match.Success == false)
                {
                    cryptMessage = Console.ReadLine();
                    continue;
                }

                var message = match.Groups[2].Value;
                var indexes = cryptMessage.Where(x => Char.IsDigit(x)).Select(x => int.Parse(x.ToString())).ToList();

                foreach (var number in indexes)
                {
                    if (number < message.Length)
                    {
                        decryptMessage.Append(message[number]);
                    }
                    else
                    {
                        decryptMessage.Append(" ");
                    }
                }

                Console.WriteLine($"{message} == {decryptMessage}");

                cryptMessage = Console.ReadLine();
            }
        }
    }
}
