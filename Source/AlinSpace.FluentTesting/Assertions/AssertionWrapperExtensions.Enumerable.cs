using System;
using System.Collections.Generic;
using System.Linq;

namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Extensions for <see cref="AssertionWrapper{T}"/>.
    /// </summary>
    public static partial class AssertionWrapperExtensions
    {
        public static AssertionWrapper<IEnumerable<T>> BeEmpty<T>(
            this AssertionWrapper<IEnumerable<T>> assertion,
            Predicate<T> predicate = null,
            string message = null)
        {
            if (assertion.Sut.Any(v => predicate?.Invoke(v) ?? true))
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the enumerable to be empty.",
                    evaluatedText: $"The enumerable was not empty.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<IEnumerable<T>> NotBeEmpty<T>(
            this AssertionWrapper<IEnumerable<T>> assertion,
            Predicate<T> predicate = null,
            string message = null)
        {
            if (!assertion.Sut.Any(v => predicate?.Invoke(v) ?? true))
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the enumerable to be not empty.",
                    evaluatedText: $"The enumerable was empty.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<IEnumerable<T>> HaveCount<T>(
            this AssertionWrapper<IEnumerable<T>> assertion,
            int count,
            Predicate<T> predicate = null,
            string message = null)
        {
            var evaluatedCount = assertion.Sut.Count(v => predicate?.Invoke(v) ?? true);

            if (evaluatedCount != count)
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the enumerable to have a count of {count}.",
                    evaluatedText: $"The enumerable had a count of {evaluatedCount}.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<IEnumerable<T>> NotHaveCount<T>(
            this AssertionWrapper<IEnumerable<T>> assertion,
            int count,
            Predicate<T> predicate = null,
            string message = null)
        {
            var evaluatedCount = assertion.Sut.Count(v => predicate?.Invoke(v) ?? true);

            if (evaluatedCount == count)
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the enumerable not to have a count of {count}.",
                    evaluatedText: $"The enumerable had a count of {evaluatedCount}.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<IEnumerable<T>> HaveAtLeast<T>(
            this AssertionWrapper<IEnumerable<T>> assertion,
            int count,
            Predicate<T> predicate = null,
            string message = null)
        {
            var evaluatedCount = assertion.Sut.Count(v => predicate?.Invoke(v) ?? true);

            if (evaluatedCount >= count)
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the enumerable to have at least count of {count}.",
                    evaluatedText: $"The enumerable had a count of {evaluatedCount}.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<IEnumerable<T>> NotHaveAtLeast<T>(
            this AssertionWrapper<IEnumerable<T>> assertion,
            int count,
            Predicate<T> predicate = null,
            string message = null)
        {
            var evaluatedCount = assertion.Sut.Count(v => predicate?.Invoke(v) ?? true);

            if (evaluatedCount < count)
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the enumerable to have not at least count of {count}.",
                    evaluatedText: $"The enumerable had a count of {evaluatedCount}.",
                    message: message);
            }

            return assertion;
        }
    }
}
