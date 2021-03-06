﻿using JetBrains.Annotations;
using System;

namespace EnsureThat.Enforcers
{
    public sealed partial class ComparableArg
    {
        public long Is(long value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public long IsNot(long value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public long IsLt(long value, long limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value, optsFn);

            return value;
        }

        public long IsLte(long value, long limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value > limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value, optsFn);

            return value;
        }

        public long IsGt(long value, long limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value <= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value, optsFn);

            return value;
        }

        public long IsGte(long value, long limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value, optsFn);

            return value;
        }

        public long IsInRange(long value, long min, long max, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < min)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value, optsFn);

            if (value > max)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value, optsFn);

            return value;
        }

        public long IsPositive(long value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value > 0 || (value == 0 && (ZeroSignMode.IsPositive == zeroSignMode || ZeroSignMode.IsBoth == zeroSignMode))) return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);
        }

        public long IsNegative(long value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0 || (value == 0 && (ZeroSignMode.IsNegative == zeroSignMode || ZeroSignMode.IsBoth == zeroSignMode))) return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);
        }

        public long IsNotNegative(long value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value > 0 || (value == 0 && ZeroSignMode.IsPositive == zeroSignMode)) return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);
        }

        public long IsApproximately(long value, long target, long accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var difference = Math.Abs(value - target);
            if (difference <= accuracy)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }
    }
}