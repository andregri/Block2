﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise9;

namespace UnitTest
{
    [TestClass]
    public class UnitTest09
    {
        [TestMethod]
        public void findLengthIncreasingSequenceTest()
        {
            int[] array = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            int[] result = Program.findLengthIncreasingSequence(array);
            int[] expected = { 1, 1, 1, 2, 2, 3, 3, 3, 4, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], "Index: " + i);
            }
        }

        [TestMethod]
        public void findLengthIncreasingSequenceTest_VanDerCorputSequence()
        {
            int[] array = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            int[] result = Program.findLengthIncreasingSequence(array);
            int[] expected = { 1, 2, 2, 3, 2, 3, 3, 4, 2, 4, 3, 5, 3, 5, 4, 6 };

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], "Index: " + i);
            }
        }

        [TestMethod]
        public void findLongestIncreasingSequenceTest()
        {
            int[] array = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            int[] result = Program.findLongestIncreasingSequence(array);
            int[] expected = { 2, 4, 7, 8 };

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(expected[i], result[i], "Index: " + i);
            }
        }

        [TestMethod]
        public void findLongestIncreasingSequenceTest_VanDerCorputSequence()
        {
            int[] array = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            int[] result = Program.findLongestIncreasingSequence(array);
            int[] expected = { 0, 4, 6, 9, 13, 15 };

            for (int i = 0; i < 6; i++)
            {
                Assert.AreEqual(expected[i], result[i], "Index: " + i);
            }
        }
    }
}
