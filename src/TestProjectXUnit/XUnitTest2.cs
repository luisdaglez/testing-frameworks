using ClassLibraryNetStandard;
using Xunit;

namespace TestProjectXUnit
{
    public class XUnitTest2
    {
        [Fact]
        public void XUnitTest21()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTest22()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
