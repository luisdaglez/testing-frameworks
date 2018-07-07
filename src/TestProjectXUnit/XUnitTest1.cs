using ClassLibraryNetStandard;
using Xunit;

namespace TestProjectXUnit
{
    public class XUnitTest1
    {
        [Fact]
        public void XUnitTest11()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTest12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
