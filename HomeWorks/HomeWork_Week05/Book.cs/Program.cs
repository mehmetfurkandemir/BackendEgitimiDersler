namespace Book.cs;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public string ISBN { get; set; }
    public int MyProperty { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string title, string author, int pages, string isbn)
    {
        Title = title;
        Author = author;
        Pages = pages;
        ISBN = isbn;
        IsBorrowed = false;
    }

    public void Borrow()
    {
        if (!IsBorrowed)
        {
            IsBorrowed = true;
            Console.WriteLine($"{Title} adlı kitap ödünç alındı.");
        }
        else
        {
            Console.WriteLine($"{Title} zaten ödünç alınmış.");
        }
    }

    public void Return()
    {
        if (IsBorrowed)
        {
            IsBorrowed = false;
            System.Console.WriteLine($"{Title} adlı kitap iade edildi.");
        }
        else
        {
            System.Console.WriteLine($"{Title} adlı kitap kütüphanede mevcuttur.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Başlık: {Title}, Yazar: {Author}, Sayfa Sayısı: {Pages}, ISBN: {ISBN}, Ödünç Durumu: {(IsBorrowed ? "Ödünç Alınmış" : "Mevcut")}");
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} adlı kitap kütüphaneye eklendi.");
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }

        public void BorrowBook(string isbn)
        {
            Book book = books.Find(b => b.ISBN == isbn);
            if (book != null)
            {
                book.Borrow();
            }
            else
            {
                Console.WriteLine($"ISBN {isbn} numaralı kitap bulunamadı.");
            }
        }

        public void ReturnBook(string isbn)
        {
            Book book = books.Find(b => b.ISBN == isbn);
            if (book != null)
            {
                book.Return();
            }
            else
            {
                Console.WriteLine($"ISBN {isbn} numaralı kitap bulunamadı.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("Kürk Mantolu Madonna", "Sabahattin Ali", 430, "978-3-16-148410-0");
            Book book2 = new Book("Kuyucaklı Yusuf", "Sabahattin Ali", 1590, "978-1-56619-909-4");
            Book book3 = new Book("Eylül", "Mehmet Rauf", 352, "978-0-312-34567-8");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.DisplayAllBooks();
            Console.WriteLine();


            library.BorrowBook("978-3-16-148410-0");
            Console.WriteLine();

            library.BorrowBook("978-0-54-342279-9");
            Console.WriteLine();

            library.ReturnBook("978-0-14-312779-6");
            Console.WriteLine();

            library.DisplayAllBooks();
        }
    }
}