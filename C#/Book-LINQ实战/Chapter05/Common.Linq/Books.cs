using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Linq
{
    public static class Books
    {
        /// <summary>
        /// ForEach操作符，允许对源序列中的每个元素进行遍历并执行某一操作
        /// </summary>
        /// <typeparam name="T">元素类型</typeparam>
        /// <param name="source">源序列</param>
        /// <param name="func">具体操作</param>
        public static void Foreach<T>(this IEnumerable<T> source, Action<T> func)
        {
            foreach (T item in source)
            {
                func(item);
            }
        }

        /// <summary>
        /// 建立名为MaxElement的自定义查询操作符，已找到集合中某项属性最大的对象
        /// </summary>
        /// <returns></returns>
        public static TElement MaxElement<TElement, TData>(
            this IEnumerable<TElement> source,
            Func<TElement, TData> selector) where TData : IComparable<TData>
        {
            if (source == null)
                throw new ArgumentException("source");

            if (selector == null)
                throw new ArgumentException("selector");

            Boolean firstElement = true;
            TElement result = default(TElement);
            TData maxValue = default(TData);
            foreach (TElement element in source)
            {
                TData candidate = selector(element);
                if (firstElement ||
                    (candidate.CompareTo(maxValue) > 0))
                {
                    firstElement = false;
                    maxValue = candidate;
                    result = element;
                }
            }
            return result;
        }
    }
}
