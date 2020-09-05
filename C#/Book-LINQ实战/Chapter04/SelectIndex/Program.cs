using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqBooks.Common;
using Common;

namespace SelectIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var books =
                SampleData.Books
                .Select((book, index) => new { index, book.Title })
                .OrderBy(book => book.Title);
            ObjectDumper.Write(books);

            Console.ReadKey();
        }
    }
}
