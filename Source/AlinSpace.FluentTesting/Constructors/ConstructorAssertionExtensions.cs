using System;

namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Extensions for <see cref="ConstructorAssertion{T}"/>.
    /// </summary>
    public static class ConstructorAssertionExtensions
    {
        /// <summary>
        /// Assert that all constructors will throw <see cref="ArgumentNullException"/>
        /// when at least one constructor argument is null.
        /// </summary>
        /// <typeparam name="T">Type.</typeparam>
        /// <param name="constructorAssertion">Constructor assertion.</param>
        /// <returns>Constructor assertion.</returns>
        public static ConstructorAssertion<T> ThrowsArgumentNullException<T>(ConstructorAssertion<T> constructorAssertion)
        {
            throw new NotImplementedException();
        }
    }
}
