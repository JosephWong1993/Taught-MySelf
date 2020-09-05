using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.BLL
{
    //delegate R Func<T1, R>(T1 arg1);
    //delegate R Func<T1, T2, R>(T1 arg1, T2 arg2);
    //class C
    //{
    //    public C<T> Cast<T>();
    //}

    //class C<T>
    //{
    //    public C<T> Where(Func<T, bool> predicate);
    //    public C<U> Select<U>(Func<T, U> selector);
    //    public C<U> SelectMany<U, V>(Func<T, C<U>> selector,
    //        Func<T, U, V> resultSelector);
    //    public C<V> Join<U, K, V>(C<U> inner,
    //        Func<T, K> outerKeySelector,
    //        Func<U, K> innerKeySelector,
    //        Func<T, C<U>, V> resultSelector);
    //    public O<T> OrderBy<K>(Func<T, K> keySelector);
    //    public O<T> OrderByDescending<K>(Func<T, K> keySelector);
    //    public C<G<K, T>> GroupBy<K>(Func<T, K> keySelector);
    //    public C<G<K, E>> GroupBy<K, E>(Func<T, K> keySelector,
    //        Func<T, E> elementSelector);
    //}

    //class O<T> : C<T>
    //{
    //    public O<T> ThenBy<K>(Func<T, K> keySelector);
    //    public O<T> ThenByDescending<K>(Func<T, K> keySelector);
    //}

    //class G<K, T> : C<T>
    //{
    //    public K Key { get; }
    //}
}
