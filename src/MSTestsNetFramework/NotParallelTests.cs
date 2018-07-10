using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestsNetFramework
{
    [TestClass]
    [DoNotParallelize]
    public class NotParallelTests
    {
        [TestMethod]
        public void MSTestSerialTest1NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestSerialTest2NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
