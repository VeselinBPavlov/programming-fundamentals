namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var filePaths = new List<string>();
            var fileRegister = new Dictionary<string, long>();

            for (int i = 0; i < n; i++)
            {
                var filePath = Console.ReadLine();                
                filePaths.Add(filePath);                
            }

            var searchedFile = Console.ReadLine().Split(' ').ToArray();
            var searchedExtention = searchedFile[0];
            var searchedRoot = searchedFile[2];

            foreach (var file in filePaths)
            {
                var path = file.Split(new char[] { '\\', ';' }).Select(x => x.Trim()).ToArray();
                var root = path[0];
                var fileKey = path[path.Length - 2];
                var extentionArr = fileKey.Split('.').Select(x => x.Trim()).ToArray();
                var extention = extentionArr.Last();

                if (root == searchedRoot && extention == searchedExtention)
                {                    
                    var size = long.Parse(path[path.Length - 1]);

                    if (fileRegister.ContainsKey(fileKey) == false)
                    {
                        fileRegister.Add(fileKey, size);
                    }
                    else
                    {
                        fileRegister[fileKey] = size;
                    }
                }
            }

            if (fileRegister.Any())
            {
                foreach (var file in fileRegister.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
