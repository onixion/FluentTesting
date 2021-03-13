namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Extensions for <see cref="AssertionWrapper{T}"/>.
    /// </summary>
    public static partial class AssertionWrapperExtensions
    {
        public static AssertionWrapper<string> StartWith(
            this AssertionWrapper<string> assertion,
            string value,
            string message = null)
        {
            if (!assertion.Sut.StartsWith(value))
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the string '{assertion.Sut}' to start with '{value}'.",
                    evaluatedText: $"The string '{assertion.Sut}' did not start with '{value}'.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<string> NotStartWith(
            this AssertionWrapper<string> assertion,
            string value,
            string message = null)
        {
            if (assertion.Sut.StartsWith(value))
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the string '{assertion.Sut}' to not start with '{value}'.",
                    evaluatedText: $"The string '{assertion.Sut}' did start with '{value}'.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<string> Contain(
            this AssertionWrapper<string> assertion,
            string value,
            string message = null)
        {
            if (!assertion.Sut.Contains(value))
            {
                throw new AssertionException(
                    extensionName: nameof(BeEmpty),
                    expectedText: $"Expected the string '{assertion.Sut}' to contain '{value}'.",
                    evaluatedText: $"The string '{assertion.Sut}' did not contain '{value}'.",
                    message: message);
            }

            return assertion;
        }

        public static AssertionWrapper<string> NotContain(
            this AssertionWrapper<string> assertion,
            string value,
            string message = null)
        {
            if (assertion.Sut.Contains(value))
            {
                throw new AssertionException(
                   extensionName: nameof(BeEmpty),
                   expectedText: $"Expected the string '{assertion.Sut}' to not contain '{value}'.",
                   evaluatedText: $"The string '{assertion.Sut}' did contain '{value}'.",
                   message: message);
            }

            return assertion;
        }
    }
}
