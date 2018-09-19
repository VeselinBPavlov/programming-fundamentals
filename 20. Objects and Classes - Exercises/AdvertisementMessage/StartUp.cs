namespace AdvertisementMessage
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var random = new Random();         

            var phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            var autors = new string[] 
            {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            var cities = new string[] 
            {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            for (int i = 0; i < n; i++)
            {
                var message = new Message();
                message.Phrase = phrases[random.Next(0, phrases.Length)];
                message.Event = events[random.Next(0, events.Length)];
                message.Autor = autors[random.Next(0, autors.Length)];
                message.City = cities[random.Next(0, cities.Length)];

                Console.WriteLine($"{message.Phrase} {message.Event} {message.Autor} - {message.City}");
            }
        }
    }

    public class Message
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Autor { get; set; }
        public string City { get; set; }
    }
}
