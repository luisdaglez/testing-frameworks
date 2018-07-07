using ClassLibraryNetStandard;
using NUnit.Framework;

namespace TestProjectNUnitNetFramework
{
    public class NUnitTest2NetFramwork
    {
        [Test]
        public void NUnitTestMethod21NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitTestMethod22NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
