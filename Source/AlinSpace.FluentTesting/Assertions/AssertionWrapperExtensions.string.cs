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
                throw new AssertionException();
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
                throw new AssertionException();
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
                throw new AssertionException();
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
                throw new AssertionException();
            }

            return assertion;
        }
    }
}
