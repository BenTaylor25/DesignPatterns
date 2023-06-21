
namespace Flyweight
{
    class Book
    {
        string name;
        double price;
        BookType bookType;

        public Book(string name, double price, string subgenre, string genre)
        {
            this.name = name;
            this.price = price;
            this.bookType = BookFactory.GetBookType(subgenre, genre);
        }

        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine(bookType.subgenre);
            Console.WriteLine(bookType.genre);
        }
    }

    class BookType
    {
        public string subgenre { get; }
        public string genre { get; }

        public BookType(string subgenre, string genre)
        {
            this.subgenre = subgenre;
            this.genre = genre;
        }
    }

    class BookFactory
    {
        static Dictionary<string, BookType> bookTypes = new();

        public static BookType GetBookType(string subgenre, string genre)
        {
            if (!bookTypes.ContainsKey(subgenre))
            {
                Console.WriteLine("Flyweight Created");
                bookTypes.Add(subgenre, new BookType(subgenre, genre));
            }
            return bookTypes[subgenre];
        }
    }

    class Flyweight
    {
        public static void Execute()
        {
            Book book1 = new("book1", 5.00, "slasher", "horror");
            Book book2 = new("book2", 7.00, "slasher", "horror");
            Book book3 = new("book3", 6.00, "slasher", "horror");

            Book book4 = new("book4", 5.00, "psychological", "horror");
            Book book5 = new("book5", 7.00, "psychological", "horror");
            Book book6 = new("book6", 6.00, "psychological", "horror");

            Console.WriteLine();

            // Should only say "Flyweight Created" twice
            // But we can access all properties of all books

            book1.PrintInfo();
            Console.WriteLine();
            book2.PrintInfo();
            Console.WriteLine();
            book4.PrintInfo();
        }
    }
}