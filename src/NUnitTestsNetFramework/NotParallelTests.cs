using ClassLibraryNetStandard;
using NUnit.Framework;

namespace NUnitTestsNetFramework
{
    [NonParallelizable]
    class NotParallelTests
    {
        [Test]
        public void NUnitSerialTest1NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitSerialTest2NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
