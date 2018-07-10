using ClassLibraryNetStandard;
using Xunit;

namespace XUnitTestsNetCore
{
    public class XUnitTestsNetCore2
    {
        [Fact]
        public void XUnitTestsNetCore21()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTestsNetCore22()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
