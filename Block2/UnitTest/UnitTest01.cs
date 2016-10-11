using System;
using Block2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest01
    {
        [TestMethod]
        public void getMax_bothPositive()
        {
            // arrange
            int firstNumber = 20;
            int secondNumber = 15;

            //Act
            int max = Program.getMax(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(20, max, "Here I am");
        }

        [TestMethod]
        public void getMax_bothNegative()
        {
            int a = -12;
            int b = -3;
            int max = Program.getMax(a, b);
            Assert.AreEqual(-3, max);
        }

        [TestMethod]
        public void getMin_bothPositive()
        {
            int a = 2;
            int b = 9;
            int min = Program.getMin(a, b);
            Assert.AreEqual(2, min);
        }

        [TestMethod]
        public void getMin_bothNegative()
        {
            int a = -3;
            int b = -10;
            int min = Program.getMin(a, b);
            Assert.AreEqual(-10, min);
        }
    }
}
