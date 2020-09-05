using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.BLL
{
    public static class NonSequenceOperator
    {
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
            this TOuter outer,
            IEnumerable<TInner> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
            ILookup<TKey, TInner> lookup = inner.ToLookup(innerKeySelector);
            yield return resultSelector(outer, lookup[outerKeySelector(outer)]);
        }
    }
}
