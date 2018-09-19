namespace AnonymousThreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var command = Console.ReadLine().ToLower();

            while (command != "3:1")
            {
                var commandData = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var action = commandData[0];
                
                switch (action)
                {
                    case "merge":
                        {
                            var startIndex = int.Parse(commandData[1]);
                            var endIndex = int.Parse(commandData[2]);

                            if (startIndex < 0)
                            {
                                startIndex = 0;
                            }
                            if (startIndex > input.Count - 1)
                            {
                                startIndex = input.Count - 1;
                            }
                            if (endIndex < 0)
                            {
                                endIndex = 0;
                            }
                            if (endIndex > input.Count - 1)
                            {
                                endIndex = input.Count - 1;
                            }                           

                            var count = endIndex - startIndex + 1;                            
                            var tempList = input.Skip(startIndex).Take(count).ToList();
                            var tempString = string.Join("", tempList);
                            input.RemoveRange(startIndex, count);
                            input.Insert(startIndex, tempString);
                        }
                        break;
                    case "divide":
                        {
                            var index = int.Parse(commandData[1]);
                            var partitions = int.Parse(commandData[2]);

                            var substring = input[index];
                            var tempList = new List<string>();
                            var parts = substring.Length / partitions;

                            for (int i = 0; i < substring.Length; i += parts)
                            {                         
                                if (tempList.Count < partitions - 1)
                                {
                                    var tempString = substring.Substring(i, parts);
                                    tempList.Add(tempString);
                                }
                                else
                                {
                                    var tempString = substring.Substring(i, substring.Length - i);
                                    tempList.Add(tempString);
                                    break;
                                }                                
                            }

                            input.RemoveAt(index);
                            input.InsertRange(index, tempList);
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
