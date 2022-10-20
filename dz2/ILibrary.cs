namespace dz2
{
    public interface ILibrary
    {
        bool addBook(Book book);
        Book getBook(int Id);
        IEnumerable<Book> getAllBooks();
        IEnumerable<Book> getBooksOfAuthor(string Author);
    }
}
