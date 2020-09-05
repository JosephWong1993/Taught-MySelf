using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.BLL
{
    public static class CustomImplementation
    {
        public static IEnumerable<TSource> Where<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            Console.WriteLine("in CustomImplementation.Where<TSource>");
            return Enumerable.Where<TSource>(source, predicate);
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
        {
            Console.WriteLine("in CustomImplementation.Select<TSource,TResult>");
            return Enumerable.Select(source, selector);
        }
    }
}
