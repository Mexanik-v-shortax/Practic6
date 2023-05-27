using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadanie3Practic6;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static int Sign(double x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            double a = 2;
            double b = 2;
            int exp = 2;

            int signA = Sign(a);
            int signB = Sign(b);
            int result = signA + signB;
            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 4;
            double b = 2;
            int exp = 2;

            int signA = Sign(a);
            int signB = Sign(b);
            int result = signA + signB;
            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 0;
            double b = 0;
            int exp = 0;

            int signA = Sign(a);
            int signB = Sign(b);
            int result = signA + signB;
            Assert.AreEqual(exp, result);
        }
    }
}
