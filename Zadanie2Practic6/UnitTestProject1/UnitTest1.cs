using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadanie2Practic6;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static int f(int x)
        {
            int a = x / 100; // первая цифра
            int b = x % 10; // последняя цифра
            int c = (x / 10) % 10; // средняя цифра

            return b * 100 + c * 10 + a;
        }
        [TestMethod]
        public void TestMethod1()
        {
            int x = 123;
            int exp = 321;
            int y = f(x);
            Assert.AreEqual(exp, y);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int x = 543;
            int exp = 345;
            int y = f(x);
            Assert.AreEqual(exp, y);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int x = 365;
            int exp = 563;
            int y = f(x);
            Assert.AreEqual(exp, y);
        }
    }
}
