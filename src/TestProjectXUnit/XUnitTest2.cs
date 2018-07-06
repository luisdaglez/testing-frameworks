using System.Threading;
using Xunit;

namespace TestProjectXUnit
{
    public class XUnitTest2
    {
        [Fact]
        public void Test21() => Thread.Sleep(5000);
        [Fact]
        public void Test22() => Thread.Sleep(5000);
    }
}
