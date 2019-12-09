using EnsureThat.Annotations;
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T HasItems<T>([ValidatedNotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasItems<T>([ValidatedNotNull]ICollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyList<T> HasItems<T>([ValidatedNotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ISet<T> HasItems<T>([ValidatedNotNull]ISet<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasItems<T>([ValidatedNotNull]T[] value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasItems<T>([ValidatedNotNull] IList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIs<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIs<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIs<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIs<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIs<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIs<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);



        #region SizeIsNot/SizeIsGt/Lt/Gte/Lte
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsNot<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsNot<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsNot<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsNot<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsNot<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsNot<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsNot<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsNot<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsNot<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsNot<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsNot(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsGt<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsGt<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsGt<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsGt<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsGt<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsGt<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsGt<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsGt<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsGt<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsGt<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsLt<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsLt<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsLt<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsLt<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsLt<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsLt<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsLt<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsLt<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsLt<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsLt<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLt(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsGte<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsGte<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsGte<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsGte<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsGte<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsGte<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsGte<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsGte<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsGte<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsGte<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsGte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsLte<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIsLte<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsLte<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIsLte<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsLte<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIsLte<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsLte<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIsLte<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsLte<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIsLte<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIsLte(value, expected, paramName, optsFn);
        #endregion

        #region IsInAscending/Descending Order
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] IsInAscendingOrder<T>([ValidatedNotNull]T[] value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
            => Ensure.Collection.IsInAscendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T IsInAscendingOrder<T>([ValidatedNotNull]T value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection, IComparable
    => Ensure.Collection.IsInAscendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> IsInAscendingOrder<T>([ValidatedNotNull]ICollection<T> value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
            => Ensure.Collection.IsInAscendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> IsInAscendingOrder<T>([ValidatedNotNull] IList<T> value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
            => Ensure.Collection.IsInAscendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> IsInAscendingOrder<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, IComparer<TKey> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where TKey : IComparable
            => Ensure.Collection.IsInAscendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] IsInDescendingOrder<T>([ValidatedNotNull]T[] value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
            => Ensure.Collection.IsInDescendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T IsInDescendingOrder<T>([ValidatedNotNull]T value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection, IComparable
            => Ensure.Collection.IsInDescendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> IsInDescendingOrder<T>([ValidatedNotNull]ICollection<T> value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
            => Ensure.Collection.IsInDescendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> IsInDescendingOrder<T>([ValidatedNotNull] IList<T> value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
            => Ensure.Collection.IsInDescendingOrder(value, comparer, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> IsInDescendingOrder<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, IComparer<TKey> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where TKey : IComparable
            => Ensure.Collection.IsInDescendingOrder(value, comparer, paramName, optsFn);
        #endregion


        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.ContainsKey(value, expectedKey, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasAny<T>([ValidatedNotNull] IList<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasAny<T>([ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasAny<T>([ValidatedNotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);
    }
}