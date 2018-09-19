namespace ParkingValidation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var registrations = int.Parse(Console.ReadLine());
            var registerdCars = new Dictionary<string, string>();


            for (int i = 0; i < registrations; i++)
            {
                var driverData = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
              
                var operation = driverData[0];
                var driverName = driverData[1];

                if (operation == "register")
                {                    
                    var plateNumber = driverData[2];

                    var isNumberValid = IsNumberValid(plateNumber);

                    if (registerdCars.ContainsKey(driverName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registerdCars[driverName]}");
                        continue;
                    }

                    if (registerdCars.ContainsValue(plateNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {plateNumber} is busy");
                        continue;
                    }

                    if (isNumberValid == false)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plateNumber}");
                        continue;
                    }              

                    registerdCars.Add(driverName, plateNumber);
                    Console.WriteLine($"{driverName} registered {plateNumber} successfully");
                }
                else if (operation == "unregister")
                {
                    if (registerdCars.ContainsKey(driverName))
                    {
                        registerdCars.Remove(driverName);
                        Console.WriteLine($"user {driverName} unregistered successfully ");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {driverName} not found");
                    }
                }
            }

            foreach (var driver in registerdCars)
            {
                Console.WriteLine($"{driver.Key} => {driver.Value}");
            }
        }

        public static bool IsNumberValid(string plateNumber)
        {
            var isNumberValid = true;

            if (plateNumber.Length != 8)
            {
                isNumberValid = false;
                return isNumberValid;
            }
            var chars = plateNumber.Where(x => Char.IsUpper(x)).ToArray();
            if (chars.Length != 4)
            {
                isNumberValid = false;
                return isNumberValid;
            }
            var numbers = plateNumber.Where(x => Char.IsDigit(x)).ToArray();
            if (numbers.Length != 4)
            {
                isNumberValid = false;
                return isNumberValid;
            }

            return isNumberValid;
        }
    }
}
