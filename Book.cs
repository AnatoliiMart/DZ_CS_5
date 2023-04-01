
namespace DZ_CS_5
{
    internal class Book
    {
        private string? author;
        private string? title;


        public Book() { }
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
           
        }

        public string? Author { get => author;}
        public string? Title { get => title;}
       

        public void InputData()
        {
            Console.Write("Enter book author:\t");
            author = Console.ReadLine();
            Console.Write("Enter book title:\t");
            title = Console.ReadLine();

            
        }

        public override string ToString()
        {
            return "Author\t" + Author +"\nTitle\t" + Title + "\n";
        }

    }
    class Library
    {
        public List<Book> books = new()
            {
                new Book("Taras Shevchenko", "Kobzar"),
                new Book("Ivan Franko", "Zakhar Berkut"),
                new Book("Ivan Karpenko-Karyj", "Sto tysyach"),
                new Book("Lesia Ukrainka", "Contra spem spero!"),
                new Book("Mykhajlo Kotsiubynskii", "Fata Morgana"),
                new Book("Hryhorii Skovoroda", "Svit lovyv mene, ta ne vpijmav"),
            };
        public void AddBook()
        {
            Console.WriteLine("Adding a new book to library");
            Book obj = new();
            obj.InputData();
            books.Add(obj);
            Console.WriteLine();
            Console.WriteLine();
        }
        public void DeleteBook(string AuthorName)
        {
            for (int i = 0; i < books.Count; i++) 
            {
                if (books[i].Author == AuthorName)
                {
                    Console.WriteLine("Book " + books[i].Author + " " + books[i].Title + " was deleted!");
                    Console.WriteLine();
                    books.Remove(books[i]);
                }
            }
        }
        public int GetAmountOfBooks()
        {
            return books.Count;
        }
        

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                {
                    return books[index];
                }
                else 
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index <= books.Count)
                {
                    books[index] = value;
                }
                else 
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
