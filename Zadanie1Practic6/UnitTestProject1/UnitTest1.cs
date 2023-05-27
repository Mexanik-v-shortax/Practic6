using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadanie1Practic6;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int min(int a, int b)
            {
                if (a < b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            int x = 10;
            int y = 5;
            int z = 15;
            int v = 3;
            double expected = 3;
            int min1 = min(x, y);
            int min2 = min(z, v);
            int result = min(min1, min2);


            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int min(int a, int b)
            {
                if (a < b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            int x = 1;
            int y = 5;
            int z = 15;
            int v = 3;
            double expected = 1;
            int min1 = min(x, y);
            int min2 = min(z, v);
            int result = min(min1, min2);


            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int min(int a, int b)
            {
                if (a < b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            int x = 10;
            int y = 2;
            int z = 54;
            int v = 35;
            double expected = 2;
            int min1 = min(x, y);
            int min2 = min(z, v);
            int result = min(min1, min2);


            Assert.AreEqual(expected, result);
        }
    }
}
