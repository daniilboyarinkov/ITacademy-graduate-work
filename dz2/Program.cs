namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            // инстанс библио
            Library library = Library.GetInstance();

            // initial books
            Book book1 = new("Title1", "Author", "2022");
            Book book2 = new("Title2", "Author", "2000");
            Book book3 = new("Title3", "Author", "2002");
            Book book4 = new("Title4", "Author1", "2012");
            Book book5 = new("Title5", "Author1", "1966");
            Book book6 = new("Title6", "Author1", "1988");
            Book book7 = new("Title7", "Author2", "1899");
            Book book8 = new("Title8", "Author2", "1999");
            Book book9 = new("Title9", "Author2", "2010");
            Book book0 = new("Title0", "Author2", "2001");
            List<Book> books = new() { book1, book2, book3, book4, book5, book6, book7, book8, book9, book0 };

            // добавление книг в библиотеку
            books.ForEach(b => library.addBook(b));

            // книги библиотеки
            List<Book> LibraryBooks = (List<Book>)library.getAllBooks();

            // Основной цикл программы
            while (true)
            {
                App.PrintVariants();
                string? variant = Console.ReadLine()?.Trim();
                // get all books
                if (variant == "1")
                {
                    Console.Clear();
                    LibraryBooks.ForEach(b => Console.WriteLine(b.ToString()));
                    Console.WriteLine();
                }
                // add new book
                else if (variant == "2")
                {
                    string title = App.Stdi("Введите название книги: ");
                    string author = App.Stdi("Введите автора книги: ");
                    string year = App.Stdi("Введите год выпуска книги: ");
                    Console.Clear();

                    Book newBook = new(title, author, year);

                    library.addBook(newBook);
                    LibraryBooks = (List<Book>)library.getAllBooks();
                }
                // get book by id
                else if (variant == "3")
                {
                    string Id = App.Stdi("Введите Id: ");
                    Console.Clear();

                    try
                    {
                        Book temp = library.getBook(Int32.Parse(Id));
                        Console.WriteLine(temp.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                // get all books of author
                else if (variant == "4")
                {
                    string author = App.Stdi("Введите автора книги: ");
                    Console.Clear();

                    try
                    {
                        List<Book> temp = (List<Book>)library.getBooksOfAuthor(author);
                        temp.ForEach(t => Console.WriteLine(t.ToString()));
                        Console.WriteLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                // skipping enters
                else if (variant == "") { }
                // skipping spaces
                else if (variant == " ") { }
                else
                {
                    Console.WriteLine("Извините, но такой команды нет.\n Введите существующую команду: ");
                    App.PrintVariants();
                }
            }
        }
    }
}
