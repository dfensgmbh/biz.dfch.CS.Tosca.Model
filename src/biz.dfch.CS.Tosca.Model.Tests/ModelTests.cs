using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace biz.dfch.CS.Tosca.Model.Tests
{
    [TestClass]
    public class ModelTests
    {
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
