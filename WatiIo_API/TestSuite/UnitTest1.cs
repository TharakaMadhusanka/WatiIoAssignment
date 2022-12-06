using WatiO.Shared;
using Xunit;

namespace TestSuite
{
    public class TestSum
    {
        [Fact]
        public void TestAdd()
        {
            var shared = new SharedClass();
            int sum = shared.Sum(new NumbersModel() { Number2 = 2, Number1 = 1 });
            Assert.Equal(3, sum);
            
        }
    }
}