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
                             .WithlastName("Tolkien")
                             .HavingBook(bookBuilder =>
                             {
                                 bookBuilder.WithName("The Lord of the Rings")
                                            .WithNumberOfChapters(1178)
                                            .WithNumberOfPages(55);
                             })
                             .HavingBook(bookBuilder =>
                             {
                                 bookBuilder.WithName("The Hobbit")
                                            .WithNumberOfChapters(310)
                                            .WithNumberOfPages(19);
                             })
                             .WithBirthYear(1892)
                             .Build();

        }
    }
}
