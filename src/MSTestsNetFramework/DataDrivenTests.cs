using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestsNetFramework
{
    [TestClass]
    public class DataDrivenTests
    {
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 4, 7)]
        public void SumTests(int a, int b, int sum)
        {
            var foo = new Class1();
            foo.Method1();

            Assert.AreEqual(a + b, sum);
        }
    }
}
