namespace ManipulateArray
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
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Reverse")
                {
                    Array.Reverse(array);
                    continue;
                }

                if(command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                    continue;
                }               

              var index = int.Parse(command[1]);
              var word = command[2];
              array[index] = word;

            }

            Console.WriteLine(String.Join(", ", array));
        }
    }
}