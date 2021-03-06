﻿using JetBrains.Annotations;
using System;

namespace EnsureThat.Enforcers
{
    public sealed partial class ComparableArg
    {
        public double Is(double value, double expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public double IsNot(double value, double expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public double IsLt(double value, double limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value, optsFn);

            return value;
        }

        public double IsLte(double value, double limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value > limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value, optsFn);

            return value;
        }

        public double IsGt(double value, double limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value <= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value, optsFn);

            return value;
        }

        public double IsGte(double value, double limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value, optsFn);

            return value;
        }

        public double IsInRange(double value, double min, double max, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < min)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value, optsFn);

            if (value > max)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value, optsFn);

            return value;
        }

        public double IsPositive(double value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value > 0 || (value == 0 && (ZeroSignMode.IsPositive == zeroSignMode || ZeroSignMode.IsBoth == zeroSignMode))) return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);
        }

        public double IsNegative(double value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0 || (value == 0 && (ZeroSignMode.IsNegative == zeroSignMode || ZeroSignMode.IsBoth == zeroSignMode))) return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);
        }

        public double IsNotNegative(double value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value > 0 || (value == 0 && ZeroSignMode.IsPositive == zeroSignMode)) return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);
        }

        public double IsApproximately(double value, double target, double accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var difference = Math.Abs(value - target);
            if (difference <= accuracy)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }
    }
}