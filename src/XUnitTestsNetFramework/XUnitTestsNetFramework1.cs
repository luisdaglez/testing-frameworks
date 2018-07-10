using ClassLibraryNetStandard;
using Xunit;

namespace XUnitTestsNetFramework
{
    public class XUnitTestsNetFramework1
    {
        [Fact]
        public void XUnitTestsNetFramework11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTestsNetFramework12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
