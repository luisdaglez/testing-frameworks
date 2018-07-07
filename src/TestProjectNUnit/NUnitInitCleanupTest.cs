using System;
using System.Linq;
using ClassLibraryNetStandard;
using NUnit.Framework;

[SetUpFixture]
public class MySetUpClass
{
    [OneTimeSetUp]
    public void RunBeforeAnyTests()
    {
        Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup for all classes in all namespaces");
    }

    [OneTimeTearDown]
    public void RunAfterAnyTests()
    {
        Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup for all classes in all namespaces");
        var list = Class1.Dictionary.ToList().OrderBy(d => d.Key).Select(d => d.Value);
        if (list != null)
        {
        }
    }
}

namespace TestProjectNUnit
{
    [SetUpFixture]
    public class MySetUpClass
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup for all classes in namespace");
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup for all classes in namespace");
        }
    }
    public class NUnitInitCleanupTest
    {

        [OneTimeSetUp]
        public void InitPerClass()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup per class");
        }
        [OneTimeTearDown]
        public void CleanupPerClass()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup per class");
        }
        [SetUp]
        public void InitPerMethod()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup per method");
        }
        [TearDown]
        public void CleanupPerMethod()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup per method");
        }
        [Test]
        public void NUnitTestMethod()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Test]
        public void NUnitTestMethod12()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
