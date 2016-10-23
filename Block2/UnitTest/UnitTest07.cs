using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise7;

namespace UnitTest
{
    [TestClass]
    public class UnitTest07
    {
        public bool containNumber(int[] random, int number)
        {
            int len = random.Length;

            //flag if the number is also in the random array
            bool flag = false;

            //try to find the r-th element in the random array
            for (int j = 0; j < len; j++)
            {
                if (number == random[j])
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public bool isRandom(int[] array)
        {
            bool flag = false;

            for (int i = 1; i < array.Length; i++)
            {
                int diff = array[i] - array[i - 1];

                if (diff != 1)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public int[] initOrderedArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }

        [TestMethod]
        public void containAll10Numbers()
        {
            int n = 10;
            int[] array = initOrderedArray(n);

            for (int i = 0; i < n; i++)
            {
                Assert.IsTrue(containNumber(array, i + 1));
            }
        }

        [TestMethod]
        public void containAll100Numbers()
        {
            int n = 100;
            int[] array = initOrderedArray(n);

            for (int i = 0; i < n; i++)
            {
                Assert.IsTrue(containNumber(array, i + 1));
            }
        }

        [TestMethod]
        public void testIsRandom10()
        {
            int[] array = Program.RandomizeArray(10);

            bool flag = isRandom(array);

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void testIsRandom100()
        {
            int[] array = Program.RandomizeArray(100);

            bool flag = isRandom(array);

            Assert.IsTrue(flag);
        }
    }
}
