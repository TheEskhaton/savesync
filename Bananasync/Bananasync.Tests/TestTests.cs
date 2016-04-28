using Xunit;

namespace Bananasync.Tests
{
    public class TestTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, decimal.Add(2, 2));
        }
    }
}
