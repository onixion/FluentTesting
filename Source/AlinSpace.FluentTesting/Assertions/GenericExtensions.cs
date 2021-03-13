namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Extensions for all types.
    /// </summary>
    public static class GenericExtensions
    {
        /// <summary>
        /// Should be extension method.
        /// </summary>
        /// <typeparam name="T">Type to test.</typeparam>
        /// <param name="sut">System under test.</param>
        /// <returns>Assertion wrapper.</returns>
        public static AssertionWrapper<T> Should<T>(this T sut)
        {
            return new AssertionWrapper<T>(sut);
        }
    }
}
