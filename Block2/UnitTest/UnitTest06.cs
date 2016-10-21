using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6;

namespace UnitTest
{
    [TestClass]
    public class UnitTest06
    {
    	// Test for cheking input by user
        [TestMethod]
        public void isDecimal_positiveInteger()
        {
        	//Arrange
            string number = "20";

            //Act
            bool checkDecimal = Program.isDecimal(number);

            //Assert
            Assert.AreEqual(true, checkDecimal);
        }

        [TestMethod]
        public void isDecimal_hexNumber()
        {
        	//Arrange
            string number = "205f";

            //Act
            bool checkDecimal = Program.isDecimal(number);

            //Assert
            Assert.AreEqual(false, checkDecimal);
        }

        [TestMethod]
        public void isBinary_binaryNumber()
        {
        	//Arrange
            string number = "01010111";

            //Act
            bool checkBinary = Program.isBinary(number);

            //Assert
            Assert.AreEqual(true, checkBinary);
        }

        [TestMethod]
        public void isBinary_positiveNumber()
        {
        	//Arrange
            string number = "23455654";

            //Act
            bool checkBinary = Program.isBinary(number);

            //Assert
            Assert.AreEqual(false, checkBinary);
        }

        [TestMethod]
        public void isHexadecimal_hexNumber()
        {
        	//Arrange
            string number = "345ff";

            //Act
            bool checkHexadecimal = Program.isHexadecimal(number);

            //Assert
            Assert.AreEqual(true, checkHexadecimal);
        }

        // Test for cheking input conversion
        [TestMethod]
        public void decimalToBinary_positiveInteger()
        {
        	//Arrange
            int number = 5;

            //Act
            string binaryConversion = Program.decimalToBinary(number);

            //Assert
            Assert.AreEqual("101", binaryConversion);
        }

        [TestMethod]
        public void binaryToDecimal_fiveBit()
        {
        	//Arrange
            string number = "01011";

            //Act
            int decimalConversion = Program.binaryToDecimal(number);

            //Assert
            Assert.AreEqual(11, decimalConversion);
        }

        [TestMethod]
        public void decimalToHex_positiveInteger()
        {
        	//Arrange
            int  number = 123;

            //Act
            string hexadecimalConversion = Program.decimalToHex(number);

            //Assert
            Assert.AreEqual("7B", hexadecimalConversion);
        }

        [TestMethod]
        public void hexToDecimal_sixDigits()
        {
        	//Arrange
            string number = "78654f";

            //Act
            int decimalConversion = Program.hexToDecimal(number);

            //Assert
            Assert.AreEqual(7890255, decimalConversion);
        }
    }
}
