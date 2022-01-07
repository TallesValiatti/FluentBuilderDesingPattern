namespace FluentBuilderDesingPattern
{
    public class BookBuilder
    {
        private string _name;
        private int _numberOfPages;
        private int _numberOfChapters;

        public BookBuilder()
        {
        }

        public BookBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public BookBuilder WithNumberOfPages(int numberOfPages)
        {
            _numberOfPages = numberOfPages;
            return this;
        }

        public BookBuilder WithNumberOfChapters(int numberOfChapters)
        {
            _numberOfChapters = numberOfChapters;
            return this;
        }

        public Book Build() 
        {
            return new Book(_name, _numberOfPages, _numberOfChapters);
        }
    }
}
