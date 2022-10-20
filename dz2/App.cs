namespace dz2
{
    public static class App
    {
        public static void PrintVariants()
        {
            Console.WriteLine("1 - посмотреть список книг библиотеки\n" +
                "2 - добавить книгу\n" +
                "3 - получить книгу по ID\n" +
                "4 - получить все книги автора\n");
        }

        public static string Stdi(string text)
        {
            string? step;

            Console.Write(text);
            step = Console.ReadLine();
            if (!string.IsNullOrEmpty(step))
                return step;
            return string.Empty;
        }
    }
}