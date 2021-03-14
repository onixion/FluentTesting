using System;

namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Extensions for <see cref="AssertionWrapper{T}"/>.
    /// </summary>
    public static partial class AssertionWrapperExtensions
    {
        public static AssertionWrapper<Action> Throw(
            this AssertionWrapper<Action> assertion,
            Predicate<Exception> predicate = null,
            string message = null)
        {
            try
            {
                assertion.Sut();
            }
            catch (Exception e)
            {
                if (!(predicate?.Invoke(e) ?? true))
                {
                    throw new Exception();
                }

                return assertion;
            }

            throw new Exception();
        }

        public static AssertionWrapper<Action> Throw<TException>(
            this AssertionWrapper<Action> assertion,
            Predicate<TException> predicate = null,
            string message = null) where TException : Exception
        {
            try
            {
                assertion.Sut();
            }
            catch(TException e)
            {
                if (!(predicate?.Invoke(e) ?? true))
                {
                    throw new Exception();
                }

                return assertion;
            }

            throw new Exception();
        }
    }
}
