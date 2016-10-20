using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise8;

namespace UnitTest
{
    [TestClass]
    public class UnitTest08
    {
        [TestMethod]
        public void gcd_primeNumbers()
        {
            int gcd = Program.greatestCommonDivisor(17, 13);
            Assert.AreEqual(1, gcd);
        }

        [TestMethod]
        public void gcd_equalsNumbers()
        {
            int gcd = Program.greatestCommonDivisor(18, 18);
            Assert.AreEqual(18, gcd);
        }

        [TestMethod]
        public void gcd_randomNumbers()
        {
            int gcd = Program.greatestCommonDivisor(56, 42);
            Assert.AreEqual(14, gcd);
        }

        [TestMethod]
        public void lcm_randomNumbers()
        {
            int gcd = Program.leastCommonMultiple(34, 63);
            Assert.AreEqual(2142, gcd);
        }

        [TestMethod]
        public void lcm_equalsNumbers()
        {
            int gcd = Program.leastCommonMultiple(8, 8);
            Assert.AreEqual(8, gcd);
        }

        [TestMethod]
        public void lcm_primeNumbers()
        {
            int gcd = Program.leastCommonMultiple(7, 11);
            Assert.AreEqual(77, gcd);
        }
    }
}
