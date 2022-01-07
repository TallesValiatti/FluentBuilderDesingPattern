using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentBuilderDesingPattern
{
    public class AuthorBuilder
    {
        private string _firstName;
        private string _lastName;
        private int _birthYear;
        private IList<Book> _books;
        
        public AuthorBuilder()
        {
            _books = new List<Book>();
        }
        public AuthorBuilder WithFirstName(string firstName)
        {
            this._firstName = firstName;
            return this;
        }

        public AuthorBuilder WithLastName(string lastName)
        {
            this._lastName = lastName;
            return this;
        }

        public AuthorBuilder WithBirthYear(int birthYear)
        {
            this._birthYear = birthYear;
            return this;
        }

        public AuthorBuilder HavingBook(Action<BookBuilder> action)
        {
            var builder = new BookBuilder();
            action(builder);

            _books.Add(builder.Build());

            return this;
        }
        public Author Build()
        {
            return new Author(_firstName, 
                              _lastName,
                              _birthYear, 
                              _books);
        }
    }
}
