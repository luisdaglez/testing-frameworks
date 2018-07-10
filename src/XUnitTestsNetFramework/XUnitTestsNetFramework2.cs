using ClassLibraryNetStandard;
using Xunit;

namespace XUnitTestsNetFramework
{
    public class XUnitTestsNetFramework2
    {
        [Fact]
        public void XUnitTestsNetFramework21()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTestsNetFramework22()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
