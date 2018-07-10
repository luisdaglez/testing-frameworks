using ClassLibraryNetStandard;
using NUnit.Framework;

namespace NUnitTestsNetFramework
{
    public class NUnitTest1NetFramework
    {
        [Test]
        public void NUnitTest1NetFramework11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitTest1NetFramework12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
