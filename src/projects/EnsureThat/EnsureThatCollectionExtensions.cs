using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EnsureThat
{
    public static class EnsureThatCollectionExtensions
    {
        public static void HasItems<T>(this in Param<T> param) where T : class, ICollection
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<Collection<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<ICollection<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<T[]> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<List<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<IList<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<HashSet<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<ISet<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<TKey, TValue>(this in Param<Dictionary<TKey, TValue>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<IReadOnlyCollection<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this in Param<IReadOnlyList<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void SizeIs<T>(this in Param<T[]> param, int expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this in Param<T[]> param, long expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this in Param<T> param, int expected) where T : class, ICollection
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this in Param<T> param, long expected) where T : class, ICollection
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this in Param<ICollection<T>> param, int expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this in Param<ICollection<T>> param, long expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this in Param<IList<T>> param, int expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this in Param<IList<T>> param, long expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, int expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, long expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);



        #region SizeIsNot/SizeIsGt/Lt/Gte/Lte
        public static void SizeIsNot<T>(this in Param<T[]> param, int expected)
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<T>(this in Param<T[]> param, long expected)
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<T>(this in Param<T> param, int expected) where T : class, ICollection
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<T>(this in Param<T> param, long expected) where T : class, ICollection
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<T>(this in Param<ICollection<T>> param, int expected)
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<T>(this in Param<ICollection<T>> param, long expected)
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<T>(this in Param<IList<T>> param, int expected)
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<T>(this in Param<IList<T>> param, long expected)
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, int expected)
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsNot<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, long expected)
            => Ensure.Collection.SizeIsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<T>(this in Param<T[]> param, int expected)
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<T>(this in Param<T[]> param, long expected)
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<T>(this in Param<T> param, int expected) where T : class, ICollection
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<T>(this in Param<T> param, long expected) where T : class, ICollection
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<T>(this in Param<ICollection<T>> param, int expected)
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<T>(this in Param<ICollection<T>> param, long expected)
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<T>(this in Param<IList<T>> param, int expected)
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<T>(this in Param<IList<T>> param, long expected)
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, int expected)
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGt<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, long expected)
            => Ensure.Collection.SizeIsGt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<T>(this in Param<T[]> param, int expected)
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<T>(this in Param<T[]> param, long expected)
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<T>(this in Param<T> param, int expected) where T : class, ICollection
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<T>(this in Param<T> param, long expected) where T : class, ICollection
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<T>(this in Param<ICollection<T>> param, int expected)
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<T>(this in Param<ICollection<T>> param, long expected)
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<T>(this in Param<IList<T>> param, int expected)
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<T>(this in Param<IList<T>> param, long expected)
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, int expected)
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLt<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, long expected)
            => Ensure.Collection.SizeIsLt(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<T>(this in Param<T[]> param, int expected)
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<T>(this in Param<T[]> param, long expected)
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<T>(this in Param<T> param, int expected) where T : class, ICollection
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<T>(this in Param<T> param, long expected) where T : class, ICollection
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<T>(this in Param<ICollection<T>> param, int expected)
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<T>(this in Param<ICollection<T>> param, long expected)
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<T>(this in Param<IList<T>> param, int expected)
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<T>(this in Param<IList<T>> param, long expected)
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, int expected)
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsGte<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, long expected)
            => Ensure.Collection.SizeIsGte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<T>(this in Param<T[]> param, int expected)
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<T>(this in Param<T[]> param, long expected)
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<T>(this in Param<T> param, int expected) where T : class, ICollection
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<T>(this in Param<T> param, long expected) where T : class, ICollection
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<T>(this in Param<ICollection<T>> param, int expected)
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<T>(this in Param<ICollection<T>> param, long expected)
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<T>(this in Param<IList<T>> param, int expected)
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<T>(this in Param<IList<T>> param, long expected)
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, int expected)
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIsLte<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, long expected)
            => Ensure.Collection.SizeIsLte(param.Value, expected, param.Name, param.OptsFn);
        #endregion



        public static void ContainsKey<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, TKey key)
            => Ensure.Collection.ContainsKey(param.Value, key, param.Name, param.OptsFn);

        public static void ContainsKey<TKey, TValue>(this in Param<Dictionary<TKey, TValue>> param, TKey key)
            => Ensure.Collection.ContainsKey(param.Value, key, param.Name, param.OptsFn);

        public static void HasAny<T>(this in Param<IList<T>> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<T>(this in Param<List<T>> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<T>(this in Param<ICollection<T>> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<T>(this in Param<Collection<T>> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, Func<KeyValuePair<TKey, TValue>, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<TKey, TValue>(this in Param<Dictionary<TKey, TValue>> param, Func<KeyValuePair<TKey, TValue>, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<T>(this in Param<T[]> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);
    }
}