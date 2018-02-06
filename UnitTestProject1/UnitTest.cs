using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsLibrary;
namespace UnitTestProject
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

            Assert.AreEqual(param1 + param1 + "c", res, "Concat not working!");

        }
        [TestMethod]
        public void TestPlus()
        {
            var param1 = 1;
            var param2 = 2;
            var res = helperFunctions.MyPlus(param1, param2);
            Assert.AreEqual(param1 + param2, res, "ERROR!");
        }

        [TestMethod]
        public void TestMinus()
        {
            var param1 = 1;
            var param2 = 2;
            var res = helperFunctions.MyMinus(param1, param2);
            Assert.AreEqual(param2 - param1, res, "ERROR!");
        }
    }
}
