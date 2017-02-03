using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver.Tests
{
    [TestClass()]
    public class CalculateTestsCalculate
    {
        [TestMethod()]
        public void CalculateTestValid()
        {
            Calculate p1 = new Calculate(1.0);
            Assert.AreEqual(true, p1.Valid());
        }

      
    }
}