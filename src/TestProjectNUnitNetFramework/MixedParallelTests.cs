using ClassLibraryNetStandard;
using NUnit.Framework;

namespace TestProjectNUnitNetFramework
{
    class MixedParallelTests
    {
        [Test]
        public void NUnitParallelTest1NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitParallelTest2NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [NonParallelizable]
        [Test]
        public void NUnitSerialTest1NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
