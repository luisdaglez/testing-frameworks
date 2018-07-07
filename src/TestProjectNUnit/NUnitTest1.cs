using ClassLibraryNetStandard;
using NUnit.Framework;

namespace TestProjectNUnit
{
    public class NUnitTest1
    {
        [Test]
        public void NUnitTestMethod11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitTestMethod12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
