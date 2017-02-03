using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diver;

namespace UnitTesttAdmin
{
    [TestClass]
    public class UnitTestHoppare
    {
        [TestMethod]
        public void TestMethod1()
        {
            hoppare h1 = new hoppare();

            Assert.AreEqual("son", true);
        }
    }
}
