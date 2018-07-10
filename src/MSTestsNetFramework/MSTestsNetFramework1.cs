using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestsNetFramework
{
    [TestClass]
    public class MSTestsNetFramework1
    {
        [TestMethod]
        public void MSTestMethod11NetFramework11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestMethod11NetFramework12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
