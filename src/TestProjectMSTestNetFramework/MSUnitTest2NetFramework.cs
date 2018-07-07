using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectMSTestNetFramework
{
    [TestClass]
    public class MSUnitTest2NetFramework
    {
        [TestMethod]
        public void MSTestMethod21NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestMethod22NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
