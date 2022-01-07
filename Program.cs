using System;
using System.Collections.Generic;

namespace FluentBuilderDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var author = new AuthorBuilder()
                             .WithFirstName("John Ronald Reuel")
                             .WithLastName("Tolkien")
                             .HavingBook(bookBuilder =>
                             {
                                 bookBuilder.WithName("The Lord of the Rings")
                                            .WithNumberOfChapters(55)
                                            .WithNumberOfPages(1178); 
                             })
                             .HavingBook(bookBuilder =>
                             {
                                 bookBuilder.WithName("The Hobbit")
                                            .WithNumberOfChapters(19)
                                            .WithNumberOfPages(310);
                             })
                             .WithBirthYear(1892)
                             .Build();

        }
    }
}
