using Xunit;

namespace AlinSpace.FluentTesting.Tests.Assertions
{
    public class AssertionWrapperExtensions
    {
        [Fact]
        public void Be_1()
        {
            "".Should().Be(_ => true);
        }

        [Fact]
        public void Be_2()
        {
            "Test".Should().Be(s => s == "Test");
        }

        [Fact]
        public void Be_3()
        {
            Assert.Throws<AssertionException>(() => "".Should().Be(_ => false));
        }

        [Fact]
        public void NotBe_1()
        {
            "".Should().NotBe(_ => false);
        }

        [Fact]
        public void NotBe_2()
        {
            "Test".Should().NotBe(s => s != "Test");
        }

        [Fact]
        public void NotBe_3()
        {
            Assert.Throws<AssertionException>(() => "".Should().NotBe(_ => true));
        }
    }
}
