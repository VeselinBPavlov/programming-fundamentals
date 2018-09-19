namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine().ToLower().Split(' ');

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "exchange":
                        {
                            var index = int.Parse(command[1]);
                            if (index >= 0 && index < numbersList.Count)
                            {
                                var tempList = numbersList.Take(index + 1).ToList();
                                numbersList.RemoveRange(0, index + 1);
                                numbersList.AddRange(tempList);
                            }
                            else
                            {
                                Console.WriteLine($"Invalid index");
                            }
                        }
                        break;
                    case "max":
                        {
                            if (command[1] == "odd")
                            {
                                var tempNum = numbersList.Where(x => x % 2 == 1).OrderByDescending(x => x).ToList();
                                if (tempNum.Any())
                                {
                                    Console.WriteLine(numbersList.LastIndexOf(tempNum.First()));
                                }
                                else
                                {
                                    Console.WriteLine("No matches");
                                }
                            }

                            if (command[1] == "even")
                            {
                                var tempNum = numbersList.Where(x => x % 2 == 0).OrderByDescending(x => x).ToList();
                                if (tempNum.Any())
                                {
                                    Console.WriteLine(numbersList.LastIndexOf(tempNum.First()));
                                }
                                else
                                {
                                    Console.WriteLine("No matches");
                                }
                            }
                        }
                        break;
                    case "min":
                        {
                            if (command[1] == "odd")
                            {
                                var tempNum = numbersList.Where(x => x % 2 == 1).OrderBy(x => x).ToList();
                                if (tempNum.Any())
                                {
                                    Console.WriteLine(numbersList.LastIndexOf(tempNum.First()));
                                }
                                else
                                {
                                    Console.WriteLine("No matches");
                                }
                            }

                            if (command[1] == "even")
                            {
                                var tempNum = numbersList.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
                                if (tempNum.Any())
                                {
                                    Console.WriteLine(numbersList.LastIndexOf(tempNum.First()));
                                }
                                else
                                {
                                    Console.WriteLine("No matches");
                                }
                            }
                        }
                        break;
                    case "first":
                        {
                            var count = int.Parse(command[1]);                           
                            
                            if (count <= numbersList.Count)
                            {
                                var tempList = new List<int>();

                                if (command[2] == "odd")
                                {
                                    tempList = numbersList.Where(x => x % 2 == 1).ToList();

                                    if (tempList.Any() == false)
                                    {
                                        Console.WriteLine("[]");
                                    }
                                    else if (tempList.Count <= count)
                                    {
                                        Console.WriteLine($"[{string.Join(", ", tempList)}]");
                                    }
                                    else if (tempList.Count > count)
                                    {
                                        var firstOdds = tempList.Take(count).ToList();
                                        Console.WriteLine($"[{string.Join(", ", firstOdds)}]");
                                    }
                                }
                                else if (command[2] == "even")
                                {
                                    tempList = numbersList.Where(x => x % 2 == 0).ToList();

                                    if (tempList.Any() == false)
                                    {
                                        Console.WriteLine("[]");
                                    }
                                    else if (tempList.Count <= count)
                                    {
                                        Console.WriteLine($"[{string.Join(", ", tempList)}]");
                                    }
                                    else if (tempList.Count > count)
                                    {
                                        var firstEvens = tempList.Take(count).ToList();
                                        Console.WriteLine($"[{string.Join(", ", firstEvens)}]");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid count");
                            }
                        }
                        break;
                    case "last":
                        {
                            var count = int.Parse(command[1]);

                            if (count <= numbersList.Count)
                            {
                                var tempList = new List<int>();

                                if (command[2] == "odd")
                                {
                                    tempList = numbersList.Where(x => x % 2 == 1).Reverse().ToList();

                                    if (tempList.Any() == false)
                                    {
                                        Console.WriteLine("[]");
                                    }
                                    else if (tempList.Count <= count)
                                    {
                                        tempList.Reverse();
                                        Console.WriteLine($"[{string.Join(", ", tempList)}]");
                                    }
                                    else if (tempList.Count > count)
                                    {
                                        var firstOdds = tempList.Take(count).ToList();
                                        firstOdds.Reverse();
                                        Console.WriteLine($"[{string.Join(", ", firstOdds)}]");
                                    }
                                }
                                else if (command[2] == "even")
                                {
                                    tempList = numbersList.Where(x => x % 2 == 0).Reverse().ToList();

                                    if (tempList.Any() == false)
                                    {
                                        Console.WriteLine("[]");
                                    }
                                    else if (tempList.Count <= count)
                                    {
                                        tempList.Reverse();
                                        Console.WriteLine($"[{string.Join(", ", tempList)}]");
                                    }
                                    else if (tempList.Count > count)
                                    {
                                        var firstEvens = tempList.Take(count).ToList();
                                        firstEvens.Reverse();
                                        Console.WriteLine($"[{string.Join(", ", firstEvens)}]");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid count");
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().ToLower().Split(' ');
            }

            Console.WriteLine($"[{string.Join(", ", numbersList)}]");
        }
    }
}
