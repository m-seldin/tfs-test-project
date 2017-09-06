using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsLibrary;
namespace UnitTestProject1
{
    [TestClass]
    public class TestHelperLibrary
    {
        public TestContext TestContext { get; set; }

        HelperFunctions helperFunctions = new HelperFunctions();
        [TestMethod]
        public void TestConcat()
        {
            
            var param1 = "a";
            var param2 = "b";
            var res = helperFunctions.MyConcat(param1, param2);
            

            var shouldFail = TestContext?.Properties["shouldFail"];            
            Trace.WriteLine($"Should fail ? {shouldFail ?? "null"}");

            if (bool.Parse(shouldFail?.ToString()))
                Assert.AreEqual(param1 + param2 ,res,$"Concat should be : {param1 + param2}") ;
            else
            {
                Assert.AreEqual(param1 + param2 + "c", res, $"Concat should be : {param1 + param2}c");
            }
        }

        public void TestPlus()
        {
            var param1 = 1;
            var param2 = 2;
            var res = helperFunctions.MyPlus(param1, param2);
            Assert.AreEqual(param1 + param2, res, $"Concat should be : {param1 + param2}");
        }
    }
}
