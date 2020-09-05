using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.BLL
{
    public class DomainSpecificOperators
    {
        public static IEnumerable<Book> Where(
            this IEnumerable<Book> source,
            Func<Book, Boolean> predicate)
        {
            foreach (Book book in source)
            {
                Console.WriteLine("processing book \"{0}\" in DomainSpecificOperators.Where", book.Title);
                if (predicate(book))
                    yield return book;
            }
        }

        public static IEnumerable<TResult> Select<TResult>(
            this IEnumerable<Book> source,
            Func<Book, TResult> selector)
        {
            foreach (Book book in source)
            {
                Console.WriteLine("processing book \"{0}\" in DomainSpecificOperators.Select<TResult>", book.Title);
                yield return selector(book);
            }
        }
    }
}
