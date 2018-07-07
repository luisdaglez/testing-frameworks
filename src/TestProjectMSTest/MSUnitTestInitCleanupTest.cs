using System;
using System.Linq;
using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectMSTest
{
    [TestClass]
    public class MySetUpClass
    {
        [AssemblyInitialize]
        public static void RunBeforeAnyTests(TestContext context)
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup per assembly");
        }

        [AssemblyCleanup]
        public static void RunAfterAnyTests()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup per assembly");
            var list = Class1.Dictionary.ToList().OrderBy(d => d.Key).Select(d => d.Value);
            if (list != null)
            {
            }
        }
    }
    [TestClass]
    public class MSUnitTestInitCleanupTest
    {
        [ClassInitialize]
        public static void InitPerClass(TestContext testContext)
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup per class");
        }
        [ClassCleanup]
        public static void CleanupPerClass()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup per class");
        }
        [TestInitialize]
        public void InitPerMethod()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup per method");
        }
        [TestCleanup]
        public void CleanupPerMethod()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup per method");
        }
        [TestMethod]
        public void MSUnitTestMethod1()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [TestMethod]
        public void MSUnitTestMethod2()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
