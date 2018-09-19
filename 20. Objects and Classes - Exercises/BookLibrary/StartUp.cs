namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());

            var bookList = new Dictionary<string, decimal>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var bookData = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var book = GetBookData(bookData);

                if (!bookList.ContainsKey(book.Autor))
                {
                    bookList.Add(book.Autor, book.Price);
                }
                else
                {
                    bookList[book.Autor] += book.Price;
                }
            }

            foreach (var autor in bookList.OrderByDescending(p => p.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{autor.Key} -> {autor.Value:f2}");
            }
        }

        public static Book GetBookData(List<string> bookData)
        {
            return new Book
            {
                //Title = bookData[0],
                Autor = bookData[1],
                // Publisher = bookData[2],
                //ReleaseDate = DateTime.ParseExact(bookData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                //ISBN = bookData[4],
                Price = decimal.Parse(bookData[5])
            };
        }
    }

    public class Book
    {
        //public string Title { get; set; }
        public string Autor { get; set; }
        //public string Publisher { get; set; }
        //public DateTime ReleaseDate { get; set; }
        //public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    public class Library
    {
        //public string Name { get; set; }
        //public List<Book> Books { get; set; }
    }
}
