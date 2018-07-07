using ClassLibraryNetStandard;
using Xunit;

namespace TestProjectXUnitNetFramework
{
    public class XUnitTest2NetFramework
    {
        [Fact]
        public void XUnitTest21NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTest22NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
