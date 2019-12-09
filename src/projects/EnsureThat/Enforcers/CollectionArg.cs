using EnsureThat.Annotations;
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EnsureThat.Enforcers
{
    public sealed class CollectionArg
    {
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T HasItems<T>([ValidatedNotNull]T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> HasItems<T>([ValidatedNotNull]ICollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IReadOnlyList<T> HasItems<T>([ValidatedNotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ISet<T> HasItems<T>([ValidatedNotNull]ISet<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] HasItems<T>([ValidatedNotNull]T[] value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> HasItems<T>([ValidatedNotNull] IList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public Collection<T> HasItems<T>([ValidatedNotNull] Collection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public List<T> HasItems<T>([ValidatedNotNull] List<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public HashSet<T> HasItems<T>([ValidatedNotNull] HashSet<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public Dictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull]Dictionary<TKey, TValue> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIs<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIs<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

#if NET452
            if (value.LongLength != expected)
#else
            if (value.Length != expected)
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIs<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIs<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIs<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIs<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }



        #region SizeIsNot/SizeIsGt/Lt/Gte/Lte
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsNot<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsNot<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

#if NET452
            if (value.LongLength == expected)
#else
            if (value.Length == expected)
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsNot<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsNot<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsNot<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsNot<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsNot<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsNot<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsNot<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsNot<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsGt<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsGt<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

#if NET452
            if (value.LongLength <= expected)
#else
            if (value.Length <= expected)
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsGt<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsGt<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsGt<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsGt<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsGt<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsGt<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsGt<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsGt<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count <= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsLt<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsLt<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

#if NET452
            if (value.LongLength >= expected)
#else
            if (value.Length >= expected)
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsLt<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsLt<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsLt<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsLt<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsLt<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsLt<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsLt<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsLt<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count >= expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsGte<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsGte<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

#if NET452
            if (value.LongLength < expected)
#else
            if (value.Length < expected)
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsGte<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsGte<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsGte<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsGte<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsGte<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsGte<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsGte<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsGte<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsLte<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIsLte<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

#if NET452
            if (value.LongLength > expected)
#else
            if (value.Length > expected)
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsLte<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIsLte<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsLte<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIsLte<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsLte<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIsLte<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsLte<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIsLte<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count > expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }
        #endregion

        #region IsInAscending/Descending Order
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] IsInAscendingOrder<T>([ValidatedNotNull]T[] value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length < 1) return value;

            comparer = comparer ?? Comparer<T>.Default;
            for (var i = 1; i < value.Length; i++)
                if (comparer.Compare(value[i - 1], value[i]) > 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T IsInAscendingOrder<T>([ValidatedNotNull]T value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection, IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1) return value;

            comparer = comparer ?? Comparer<T>.Default;

            var values = new T[value.Count];
            value.CopyTo(values, 0);

            for (var i = 1; i < value.Count; i++)
                if (comparer.Compare(values[i - 1], values[i]) > 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> IsInAscendingOrder<T>([ValidatedNotNull]ICollection<T> value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1) return value;

            comparer = comparer ?? Comparer<T>.Default;
            var values = value.ToArray();

            for (var i = 1; i < value.Count; i++)
                if (comparer.Compare(values[i - 1], values[i]) > 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> IsInAscendingOrder<T>([ValidatedNotNull] IList<T> value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1) return value;

            comparer = comparer ?? Comparer<T>.Default;
            for (var i = 1; i < value.Count; i++)
                if (comparer.Compare(value[i - 1], value[i]) > 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> IsInAscendingOrder<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, IComparer<TKey> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where TKey : IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1) return value;

            comparer = comparer ?? Comparer<TKey>.Default;
            var values = value.Keys.ToArray();

            for (var i = 1; i < values.Length; i++)
                if (comparer.Compare(values[i - 1], values[i]) > 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] IsInDescendingOrder<T>([ValidatedNotNull]T[] value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length < 1) return value;

            comparer = comparer ?? Comparer<T>.Default;
            for (var i = 1; i < value.Length; i++)
                if (comparer.Compare(value[i - 1], value[i]) < 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T IsInDescendingOrder<T>([ValidatedNotNull]T value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection, IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1) return value;

            comparer = comparer ?? Comparer<T>.Default;

            var values = new T[value.Count];
            value.CopyTo(values, 0);

            for (var i = 1; i < value.Count; i++)
                if (comparer.Compare(values[i - 1], values[i]) < 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> IsInDescendingOrder<T>([ValidatedNotNull]ICollection<T> value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1) return value;

            comparer = comparer ?? Comparer<T>.Default;
            var values = value.ToArray();

            for (var i = 1; i < value.Count; i++)
                if (comparer.Compare(values[i - 1], values[i]) < 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> IsInDescendingOrder<T>([ValidatedNotNull] IList<T> value, IComparer<T> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1) return value;

            comparer = comparer ?? Comparer<T>.Default;
            for (var i = 1; i < value.Count; i++)
                if (comparer.Compare(value[i - 1], value[i]) < 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> IsInDescendingOrder<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, IComparer<TKey> comparer = null, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where TKey : IComparable
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1) return value;

            comparer = comparer ?? Comparer<TKey>.Default;
            var values = value.Keys.ToArray();

            for (var i = 1; i < values.Length; i++)
                if (comparer.Compare(values[i - 1], values[i]) < 0)
                    throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                    paramName,
                    optsFn);

            return value;
        }
        #endregion

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.ContainsKey(expectedKey))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_ContainsKey_Failed, expectedKey),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> HasAny<T>([ValidatedNotNull]IList<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> HasAny<T>([ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] HasAny<T>([ValidatedNotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName,
                    optsFn);

            return value;
        }
    }
}