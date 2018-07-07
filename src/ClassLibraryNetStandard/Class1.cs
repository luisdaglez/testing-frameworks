using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace ClassLibraryNetStandard
{
    public class Class1
    {
        public static ConcurrentDictionary<long, string> Dictionary = new ConcurrentDictionary<long, string>();

        public void Method1()
        {
            var assembly = Assembly.GetCallingAssembly();

            var stackTrace = new StackTrace();
            // get calling method name
            var name = stackTrace.GetFrame(1).GetMethod().Name;
            Dictionary.TryAdd(DateTime.Now.Ticks, name + " " + assembly.FullName);
            Thread.Sleep(5000);
        }
    }
}