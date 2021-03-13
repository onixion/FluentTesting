namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Assertion wrapper.
    /// </summary>
    /// <typeparam name="T">Wrapped type.</typeparam>
    public class AssertionWrapper<T>
    {
        /// <summary>
        /// System under test.
        /// </summary>
        public T Sut { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="sut">System under test.</param>
        public AssertionWrapper(T sut)
        {
            Sut = sut;
        }
    }
}
