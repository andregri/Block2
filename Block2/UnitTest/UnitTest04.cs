﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;

namespace UnitTest
{
    [TestClass]
    public class UnitTest04
    {
        string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        [TestMethod]
        public void numberToWordsLessThanTwenty()
        {
            for (int i = 0; i < units.Length; i++)
            {
                Assert.AreEqual(units[i], Program.numberToWords(i).Trim(), "Number " + i);
            }
        }

        [TestMethod]
        public void numberToWordsTens()
        {
            for (int i = 0; i < tens.Length; i++)
            {
                int number = i * 10;
                Assert.AreEqual(tens[i], Program.numberToWords(number).Trim(), "Number " + number);
            }
        }

        [TestMethod]
        public void numberToWordsHundred()
        {
            for (int i = 1; i < 10; i++)
            {
                int number = i * 100;
                Assert.AreEqual(units[i] + " hundred", Program.numberToWords(number).Trim(), "Number " + number);
            }
        }

        [TestMethod]
        public void numberToWordsTestRandomNumber()
        {
            int n = 279;
            string ntw = "two hundred and seventy-nine";
            Assert.AreEqual(ntw, Program.numberToWords(n).Trim(), "Input number: " + n);
        }
    }
}
