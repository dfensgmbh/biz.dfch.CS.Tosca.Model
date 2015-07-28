using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace biz.dfch.CS.Tosca.Model.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        [Timeout(1000)]
        public void SleepingThrowsTimeoutException()
        {
            System.Threading.Thread.Sleep(5000);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividingByZeroThrowsDivideByZeroException()
        {
            var x = 1;
            var y = 0;
            var result = x / y;
            Assert.AreNotEqual(0, result);
        }
    }
}
