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
        public static AssertionWrapper<T> BeEmpty<T>(
            this AssertionWrapper<T> assertion,
            Predicate<T> predicate = null,
            string message = null) where T : IEnumerable<T>
        {
            if (assertion.Sut.Any(v => predicate?.Invoke(v) ?? true))
            {
                throw new AssertionException();
            }

            return assertion;
        }

        public static AssertionWrapper<T> NotBeEmpty<T>(
            this AssertionWrapper<T> assertion,
            Predicate<T> predicate = null,
            string message = null) where T : IEnumerable<T>
        {
            if (!assertion.Sut.Any(v => predicate?.Invoke(v) ?? true))
            {
                throw new AssertionException();
            }

            return assertion;
        }

        public static AssertionWrapper<T> HaveCount<T>(
            this AssertionWrapper<T> assertion,
            int count,
            Predicate<T> predicate = null,
            string message = null) where T : IEnumerable<T>
        {
            // Todo
            return assertion;
        }

        public static AssertionWrapper<T> NotHaveCount<T>(
            this AssertionWrapper<T> assertion,
            int count,
            Predicate<T> predicate = null,
            string message = null) where T : IEnumerable<T>
        {
            // Todo
            return assertion;
        }

        public static AssertionWrapper<T> HaveAtLeast<T>(
            this AssertionWrapper<T> assertion,
            int count,
            Predicate<T> predicate = null,
            string message = null) where T : IEnumerable<T>
        {
            // Todo
            return assertion;
        }

        public static AssertionWrapper<T> NotHaveAtLeast<T>(
            this AssertionWrapper<T> assertion,
            int count,
            Predicate<T> predicate = null,
            string message = null) where T : IEnumerable<T>
        {
            // Todo
            return assertion;
        }
    }
}
