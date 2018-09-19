namespace SafeManipulation
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();           

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                try
                {
                    if (command[0] == "END")
                    {
                        break;
                    }

                    if (command[0] == "Reverse")
                    {
                        Array.Reverse(array);
                        continue;
                    }

                    if (command[0] == "Distinct")
                    {
                        array = array.Distinct().ToArray();
                        continue;
                    }

                    var index = int.Parse(command[1]);
                    var word = command[2];
                    array[index] = word;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
            
            Console.WriteLine(String.Join(", ", array));
        }
    }
}
