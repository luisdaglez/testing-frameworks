using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace TestProjectMSTest
{
    [TestClass]
    public class MSUnitTest2
    {
        [TestMethod]
        public void MSTestMethod21() => Thread.Sleep(5000);
        [TestMethod]
        public void MSTestMethod22() => Thread.Sleep(5000);
    }
}
