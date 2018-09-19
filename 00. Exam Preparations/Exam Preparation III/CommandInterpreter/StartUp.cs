namespace CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var manipulation = command.Split(' ').ToArray();
                
                if (manipulation[0] == "rollLeft")
                {
                    var rollTimes = int.Parse(manipulation[1]);
                   
                    if (rollTimes < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                   
                    for (int i = 0; i < rollTimes % inputLine.Count; i++)
                    {
                        var tempStr = inputLine[0];
                        inputLine.RemoveAt(0);
                        inputLine.Add(tempStr);
                    }                                      
                }
                else if (manipulation[0] == "rollRight")
                {                   
                    var rollTimes = int.Parse(manipulation[1]);
                   
                    if (rollTimes < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                   
                    for (int i = 0; i < rollTimes % inputLine.Count; i++)
                    {
                        var tempStr = inputLine[inputLine.Count - 1];
                        inputLine.RemoveAt(inputLine.Count - 1);
                        inputLine.Insert(0, tempStr);
                    }
                }
                else if (manipulation[0] == "reverse")
                {                    
                    var index = int.Parse(manipulation[2]);
                    var count = int.Parse(manipulation[4]);

                    if (index < 0 || index >= inputLine.Count || count < 0 || index + count > inputLine.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                    var tempList = new List<string>();
                    tempList = inputLine.Skip(index).Take(count).Reverse().ToList();
                    inputLine.RemoveRange(index, count);
                    inputLine.InsertRange(index, tempList);
                }
                else if (manipulation[0] == "sort")
                {                    
                     var index = int.Parse(manipulation[2]);
                     var count = int.Parse(manipulation[4]);

                     if (index < 0 || index >= inputLine.Count || count < 0 || index + count > inputLine.Count)
                     {
                         Console.WriteLine("Invalid input parameters.");
                         command = Console.ReadLine();
                         continue;
                     }
                     var tempList = new List<string>();
                     tempList = inputLine.Skip(index).Take(count).OrderBy(x => x).ToList();
                     inputLine.RemoveRange(index, count);
                     inputLine.InsertRange(index, tempList);                    
                }               

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", inputLine)}]");
        }
    }
}
