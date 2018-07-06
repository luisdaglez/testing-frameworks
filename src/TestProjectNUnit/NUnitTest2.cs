using NUnit.Framework;
using System.Threading;

namespace TestProjectNUnit
{
    public class NUnitTest2
    {
        [Test]
        public void NUnitTestMethod21() => Thread.Sleep(5000);
        [Test]
        public void NUnitTestMethod22() => Thread.Sleep(5000);
    }
}
