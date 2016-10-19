using System;
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
                Assert.AreEqual(expected[i], result[i], "Index: "+ i);
            }
        }
    }
}
