namespace DecryptingMessage
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            string decrypt = "";

            for (int i = 0; i < num; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter += (char)key;
                letter.ToString();
                decrypt += letter;             
            }
            Console.WriteLine(decrypt);
        }
    }
}
