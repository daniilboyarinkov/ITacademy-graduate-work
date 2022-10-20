namespace dz2
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;

        public Book(string title, string author, string year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }

        public override string ToString()
        {
            return $"Id: {Id} \tНазвание: {Title} \tАвтор: {Author} \tГод: {Year} г.";
        }
    }
}
