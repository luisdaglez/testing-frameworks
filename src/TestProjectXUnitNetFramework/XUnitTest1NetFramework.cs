using ClassLibraryNetStandard;
using Xunit;

namespace TestProjectXUnitNetFramework
{
    public class XUnitTest1NetFramework
    {
        [Fact]
        public void XUnitTest11NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTest12NetFramework()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
