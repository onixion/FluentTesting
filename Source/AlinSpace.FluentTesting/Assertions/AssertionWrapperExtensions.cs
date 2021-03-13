using System;

namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Extensions for <see cref="AssertionWrapper{T}"/>.
    /// </summary>
    public static partial class AssertionWrapperExtensions
    {
        public static AssertionWrapper<T> Be<T>(
            this AssertionWrapper<T> assertion, 
            Predicate<T> predicate,
            string message = null)
        {
            if (!predicate(assertion.Sut))
            {
                throw new AssertionException(
                    extensionName: nameof(Be),
                    expectedText: $"Expected the predicate function to return true.",
                    evaluatedText: $"The predicate function returned false.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> NotBe<T>(
            this AssertionWrapper<T> assertion,
            Predicate<T> predicate,
            string message = null)
        {
            if (predicate(assertion.Sut))
            {
                throw new AssertionException(
                    extensionName: nameof(NotBe),
                    expectedText: $"Expected the predicate function to return false.",
                    evaluatedText: $"The predicate function returned true.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> BeSame<T>(
            this AssertionWrapper<T> assertion,
            T value,
            string message = null)
        {
            if (!ReferenceEquals(assertion.Sut, value))
            {
                throw new AssertionException(
                    extensionName: nameof(BeSame),
                    expectedText: $"Expected the value '{assertion.Sut}' to be same to '{value}'.",
                    evaluatedText: $"The values are not the same.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> BeNotSame<T>(
            this AssertionWrapper<T> assertion,
            T value,
            string message = null)
        {
            if (ReferenceEquals(assertion.Sut, value))
            {
                throw new AssertionException(
                    extensionName: nameof(BeNotSame),
                    expectedText: $"Expected the value '{assertion.Sut}' not to be same to '{value}'.",
                    evaluatedText: $"The values are the same.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> BeEqual<T>(
            this AssertionWrapper<T> assertion,
            T value,
            string message = null)
        {
            if (!assertion.Sut.Equals(value))
            {
                throw new AssertionException(
                    extensionName: nameof(BeEqual),
                    expectedText: $"Expected the value '{assertion.Sut}' to be equal to '{value}'.",
                    evaluatedText: $"The values are not equal.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> BeNotEqual<T>(
            this AssertionWrapper<T> assertion,
            T value,
            string message = null)
        {
            if (assertion.Sut.Equals(value))
            {
                throw new AssertionException(
                    extensionName: nameof(BeNotEqual),
                    expectedText: $"Expected the value '{assertion.Sut}' to be not equal to '{value}'.",
                    evaluatedText: $"The values are equal.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> BeDefault<T>(
            this AssertionWrapper<T> assertion,
            string message = null)
        {
            if (!assertion.Sut.Equals(default(T)))
            {
                throw new AssertionException(
                    extensionName: nameof(BeDefault),
                    expectedText: $"Expected the value '{assertion.Sut}' to be the default value '{default(T)}'.",
                    evaluatedText: $"The value is not the default value.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> NotBeDefault<T>(
            this AssertionWrapper<T> assertion,
            string message = null)
        {
            if (assertion.Sut.Equals(default(T)))
            {
                throw new AssertionException(
                    extensionName: nameof(NotBeDefault),
                    expectedText: $"Expected the value '{assertion.Sut}' to be not the default value '{default(T)}'.",
                    evaluatedText: $"The value is the default value.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> BeNull<T>(
            this AssertionWrapper<T> assertion,
            string message = null)
        {
            if (!assertion.Sut.Equals(default(T)))
            {
                throw new AssertionException(
                    extensionName: nameof(BeNull),
                    expectedText: $"Expected the value '{assertion.Sut}' to be not the default value '{default(T)}'.",
                    evaluatedText: $"The value is the default value.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<T> NotBeNull<T>(
            this AssertionWrapper<T> assertion,
            string message = null)
        {
            if (assertion.Sut.Equals(default(T)))
            {
                throw new AssertionException(
                    extensionName: nameof(NotBeNull),
                    expectedText: $"Expected the value '{assertion.Sut}' to be not the default value '{default(T)}'.",
                    evaluatedText: $"The value is the default value.",
                    message: message);
            }

            return assertion;
        }
    }
}
