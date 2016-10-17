using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace UnitTest
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void initMatrixBTest()
        {
            int[,] result = { { 1, 4 }, { 2, 3 } };
            int[,] actual = Program.initMatrixB(2);
            Assert.AreEqual(1, actual[0, 0]);
            Assert.AreEqual(2, actual[1, 0]);
            Assert.AreEqual(3, actual[1, 1]);
            Assert.AreEqual(4, actual[0, 1]);
        }
    }
}
