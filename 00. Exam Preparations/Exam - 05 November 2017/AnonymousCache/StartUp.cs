namespace AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            var dataInfo = new Dictionary<string, Dictionary<string, long>>();
            var cashInfo = new Dictionary<string, Dictionary<string, long>>();
            var sumInfo = new Dictionary<string, long>();


            while (command != "thetinggoesskrra")
            {
                var data = command
                    .Split(" ->|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();               

                if (data.Length == 1)
                {
                    var dataSet = data[0];
                    dataInfo[dataSet] = new Dictionary<string, long>();
                    sumInfo.Add(dataSet, 0);

                    if (cashInfo.ContainsKey(dataSet))
                    {
                        dataInfo[dataSet] = cashInfo[dataSet];

                        foreach (var pair in dataInfo[dataSet])
                        {
                            sumInfo[dataSet] += pair.Value;
                        }
                        cashInfo.Remove(dataSet);
                    }
                }
                else
                {
                    var dataSet = data[2];
                    var dataKey = data[0];
                    var dataSize = long.Parse(data[1]);

                    if (dataInfo.ContainsKey(dataSet))
                    {
                        dataInfo[dataSet].Add(dataKey, dataSize);
                        sumInfo[dataSet] += dataSize;
                    }
                    else
                    {
                        if (cashInfo.ContainsKey(dataSet) == false)
                        {
                            cashInfo.Add(dataSet, new Dictionary<string, long>());
                        }                        
                        cashInfo[dataSet].Add(dataKey, dataSize);
                    }
                }

                command = Console.ReadLine();
            }

            if (dataInfo.Count > 0)
            {
                var bestSet = sumInfo.OrderByDescending(x => x.Value).Select(x => x.Key).ToList().First();
                var bestSum = sumInfo.OrderByDescending(x => x.Value).Select(x => x.Value).ToList().First();

                Console.WriteLine($"Data Set: {bestSet}, Total Size: {bestSum}");
                foreach (var key in dataInfo[bestSet])
                {
                    Console.WriteLine($"$.{key.Key}");
                }
            }            
        }
    }
}
