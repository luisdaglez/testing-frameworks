using ClassLibraryNetStandard;
using Xunit;

namespace XUnitTestsNetCore
{
    public class XUnitTestsNetCore1
    {
        [Fact]
        public void XUnitTestsNetCore11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTestsNetCore12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
