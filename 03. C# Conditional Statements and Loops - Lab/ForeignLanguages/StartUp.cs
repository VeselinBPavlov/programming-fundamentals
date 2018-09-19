namespace ForeignLanguages
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var counrty = Console.ReadLine().ToLower();

            var language = "";

            if (counrty == "england" || counrty == "usa")
                language = "English";
            else if (counrty == "spain" || counrty == "argentina" || counrty == "mexico")
                language = "Spanish";
            else
                language = "unknown";

            Console.WriteLine(language); 
        }
    }
}
