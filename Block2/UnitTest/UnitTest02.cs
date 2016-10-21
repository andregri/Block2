using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest02
    {
        [TestMethod]
        public void Fibonacci_firstTwentyNumbers()
        {
            BigInteger result = Program.Fibonacci(20);
            Assert.AreEqual(4181, result, "Error: number shouldn't be " + result);
        }


        [TestMethod]
        public void Fibonacci_firstFourtyNumbers()
        {
            BigInteger result = Program.Fibonacci(40);
            Assert.AreEqual(63245986, result, "Error: number shouldn't be " + result);
        }


        [TestMethod]
        public void Fibonacci_firstSixtyNumbers()
        {
            BigInteger result = Program.Fibonacci(60);
            Assert.AreEqual(956722026041, result, "Error: number shouldn't be " + result);
        }

        [TestMethod]
        public void Fibonacci_firstEightyNumbers()
        {
            BigInteger result = Program.Fibonacci(80);
            Assert.AreEqual(14472334024676221, result, "Error: number shouldn't be " + result);
        }

        [TestMethod]
        public void Fibonacci_firstHundredNumbers()
        {
            BigInteger result = Program.Fibonacci(100);
            BigInteger exp = BigInteger.Parse("218922995834555169026");
            Assert.AreEqual(exp, result, "Error: number shouldn't be " + result);
        }
    }
}
