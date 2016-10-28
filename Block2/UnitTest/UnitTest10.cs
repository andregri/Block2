using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace UnitTest
{
    [TestClass]
    public class UnitTest10
    {
        public int[] GetRow(int[,] matrix, int row)
        {
            int rowLength = matrix.GetLength(1);
            int[] expected = new int[rowLength];

            for (int i = 0; i < rowLength; i++)
            {
                expected[i] = matrix[row, i];
            }

            return expected;
        }

        [TestMethod]
        public void InitMatrixATestSize2()
        {
            int[,] expected = { { 1, 3 }, { 2, 4 } };
            int[,] matrix = Program.InitMatrixA(2);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void InitMatrixATestSize3()
        {
            int[,] expected = { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
            int[,] matrix = Program.InitMatrixA(3);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void InitMatrixZigZagTestSize2()
        {
            int[,] expected = { { 1, 4 }, { 2, 3 } };
            int[,] matrix = Program.InitMatrixZigZag(2);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void InitMatrixZigZagTestSize3()
        {
            int[,] expected = { { 1, 6, 7 }, { 2, 5, 8 }, { 3, 4, 9 } };
            int[,] matrix = Program.InitMatrixZigZag(3);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void InitMatrixDiagonalTestSize2()
        {
            int[,] expected = { { 2, 4 }, { 1, 3 } };
            int[,] matrix = Program.InitMatrixDiagonal(2);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void InitMatrixDiagonalTestSize3()
        {
            int[,] expected = { { 4, 7, 9 }, { 2, 5, 8 }, { 1, 3, 6 } };
            int[,] matrix = Program.InitMatrixDiagonal(3);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void InitMatrixSpiralTestSize2()
        {
            int[,] expected = { { 0, 3 }, { 1, 2 } };
            int[,] matrix = Program.InitMatrixSpiral(2);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void InitMatrixSpiralTestSize3()
        {
            int[,] expected = { { 0, 7, 6 }, { 1, 8, 5 }, { 2, 3, 4 } };
            int[,] matrix = Program.InitMatrixSpiral(3);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void GoDownTest()
        {
            int[,] expected = { { 1, 0, 0 }, { 2, 0, 0 }, { 3, 0, 0 } };

            int[,] matrix = new int[3, 3];
            Program.GoDown(matrix, 0, 0, 3, 1);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void GoUpTest()
        {
            int[,] expected = { { 3, 0, 0 }, { 2, 0, 0 }, { 1, 0, 0 } };

            int[,] matrix = new int[3, 3];
            Program.GoUp(matrix, 0, 2, 3, 1);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void GoRightTest()
        {
            int[,] expected = { { 0, 1, 2 }, { 0, 0, 0 }, { 0, 0, 0 } };

            int[,] matrix = new int[3, 3];
            Program.GoRight(matrix, 0, 1, 2, 1);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }

        [TestMethod]
        public void GoLeftTest()
        {
            int[,] expected = { { 2, 1, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

            int[,] matrix = new int[3, 3];
            Program.GoLeft(matrix, 0, 1, 2, 1);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(GetRow(expected, i), GetRow(matrix, i));
            }
        }
    }
}
