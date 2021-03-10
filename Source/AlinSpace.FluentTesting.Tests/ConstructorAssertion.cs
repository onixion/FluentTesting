using System;
using Xunit;

namespace AlinSpace.FluentTesting.Tests
{
    /// <summary>
    /// Tests for <see cref="ConstructorAssertion{T}"/>.
    /// </summary>
    public class ConstructorAssertion
    {
        class TestClass
        {
            public TestClass(string test)
            {
                if (test == null)
                    throw new ArgumentNullException(nameof(test));
            }

            public TestClass(string test1, string test2)
            {
                if (test1 == null)
                    throw new ArgumentNullException(nameof(test1));

                if (test2 == null)
                    throw new ArgumentNullException(nameof(test2));
            }

            public TestClass(object test1)
            {
            }
        }

        [Fact]
        public void Throws_1()
        {
            Constructor
               .Type<TestClass>()
               .Throws<ArgumentNullException>(Default.Of<string>());
        }

        [Fact]
        public void Throws_2()
        {
            Constructor
               .Type<TestClass>()
               .Throws<ArgumentNullException>("", Default.Of<string>());
        }

        [Fact]
        public void Throws_3()
        {
            Constructor
               .Type<TestClass>()
               .Throws<ArgumentNullException>(Default.Of<string>());
        }
    }
}
