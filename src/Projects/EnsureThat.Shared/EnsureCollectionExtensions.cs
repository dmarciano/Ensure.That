using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureCollectionExtensions
    {
        [DebuggerStepThrough]
        public static Param<T> HasItems<T>(this Param<T> param) where T : class, ICollection
        {
            if (param.Value == null || param.Value.Count < 1)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsEmptyCollection);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<Collection<T>> HasItems<T>(this Param<Collection<T>> param)
        {
            if (param.Value == null || param.Value.Count < 1)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsEmptyCollection);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<ICollection<T>> HasItems<T>(this Param<ICollection<T>> param)
        {
            if (param.Value == null || param.Value.Count < 1)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsEmptyCollection);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T[]> HasItems<T>(this Param<T[]> param)
        {
            if (param.Value == null || param.Value.Length < 1)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsEmptyCollection);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<List<T>> HasItems<T>(this Param<List<T>> param)
        {
            if (param.Value == null || param.Value.Count < 1)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsEmptyCollection);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<IList<T>> HasItems<T>(this Param<IList<T>> param)
        {
            if (param.Value == null || param.Value.Count < 1)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsEmptyCollection);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<IDictionary<TKey, TValue>> HasItems<TKey, TValue>(this Param<IDictionary<TKey, TValue>> param)
        {
            if (param.Value == null || param.Value.Count < 1)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsEmptyCollection);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T[]> SizeIs<T>(this Param<T[]> param, int expected)
        {
            if (param.Value.Length != expected)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, param.Value.Length));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T[]> SizeIs<T>(this Param<T[]> param, long expected)
        {
            if (param.Value.Length != expected)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, param.Value.Length));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T> SizeIs<T>(this Param<T> param, int expected) where T : ICollection
        {
            if (param.Value.Count != expected)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, param.Value.Count));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T> SizeIs<T>(this Param<T> param, long expected) where T : ICollection
        {
            if (param.Value.Count != expected)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, param.Value.Count));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<IDictionary<TKey, TValue>> ContainsKey<TKey, TValue>(this Param<IDictionary<TKey, TValue>> param, TKey key)
        {
            if (!param.Value.ContainsKey(key))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_ContainsKey.Inject(key));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<Dictionary<TKey, TValue>> ContainsKey<TKey, TValue>(this Param<Dictionary<TKey, TValue>> param, TKey key)
        {
            if (!param.Value.ContainsKey(key))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_ContainsKey.Inject(key));

            return param;
        }

    }
}