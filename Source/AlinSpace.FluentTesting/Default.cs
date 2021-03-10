namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Default.
    /// </summary>
    public static class Default
    {
        /// <summary>
        /// Get default value of <see cref="T"/>.
        /// </summary>
        /// <typeparam name="T">Type.</typeparam>
        /// <returns>Default value.</returns>
        public static T Of<T>()
        {
            T obj = default;
            return obj;
        }
    }
}
