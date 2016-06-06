using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;

namespace TestWithWhite
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var applicationPath = Path.Combine(@"C:\Users\Rizvi\Documents\Visual Studio 2015\Projects\SampleWhite\SampleWhite\bin\Debug\", "SampleWhite.exe");
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }
    }
}
