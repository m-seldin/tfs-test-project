using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsLibrary;
namespace UnitTestProject1
{
    [TestClass]
    public class TestHelperLibrary
    {
        HelperFunctions helperFunctions = new HelperFunctions();
        [TestMethod]
        public void TestConcat()
        {
            var param1 = "a";
            var param2 = "b";
            var res = helperFunctions.MyConcat(param1, param2);
            Assert.AreEqual(param1 + param2 ,res,$"Concat should be : {param1 + param2}") ;
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
