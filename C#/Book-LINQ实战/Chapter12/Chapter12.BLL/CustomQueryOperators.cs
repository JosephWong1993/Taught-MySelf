using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.BLL
{
    public static class CustomQueryOperators
    {
        public static decimal TotalPrice(this IEnumerable<Book> books)
        {
            if (books == null)
                throw new ArgumentNullException("books");

            decimal result = 0;
            foreach (Book book in books)
            {
                if (book != null && book.Price != null)
                    result += book.Price.Value;
            }
            return result;
        }

        public static Book Min(this IEnumerable<Book> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            Book result = null;
            foreach (Book book in source)
            {
                if ((result == null) || (book.PageCount < result.PageCount))
                    result = book;
            }
            return result;
        }

        public static IEnumerable<Book> Books(this Publisher publisher, IEnumerable<Book> books)
        {
            return books.Where(book => book.Publisher1 == publisher);
        }

        public static Boolean IsExpensive(this Book book)
        {
            if (book == null)
                throw new ArgumentNullException("book");

            return (book.Price > 50) || ((book.Price / book.PageCount) > 0.10M);    
        }
    }
}
