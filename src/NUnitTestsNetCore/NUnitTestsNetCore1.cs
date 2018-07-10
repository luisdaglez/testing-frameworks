using ClassLibraryNetStandard;
using NUnit.Framework;

namespace NUnitTestsNetCore
{
    public class NUnitTestsNetCore1
    {
        [Test]
        public void NUnitTestsNetCore11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitTestsNetCore12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
