using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MstestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 4;
            int j = 2 + 2;
            Assert.AreEqual(j, i);
        }

        [TestMethod]
        public void TestStringCompare()
        {
            String input = "Test";
            String output = "Test";
            Assert.AreSame(input, output,"Strings are equal,Test passed");
        }
    }
}
