using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using LinqBooks.Common;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            var authors = SampleData.Books
                .SelectMany(book => book.Authors)
                .Distinct()
                .Select(author => author.FirstName + " " + author.LastName);

            ObjectDumper.Write(authors);

            Console.ReadKey();
        }
    }
}
