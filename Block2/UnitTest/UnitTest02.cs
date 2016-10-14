using System;
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
            double result = Program.Fibonacci(20);
            Assert.AreEqual(4181d, result, "Error: number shouldn't be " + result);
        }


        [TestMethod]
        public void Fibonacci_firstFourtyNumbers()
        {
            double result = Program.Fibonacci(40);
            Assert.AreEqual(63245986d, result, "Error: number shouldn't be " + result);
        }


        [TestMethod]
        public void Fibonacci_firstSixtyNumbers()
        {
            double result = Program.Fibonacci(60);
            Assert.AreEqual(956722026041d, result, "Error: number shouldn't be " + result);
        }

        [TestMethod]
        public void Fibonacci_firstEightyNumbers()
        {
            double result = Program.Fibonacci(80);
            Assert.AreEqual(14472334024676221d, result, "Error: number shouldn't be " + result);
        }

        [TestMethod]
        public void Fibonacci_firstHundredNumbers()
        {
            double result = Program.Fibonacci(100);
            Assert.AreEqual(218922995834555169026d, result, "Error: number shouldn't be " + result);
        }
    }
}
