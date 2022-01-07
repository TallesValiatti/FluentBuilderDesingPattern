using System.Collections.Generic;
using System.Linq;

namespace FluentBuilderDesingPattern
{
    public class Author
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int BirthYear { get; private set; }
        private IEnumerable<Book> _books;
        public IEnumerable<Book> Books
        {
            get { return _books.ToList().AsReadOnly(); }
        }

        public Author(string firstName, string lastName, int birthYear, IEnumerable<Book> books)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthYear = birthYear;
            this._books = books;
        }
    }
}
