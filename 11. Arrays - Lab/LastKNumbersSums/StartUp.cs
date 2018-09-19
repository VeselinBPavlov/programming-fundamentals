namespace LastKNumbersSums
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var numbers  = int.Parse(Console.ReadLine());
            var sequence = int.Parse(Console.ReadLine());

            var array = new long[numbers];
            array[0] = 1;

            for (int i = 1; i < numbers; i++)
            {
                for (int j = 1; j <= sequence; j++)
                {
                    if (i - j >= 0)
                    {
                        array[i] += array[i - j];
                        continue;
                    }
                    break;
                }                
            }
            Console.WriteLine(string.Join(" ", array));
        }        
    }
}
