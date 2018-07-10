using System;
using System.Linq;
using ClassLibraryNetStandard;
using Xunit;

namespace XUnitTestsNetCore
{
    public class CollectionSharedContext : IDisposable
    {
        public object SharedObject { get; private set; }

        public CollectionSharedContext()
        {
            //Db = new SqlConnection("MyConnectionString");
            // ... initialize data in the test database ...
            SharedObject = new { A = 1, B = 2, C = 3 };
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup per collection");
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup per collection");
            var list = Class1.Dictionary.ToList().OrderBy(d => d.Key).Select(d => d.Value);
            if (list != null)
            {
            }
        }
    }

    [CollectionDefinition("Some collection")]
    public class CollectionContextDefinition : ICollectionFixture<CollectionSharedContext>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }

    public class ClassSharedContext : IDisposable
    {
        public object SharedObject { get; private set; }

        public ClassSharedContext()
        {
            //Db = new SqlConnection("MyConnectionString");
            // ... initialize data in the test database ...
            SharedObject = new {A = 1, B = 2, C = 3};
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup per class");
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup per class");
        }
    }

    [Collection("Some collection")]
    public class XUnitTestsNetCoreInitCleanup : IDisposable, IClassFixture<ClassSharedContext>
    {
        private readonly ClassSharedContext _classSharedContext;
        private readonly CollectionSharedContext _collectionSharedContext;

        public XUnitTestsNetCoreInitCleanup(ClassSharedContext classSharedContext, CollectionSharedContext collectionSharedContext)
        {
            _classSharedContext = classSharedContext;
            _collectionSharedContext = collectionSharedContext;
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time setup per method");
        }

        public void Dispose()
        {
            Class1.Dictionary.TryAdd(DateTime.Now.Ticks, "one time cleanup per method");
        }

        [Fact]
        public void XUnitTestMethod1()
        {
            var foo = new Class1();
            foo.Method1();
        }
        [Fact]
        public void XUnitTestMethod2()
        {
            var foo = new Class1();
            foo.Method1();
        }
    }
}
