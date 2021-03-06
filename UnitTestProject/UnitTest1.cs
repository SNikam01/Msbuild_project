using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

//This is test project
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
