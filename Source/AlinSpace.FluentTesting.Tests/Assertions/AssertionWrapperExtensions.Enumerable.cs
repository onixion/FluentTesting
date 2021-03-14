using System.Linq;
using Xunit;

namespace AlinSpace.FluentTesting.Tests
{
    public partial class AssertionWrapperExtensions
    {
        #region BeEmpty / NotBeEmpty

        [Fact]
        public void BeEmpty_1()
        {
            Enumerable.Empty<string>().Should().BeEmpty();
        }

        [Fact]
        public void BeEmpty_2()
        {
            Enumerable.Range(1, 10).Should().BeEmpty(n => n == 15);
        }

        [Fact]
        public void BeEmpty_3()
        {
            Assert.Throws<AssertionException>(() => Enumerable.Range(1, 10).Should().BeEmpty());
        }

        [Fact]
        public void NotBeEmpty_1()
        {
            Enumerable.Range(1, 2).Should().NotBeEmpty();
        }

        [Fact]
        public void NotBeEmpty_2()
        {
            Enumerable.Range(1, 2).Should().NotBeEmpty(n => n == 1);
        }

        [Fact]
        public void NotBeEmpty_3()
        {
            Assert.Throws<AssertionException>(() => Enumerable.Empty<int>().Should().NotBeEmpty());
        }

        #endregion

        #region HaveCount / NotHaveCount

        [Fact]
        public void HaveCount_1()
        {
            Enumerable.Empty<int>().Should().HaveCount(0);
        }

        [Fact]
        public void HaveCount_2()
        {
            Enumerable.Range(1, 23).Should().HaveCount(23);
        }

        [Fact]
        public void HaveCount_3()
        {
            Enumerable.Range(1, 20).Should().HaveCount(10, n => n % 2 == 0);
        }

        [Fact]
        public void HaveCount_4()
        {
            Assert.Throws<AssertionException>(() => Enumerable.Empty<int>().Should().HaveCount(2));
        }

        [Fact]
        public void NotHaveCount_1()
        {
            Enumerable.Empty<int>().Should().NotHaveCount(4);
        }

        [Fact]
        public void NotHaveCount_2()
        {
            Enumerable.Range(1, 23).Should().NotHaveCount(24);
        }

        [Fact]
        public void NotHaveCount_3()
        {
            Enumerable.Range(1, 20).Should().NotHaveCount(20, n => n % 2 == 0);
        }

        [Fact]
        public void NotHaveCount_4()
        {
            Assert.Throws<AssertionException>(() => Enumerable.Empty<int>().Should().NotHaveCount(0));
        }

        #endregion
    }
}
