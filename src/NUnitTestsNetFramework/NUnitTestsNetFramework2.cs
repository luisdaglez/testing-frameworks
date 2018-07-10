using ClassLibraryNetStandard;
using NUnit.Framework;

namespace NUnitTestsNetFramework
{
    public class NUnitTest2NetFramework
    {
        [Test]
        public void NUnitTest1NetFramework21()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitTest1NetFramework22()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
