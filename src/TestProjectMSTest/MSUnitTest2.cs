using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectMSTest
{
    [TestClass]
    public class MSUnitTest2
    {
        [TestMethod]
        public void MSTestMethod21()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestMethod22()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
