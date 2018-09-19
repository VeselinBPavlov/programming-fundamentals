namespace MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var nameAndData = GetNameAndData();

            PritStudentData(nameAndData);
        }

        public static void PritStudentData(SortedDictionary<string, Student> nameAndData)
        {
            foreach (var name in nameAndData)
            {
                Console.WriteLine($"{name.Key}");
                Console.WriteLine($"Comments:");
                foreach (var comment in name.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                var dates = name.Value.Date.OrderBy(x => x).ToList();
                foreach (var data in dates)
                {
                    Console.WriteLine($"-- {data:dd/MM/yyyy}");
                }
            }
        }

        public static SortedDictionary<string, Student> GetNameAndData()
        {
            var command = Console.ReadLine();
            var nameAndData = new SortedDictionary<string, Student>();

            while (command != "end of dates")
            {
                var studentData = command
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = studentData[0];
                var dateList = studentData.Skip(1).ToArray();                             

                if (!nameAndData.ContainsKey(name))
                {
                    var student = new Student()
                    {
                        Name = name,
                        Date = new List<string>(),
                        Comments = new List<string>()
                    };

                    nameAndData.Add(name, student);
                }
                nameAndData[name].Date.AddRange(dateList);                

                command = Console.ReadLine();
            }

            var command2 = Console.ReadLine();

            while (command2 != "end of comments")
            {
                var commentsData = command2
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = commentsData[0];
                var comment = commentsData[1];

                if (nameAndData.ContainsKey(name))
                {
                    nameAndData[name].Comments.Add(comment);
                }               

                command2 = Console.ReadLine();
            }

            return nameAndData;
        }
    }

    public class Student
    {
        public List<string> Comments { get; set; }
        public List<string> Date { get; set; }
        public string Name { get; set; }
    }
}
