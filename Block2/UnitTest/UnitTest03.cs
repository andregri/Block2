using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise3;
namespace UnitTest
{
    [TestClass]
    public class UnitTest03
    {
        [TestMethod]
        public void TestPositiveDiscriminant()
        {
            double test = Program.getDiscriminant(4, 9, 2);

            Assert.AreEqual(49, test, "Error: result shouldn't be " + test);
        }
    }
}
