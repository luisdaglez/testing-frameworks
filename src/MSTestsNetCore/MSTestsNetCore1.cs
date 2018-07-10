using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestsNetCore
{
    [TestClass]
    public class MSTestsNetCore1
    {
        [TestMethod]
        public void MSTestsNetCore11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSTestsNetCore12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
