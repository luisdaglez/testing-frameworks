using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectMSTestNetFramework
{
    [TestClass]
    public class MSUnitTest1NetFramework
    {
        [TestMethod]
        public void MSTestMethod11NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestMethod12NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
