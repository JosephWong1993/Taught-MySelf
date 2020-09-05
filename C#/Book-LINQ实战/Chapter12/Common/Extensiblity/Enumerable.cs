using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Extensiblity
{
    public static class SumExtensions
    {
        #region 参考Sum操作符实现的LongSum

        public static long LongSum(this IEnumerable<long> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            long sum = 0;
            checked
            {
                foreach (int v in source)
                {
                    sum += v;
                }
            }
            return sum;
        }

        public static long? LongSum(this IEnumerable<long?> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            long? sum = 0;
            checked
            {
                foreach (int? v in source)
                {
                    if (v != null) sum += v;
                }
            }
            return sum;
        }

        public static long LongSum<T>(this IEnumerable<T> source, Func<T, long> selector)
        {
            return SumExtensions.LongSum(System.Linq.Enumerable.Select(source, selector));
        }

        public static long? LongSum<T>(this IEnumerable<T> source, Func<T, long?> selector)
        {
            return SumExtensions.LongSum(System.Linq.Enumerable.Select(source, selector));
        }

        #endregion
    }
}
