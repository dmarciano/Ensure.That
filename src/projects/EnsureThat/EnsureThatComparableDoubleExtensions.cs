﻿namespace EnsureThat
{
    public static class EnsureThatComparableDoubleExtensions
    {
        public static void Is(this in Param<double> param, double expected)
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot(this in Param<double> param, double expected)
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsLt(this in Param<double> param, double limit)
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte(this in Param<double> param, double limit)
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt(this in Param<double> param, double limit)
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte(this in Param<double> param, double limit)
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsInRange(this in Param<double> param, double min, double max)
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);

        public static void IsPositive(this Param<double> param, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither)
             => Ensure.Comparable.IsPositive(param.Value, zeroSignMode, param.Name, param.OptsFn);

        public static void IsNegative(this Param<double> param, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither)
            => Ensure.Comparable.IsNegative(param.Value, zeroSignMode, param.Name, param.OptsFn);

        public static void IsNotNegative(this Param<double> param, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither)
            => Ensure.Comparable.IsNotNegative(param.Value, zeroSignMode, param.Name, param.OptsFn);

        public static void IsApproximately(this Param<double> param, double target, double accuracy)
            => Ensure.Comparable.IsApproximately(param.Value, target, accuracy, param.Name, param.OptsFn);
    }
}