namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public class Constructor
    {
        /// <summary>
        /// Type to make the assertions on.
        /// </summary>
        /// <returns>Constructor assertion.</returns>
        public static ConstructorAssertion<T> Type<T>()
        {
            return new ConstructorAssertion<T>();
        }
    }

}
