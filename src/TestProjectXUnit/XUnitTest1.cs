using System.Threading;
using Xunit;

namespace TestProjectXUnit
{
    public class XUnitTest1
    {
        [Fact]
        public void Test11() => Thread.Sleep(5000);
        [Fact]
        public void Test12() => Thread.Sleep(5000);
    }
}
