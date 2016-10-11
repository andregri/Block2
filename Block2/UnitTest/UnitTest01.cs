using System;
using Block2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest01
    {
        [TestMethod]
        public void getMax_positiveInteger()
        {
            // arrange
            int firstNumber = 20;
            int secondNumber = 15;

            //Act
            int max = Program.getMax(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(20, max, "Here I am");
        }


    }
}
