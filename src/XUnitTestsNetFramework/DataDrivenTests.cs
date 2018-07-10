using ClassLibraryNetStandard;
using Xunit;

namespace XUnitTestsNetFramework
{
    public class DataDrivenTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 4, 7)]
        public void SumTests(int a, int b, int sum)
        {
            var foo = new Class1();
            foo.Method1();

            Assert.Equal(a + b, sum);
        }
    }
}
