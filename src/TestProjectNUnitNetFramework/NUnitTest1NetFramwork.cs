using ClassLibraryNetStandard;
using NUnit.Framework;

namespace TestProjectNUnitNetFramework
{
    public class NUnitTest1NetFramwork
    {
        [Test]
        public void NUnitTestMethod11NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitTestMethod12NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
