using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace TestProjectMSTest
{
    [TestClass]
    public class MSUnitTest1
    {
        [TestMethod]
        public void MSTestMethod11() => Thread.Sleep(5000);
        [TestMethod]
        public void MSTestMethod12() => Thread.Sleep(5000);
    }
}
