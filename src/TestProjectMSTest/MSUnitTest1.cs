using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectMSTest
{
    [TestClass]
    public class MSUnitTest1
    {
        [TestMethod]
        public void MSTestMethod11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestMethod12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
