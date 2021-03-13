using System;

namespace AlinSpace.FluentTesting
{
    /// <summary>
    /// Assertion exception.
    /// </summary>
    public class AssertionException : Exception
    {
        /// <summary>
        /// Extension name that raised the exception.
        /// </summary>
        public string ExtensionName { get; }
 
        /// <summary>
        /// Text explaining what we expected.
        /// </summary>
        public string ExpectedText { get; }

        /// <summary>
        /// Text explaining what the assertion evaluated.
        /// </summary>
        public string EvaluatedText { get; }

        public AssertionException(string extensionName, string expectedText, string evaluatedText, string message = null)
            : base( $"Failed assertion in {extensionName}.\n{expectedText}\n{evaluatedText}\n{message ?? ""}")
        {
            ExtensionName = extensionName;
            ExpectedText = expectedText;
            EvaluatedText = evaluatedText;
        }

        public AssertionException(string extensionName, string expectedText, string evaluatedText, Exception innerException, string message = null)
            : base($"Failed assertion in {extensionName}.\n{expectedText}\n{evaluatedText}\n{message ?? ""}", innerException)
        {
            ExtensionName = extensionName;
            ExpectedText = expectedText;
            EvaluatedText = evaluatedText;
        }
    }
}
