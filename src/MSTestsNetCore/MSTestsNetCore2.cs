using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestsNetCore
{
    [TestClass]
    public class MSTestsNetCore2
    {
        [TestMethod]
        public void MSTestsNetCore21()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestsNetCore22()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
