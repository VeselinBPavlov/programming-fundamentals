﻿namespace Passed
{    
    using System;

    public class StrartUp
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
                Console.WriteLine("Passed!");
        }
    }
}
