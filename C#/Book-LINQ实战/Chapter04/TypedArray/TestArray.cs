using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypedArray
{
    static class TestArray
    {
        static void Main()
        {
            Book[] books = {
                new Book { Title = "LINQ in Action" },
                new Book{ Title="LINQ for Fun"},
                new Book{ Title="Extreme LNQ"}
            };
            var titles =
                books
                .Where(book => book.Title.Contains("Action"))
                .Select(book => book.Title);

            ObjectDumper.Write(titles);

            Console.ReadKey();
        }
    }
}
