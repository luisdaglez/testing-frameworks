using ClassLibraryNetStandard;
using NUnit.Framework;

namespace TestProjectNUnit
{
    public class NUnitTest2
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
