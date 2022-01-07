namespace FluentBuilderDesingPattern
{
    public class Book
    {
        public string Name { get; private set; }
        public int NumberOfPages { get; private set; }
        public int NumberOfChapters { get; private set; }

        public Book(string name, int numberOfPages, int numberOfChapters)
        {
            this.Name = name;
            this.NumberOfPages = numberOfPages;
            this.NumberOfChapters = numberOfChapters;
        }
    }
}


