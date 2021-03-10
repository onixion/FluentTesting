using System;
using System.Reflection;

namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Constructor assertions.
    /// </summary>
    /// <typeparam name="T">Type.</typeparam>
    /// <remarks>
    /// Exception of type <see cref="TargetInvocationException"/> shall not be thrown by any constructors.
    /// This type of exception can NOT be tested. If the constructor throws an exception of type 
    /// <see cref="TargetInvocationException"/>, it will be propagated.
    /// </remarks>
    public class ConstructorAssertion<T>
    {
        /// <summary>
        /// Assert constructor throws any exception for the given parameters.
        /// </summary>
        /// <param name="parameters">Constructor parameters.</param>
        /// <returns>Constructor assertion.</returns>
        public ConstructorAssertion<T> Throws(params object[] parameters)
        {
            try
            {
                try
                {
                    Activator.CreateInstance(typeof(T), parameters);
                }
                catch (TargetInvocationException e)
                {
                    throw e.InnerException;
                }
            }
            catch
            {
                return this;
            }

            throw new Exception($"Expected exception to be thrown.");
        }

        /// <summary>
        /// Assert constructor throws any exception for the given parameters.
        /// </summary>
        /// <param name="parameters">Constructor parameters.</param>
        /// <param name="predicate">Exception predicate.</param>
        /// <returns>Constructor assertion.</returns>
        public ConstructorAssertion<T> Throws(object[] parameters, Predicate<Exception> predicate)
        {
            try
            {
                try
                {
                    Activator.CreateInstance(typeof(T), parameters);
                }
                catch (TargetInvocationException e)
                {
                    throw e.InnerException;
                }
            }
            catch (Exception e)
            {
                if (!predicate(e))
                {
                    throw new Exception(
                        message: $"Predicate returned false.",
                        innerException: e);
                }

                return this;
            }

            throw new Exception($"Expected exception to be thrown.");
        }

        /// <summary>
        /// Assert constructor throws a specifc exception for the given parameters.
        /// </summary>
        /// <typeparam name="TException">Type of exception.</typeparam>
        /// <param name="parameters">Constructor parameters.</param>
        /// <returns>Constructor assertion.</returns>
        public ConstructorAssertion<T> Throws<TException>(params object[] parameters) where TException : Exception
        {
            try
            {
                try
                {
                    Activator.CreateInstance(typeof(T), parameters);
                }
                catch (TargetInvocationException e)
                {
                    throw e.InnerException;
                }
            }
            catch (TException)
            {
                return this;
            }
            catch (Exception e)
            {
                throw new Exception(
                    message: $"Unexpected type of exception caught. Expected {typeof(TException)}, got {e.GetType()}.",
                    innerException: e);
            }

            throw new Exception($"Expected exeception to be thrown. Expected {typeof(TException)}, got no exception.");
        }

        /// <summary>
        /// Assert constructor throws a specifc exception for the given parameters.
        /// </summary>
        /// <typeparam name="TException">Type of exception.</typeparam>
        /// <param name="parameters">Constructor parameters.</param>
        /// <param name="predicate">Exception predicate.</param>
        /// <returns>Constructor assertion.</returns>
        public ConstructorAssertion<T> Throws<TException>(object[] parameters, Predicate<TException> predicate) where TException : Exception
        {
            try
            {
                try
                {
                    Activator.CreateInstance(typeof(T), parameters);
                }
                catch (TargetInvocationException e)
                {
                    throw e.InnerException;
                }
            }
            catch (TException e)
            {
                if (!predicate(e))
                {
                    throw new Exception(
                        message: $"Predicate returned false.",
                        innerException: e);
                }

                return this;
            }
            catch (Exception e)
            {
                throw new Exception(
                    message: $"Unexpected type of exception caught. Expected {typeof(TException)}, got {e.GetType()}.",
                    innerException: e);
            }

            throw new Exception($"Expected exeception to be thrown. Expected {typeof(TException)}, got no exception.");
        }
    }
}
