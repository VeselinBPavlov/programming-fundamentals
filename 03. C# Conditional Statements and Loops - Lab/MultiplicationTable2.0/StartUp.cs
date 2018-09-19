namespace MultiplicationTable2._0
{
    using System;

     public class StartUp
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var sum = 0;


            if (b > 10)
            {
                sum = a * b;
                Console.WriteLine($"{a} X {b} = {sum}");
            }
            else
            {
                for (int i = b; i <= 10; i++)
                {
                    sum = a * i;
                    Console.WriteLine($"{a} X {i} = {sum}");
                }
            }
        }
    }
}
