namespace dz2
{
    internal class Library : ILibrary
    {
        private static Library? _instance;
        private List<Book> Books { get; set; } = new();
        private Library() { }
        public static Library GetInstance() {
            _instance ??= new Library();
            return _instance;
        }

        public bool addBook(Book book)
        {
            book.Id = GenerateUniqueId();
            try
            {
                Books.Add(book);
                return true;
            } catch
            {
                return false;
            }
        }

        public IEnumerable<Book> getAllBooks()
        {
            return Books;
        }

        public Book getBook(int Id)
        {
            Book? book = Books.Find(match: b => b.Id == Id);
            if (book == null) throw new Exception($"Нет книги с ID {Id}");
            return book;
        }

        public IEnumerable<Book> getBooksOfAuthor(string Author)
        {
            List<Book> books = Books.FindAll(match: b => b.Author == Author);
            if (books.Count == 0) throw new Exception($"Нет книг Автора: {Author}");
            return books;
        }

        private int GenerateUniqueId()
        {
            if (Books.Count > 0) return Books[^1].Id + 1;
            return 0;
        }
    }
}
