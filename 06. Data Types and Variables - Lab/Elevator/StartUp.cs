namespace Elevator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int courses = persons / capacityOfElevator;

            if (persons % capacityOfElevator > 0)
                courses++;

            Console.WriteLine(courses);
        }
    }
}
