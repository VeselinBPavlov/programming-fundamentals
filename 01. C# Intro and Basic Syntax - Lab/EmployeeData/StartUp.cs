namespace EmployeeData
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int idNumber = int.Parse(Console.ReadLine());
            double monthSalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {idNumber:d8}");
            Console.WriteLine($"Salary: {monthSalary:f2}")
                

        }
    }
}
