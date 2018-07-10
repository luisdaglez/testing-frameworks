using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestsNetFramework
{
    [TestClass]
    public class MixedParallelTests
    {
        [TestMethod]
        public void MSTestParallelTest1NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestParallelTest2NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        [DoNotParallelize]
        public void MSTestSerialTest1NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
