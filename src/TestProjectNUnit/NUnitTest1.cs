using NUnit.Framework;
using System.Threading;

namespace TestProjectNUnit
{
    public class NUnitTest1
    {
        [Test]
        public void NUnitTestMethod11() => Thread.Sleep(5000);
        [Test]
        public void NUnitTestMethod12() => Thread.Sleep(5000);
    }
}
