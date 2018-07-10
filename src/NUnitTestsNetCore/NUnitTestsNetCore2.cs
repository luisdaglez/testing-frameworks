using ClassLibraryNetStandard;
using NUnit.Framework;

namespace NUnitTestsNetCore
{
    public class NUnitTestsNetCore2
    {
        [Test]
        public void NUnitTestMethod21()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitTestMethod22()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
