using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestsNetFramework
{
    [TestClass]
    public class MSTestsNetFramework2
    {
        [TestMethod]
        public void MSTestMethod11NetFramework21()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestMethod11NetFramework22()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
