using ClassLibraryNetStandard;
using NUnit.Framework;

namespace TestProjectNUnitNetFramework
{
    class DataDrivenTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 4, 7)]
        public void SumTests(int a, int b, int sum)
        {
            var foo = new Class1();
            foo.Method1();

            Assert.AreEqual(a + b, sum);
        }
    }
}
