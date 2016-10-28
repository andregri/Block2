using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace UnitTest
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void InitMatrixATestSize2()
        {
            int[,] result = { { 1, 3 }, { 2, 4 } };
            int[,] actual = Program.InitMatrixA(2);
            Assert.AreEqual(result[0, 0], actual[0, 0]);
            Assert.AreEqual(result[1, 0], actual[1, 0]);
            Assert.AreEqual(result[1, 1], actual[1, 1]);
            Assert.AreEqual(result[0, 1], actual[0, 1]);
        }

        [TestMethod]
        public void InitMatrixATestSize3()
        {
            int[,] result = { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
            int[,] actual = Program.InitMatrixA(3);
            Assert.AreEqual(result[0, 0], actual[0, 0]);
            Assert.AreEqual(result[0, 1], actual[0, 1]);
            Assert.AreEqual(result[0, 2], actual[0, 2]);
            Assert.AreEqual(result[1, 0], actual[1, 0]);
            Assert.AreEqual(result[1, 1], actual[1, 1]);
            Assert.AreEqual(result[1, 2], actual[1, 2]);
            Assert.AreEqual(result[2, 0], actual[2, 0]);
            Assert.AreEqual(result[2, 1], actual[2, 1]);
            Assert.AreEqual(result[2, 2], actual[2, 2]);
        }

        [TestMethod]
        public void InitMatrixZigZagTestSize2()
        {
            int[,] result = { { 1, 4 }, { 2, 3 } };
            int[,] actual = Program.InitMatrixZigZag(2);
            Assert.AreEqual(result[0, 0], actual[0, 0]);
            Assert.AreEqual(result[1, 0], actual[1, 0]);
            Assert.AreEqual(result[1, 1], actual[1, 1]);
            Assert.AreEqual(result[0, 1], actual[0, 1]);
        }

        [TestMethod]
        public void InitMatrixZigZagTestSize3()
        {
            int[,] result = { { 1, 6, 7 }, { 2, 5, 8 }, { 3, 4, 9 } };
            int[,] actual = Program.InitMatrixZigZag(3);
            Assert.AreEqual(result[0, 0], actual[0, 0]);
            Assert.AreEqual(result[0, 1], actual[0, 1]);
            Assert.AreEqual(result[0, 2], actual[0, 2]);
            Assert.AreEqual(result[1, 0], actual[1, 0]);
            Assert.AreEqual(result[1, 1], actual[1, 1]);
            Assert.AreEqual(result[1, 2], actual[1, 2]);
            Assert.AreEqual(result[2, 0], actual[2, 0]);
            Assert.AreEqual(result[2, 1], actual[2, 1]);
            Assert.AreEqual(result[2, 2], actual[2, 2]);
        }

        [TestMethod]
        public void InitMatrixDiagonalTestSize2()
        {
            int[,] result = { { 2, 4 }, { 1, 3 } };
            int[,] actual = Program.InitMatrixDiagonal(2);
            Assert.AreEqual(result[0, 0], actual[0, 0]);
            Assert.AreEqual(result[1, 0], actual[1, 0]);
            Assert.AreEqual(result[1, 1], actual[1, 1]);
            Assert.AreEqual(result[0, 1], actual[0, 1]);
        }

        [TestMethod]
        public void InitMatrixDiagonalTestSize3()
        {
            int[,] result = { { 4, 7, 9 }, { 2, 5, 8 }, { 1, 3, 6 } };
            int[,] actual = Program.InitMatrixDiagonal(3);
            Assert.AreEqual(result[0, 0], actual[0, 0]);
            Assert.AreEqual(result[0, 1], actual[0, 1]);
            Assert.AreEqual(result[0, 2], actual[0, 2]);
            Assert.AreEqual(result[1, 0], actual[1, 0]);
            Assert.AreEqual(result[1, 1], actual[1, 1]);
            Assert.AreEqual(result[1, 2], actual[1, 2]);
            Assert.AreEqual(result[2, 0], actual[2, 0]);
            Assert.AreEqual(result[2, 1], actual[2, 1]);
            Assert.AreEqual(result[2, 2], actual[2, 2]);
        }

        [TestMethod]
        public void InitMatrixSpiralTestSize2()
        {
            int[,] result = { { 0, 3 }, { 1, 2 } };
            int[,] actual = Program.InitMatrixSpiral(2);
            Assert.AreEqual(result[0, 0], actual[0, 0]);
            Assert.AreEqual(result[1, 0], actual[1, 0]);
            Assert.AreEqual(result[1, 1], actual[1, 1]);
            Assert.AreEqual(result[0, 1], actual[0, 1]);
        }

        [TestMethod]
        public void InitMatrixSpiralTestSize3()
        {
            int[,] result = { { 0, 7, 6 }, { 1, 8, 5 }, { 2, 3, 4 } };
            int[,] actual = Program.InitMatrixSpiral(3);
            Assert.AreEqual(result[0, 0], actual[0, 0]);
            Assert.AreEqual(result[0, 1], actual[0, 1]);
            Assert.AreEqual(result[0, 2], actual[0, 2]);
            Assert.AreEqual(result[1, 0], actual[1, 0]);
            Assert.AreEqual(result[1, 1], actual[1, 1]);
            Assert.AreEqual(result[1, 2], actual[1, 2]);
            Assert.AreEqual(result[2, 0], actual[2, 0]);
            Assert.AreEqual(result[2, 1], actual[2, 1]);
            Assert.AreEqual(result[2, 2], actual[2, 2]);
        }

        [TestMethod]
        public void GoDownTest()
        {
            int[,] matrix = new int[3, 3];
            Program.GoDown(matrix, 0, 0, 3, 1);
            Assert.AreEqual(1, matrix[0, 0]);
            Assert.AreEqual(2, matrix[1, 0]);
            Assert.AreEqual(3, matrix[2, 0]);
        }

        [TestMethod]
        public void GoUpTest()
        {
            int[,] matrix = new int[3, 3];
            Program.GoUp(matrix, 0, 2, 3, 1);
            Assert.AreEqual(3, matrix[0, 0]);
            Assert.AreEqual(2, matrix[1, 0]);
            Assert.AreEqual(1, matrix[2, 0]);
        }

        [TestMethod]
        public void GoRightTest()
        {
            int[,] matrix = new int[3, 3];
            Program.GoRight(matrix, 0, 1, 2, 1);
            Assert.AreEqual(1, matrix[0, 1]);
            Assert.AreEqual(2, matrix[0, 2]);
        }

        [TestMethod]
        public void GoLeftTest()
        {
            int[,] matrix = new int[3, 3];
            Program.GoLeft(matrix, 0, 1, 2, 1);
            Assert.AreEqual(1, matrix[0, 1]);
            Assert.AreEqual(2, matrix[0, 0]);
        }
    }
}
