using System;
using Xunit;

namespace AlinSpace.FluentTesting.Tests
{
    public partial class AssertionWrapperExtensions
    {
        [Fact]
        public void Throw_1()
        {
            new Action(() => { }).Should().Throw();
        }

        [Fact]
        public void Throw_2()
        {
            //new Action(() => throw new Exception()).Should().Throw();
        }

        [Fact]
        public void Throw_3()
        {
            //new Action(() => throw new Exception()).Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Throw_4()
        {
            //new Action(() => throw new Exception()).Should().Throw<ArgumentException>();
        }
    }
}
