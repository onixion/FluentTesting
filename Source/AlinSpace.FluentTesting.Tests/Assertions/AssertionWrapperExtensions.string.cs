using Xunit;

namespace AlinSpace.FluentTesting.Tests
{
    public partial class AssertionWrapperExtensions
    {
        #region StartWith / NotStartWith

        [Fact]
        public void StartWith_1()
        {
            "Test".Should().StartWith("");
        }

        [Fact]
        public void StartWith_2()
        {
            "Test".Should().StartWith("Te");
        }

        [Fact]
        public void StartWith_3()
        {
            Assert.Throws<AssertionException>(() => "Test".Should().StartWith("es"));
        }

        [Fact]
        public void NotStartWith_1()
        {
            Assert.Throws<AssertionException>(() => "Test".Should().NotStartWith(""));
        }

        [Fact]
        public void NotStartWith_2()
        {
            "Test".Should().NotStartWith("est");
        }

        [Fact]
        public void NotStartWith_3()
        {
            Assert.Throws<AssertionException>(() => "Test".Should().NotStartWith("Te"));
        }

        #endregion

        #region Contain / NotContain

        [Fact]
        public void Contain_1()
        {
            "Test".Should().Contain("");
        }

        [Fact]
        public void Contain_2()
        {
            "Test".Should().Contain("es");
        }

        [Fact]
        public void Contain_3()
        {
            Assert.Throws<AssertionException>(() => "Test".Should().Contain("ee"));
        }

        [Fact]
        public void NotContain_1()
        {
            Assert.Throws<AssertionException>(() => "Test".Should().NotContain(""));
        }

        [Fact]
        public void NotContain_2()
        {
            "Test".Should().NotContain("ee");
        }

        [Fact]
        public void NotContain_3()
        {
            Assert.Throws<AssertionException>(() => "Test".Should().NotContain("es"));
        }

        #endregion
    }
}
