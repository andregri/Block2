using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace UnitTest
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void initMatrixBTestSize2()
        {
            int[,] result = { { 1, 4 }, { 2, 3 } };
            int[,] actual = Program.initMatrixB(2);
            Assert.AreEqual(1, actual[0, 0]);
            Assert.AreEqual(2, actual[1, 0]);
            Assert.AreEqual(3, actual[1, 1]);
            Assert.AreEqual(4, actual[0, 1]);
        }

        [TestMethod]
        public void initMatrixBTestSize3()
        {
            int[,] result = { { 1, 6, 7 }, { 2, 5, 8 }, { 3, 4, 9 } };
            int[,] actual = Program.initMatrixB(3);
            Assert.AreEqual(1, actual[0, 0]);
            Assert.AreEqual(2, actual[1, 0]);
            Assert.AreEqual(3, actual[2, 0]);
            Assert.AreEqual(4, actual[2, 1]);
            Assert.AreEqual(5, actual[1, 1]);
            Assert.AreEqual(6, actual[0, 1]);
            Assert.AreEqual(7, actual[0, 2]);
            Assert.AreEqual(8, actual[1, 2]);
            Assert.AreEqual(9, actual[2, 2]);
        }
    }
}
